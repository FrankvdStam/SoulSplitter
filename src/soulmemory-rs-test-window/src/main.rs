// This file is part of the SoulSplitter distribution (https://github.com/FrankvdStam/SoulSplitter).
// Copyright (c) 2022 Frank van der Stam.
// https://github.com/FrankvdStam/SoulSplitter/blob/main/LICENSE
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, version 3.
//
// This program is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
// General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program. If not, see <http://www.gnu.org/licenses/>.

use std::ops::Deref;
use imgui::{Condition, TreeNodeFlags, Ui};
use imgui::sys::igSetNextWindowPos;
use windows::Win32::Foundation::HINSTANCE;
use soulmemory_rs::App;
use soulmemory_rs::games::{GameExt, MockGame};
use rand::{random, Rng};
use soulmemory_rs::games::traits::buffered_emevd_logger::{BufferedEmevdCall, BufferedEmevdLogger};
use soulmemory_rs::games::traits::buffered_event_flags::EventFlag;

use std::{num::NonZeroU32, time::Instant};

use glow::HasContext;
use glutin::{
    config::ConfigTemplateBuilder,
    context::{ContextAttributesBuilder, NotCurrentGlContext, PossiblyCurrentContext},
    display::{GetGlDisplay, GlDisplay},
    surface::{GlSurface, Surface, SurfaceAttributesBuilder, WindowSurface},
};
use imgui_winit_support::{
    winit::{
        dpi::LogicalSize,
        event_loop::EventLoop,
        window::{Window, WindowAttributes},
    },
    WinitPlatform,
};
use raw_window_handle::HasWindowHandle;
use copypasta::{ClipboardContext, ClipboardProvider};
use imgui::ClipboardBackend;

fn main()
{
    App::init(&String::from("mockgame.exe"), HINSTANCE(std::ptr::null_mut()));
    let instance = App::get_instance();
    let mut app = instance.lock().unwrap();

    // Common setup for creating a winit window and imgui context, not specifc
    // to this renderer at all except that glutin is used to create the window
    // since it will give us access to a GL context
    let (event_loop, window, surface, context) = create_window();
    let (mut winit_platform, mut imgui_context) = imgui_init(&window);

    app.render_initialize(&mut imgui_context);

    if let Some(backend) = clipboard_init()
    {
        imgui_context.set_clipboard_backend(backend);
    }


    // OpenGL context from glow
    let gl = unsafe { glow::Context::from_loader_function_cstr(|s| context.display().get_proc_address(s).cast()) };

    // OpenGL renderer from this crate
    let mut ig_renderer = imgui_glow_renderer::AutoRenderer::new(gl, &mut imgui_context)
        .expect("failed to create renderer");

    let mut last_frame = Instant::now();

    // Standard winit event loop
    #[allow(deprecated)]
    event_loop
        .run(move |event, window_target| {
            match event {
                winit::event::Event::NewEvents(_) => {
                    let now = Instant::now();
                    imgui_context
                        .io_mut()
                        .update_delta_time(now.duration_since(last_frame));
                    last_frame = now;
                }
                winit::event::Event::AboutToWait => {
                    winit_platform
                        .prepare_frame(imgui_context.io_mut(), &window)
                        .unwrap();
                    window.request_redraw();
                }
                winit::event::Event::WindowEvent {
                    event: winit::event::WindowEvent::RedrawRequested,
                    ..
                } => {
                    // The renderer assumes you'll be clearing the buffer yourself
                    unsafe { ig_renderer.gl_context().clear(glow::COLOR_BUFFER_BIT) };

                    let ui = imgui_context.frame();

                    ui.show_demo_window(&mut true);
                    app.render(ui);
                    draw_controls(ui, &mut app);

                    winit_platform.prepare_render(ui, &window);
                    let draw_data = imgui_context.render();

                    // This is the only extra render step to add
                    ig_renderer
                        .render(draw_data)
                        .expect("error rendering imgui");

                    surface
                        .swap_buffers(&context)
                        .expect("Failed to swap buffers");
                }
                winit::event::Event::WindowEvent {
                    event: winit::event::WindowEvent::CloseRequested,
                    ..
                } => {
                    window_target.exit();
                }
                winit::event::Event::WindowEvent {
                    event: winit::event::WindowEvent::Resized(new_size),
                    ..
                } => {
                    if new_size.width > 0 && new_size.height > 0 {
                        surface.resize(
                            &context,
                            NonZeroU32::new(new_size.width).unwrap(),
                            NonZeroU32::new(new_size.height).unwrap(),
                        );
                    }
                    winit_platform.handle_event(imgui_context.io_mut(), &window, &event);
                }
                event => {
                    winit_platform.handle_event(imgui_context.io_mut(), &window, &event);
                }
            }
        })
        .expect("EventLoop error");
}

fn create_window() -> (
    EventLoop<()>,
    Window,
    Surface<WindowSurface>,
    PossiblyCurrentContext,
) {
    let event_loop = EventLoop::new().unwrap();

    let window_attributes = WindowAttributes::default()
        .with_title("soulmemory-rs")
        .with_inner_size(LogicalSize::new(1024, 768));
    let (window, cfg) = glutin_winit::DisplayBuilder::new()
        .with_window_attributes(Some(window_attributes))
        .build(&event_loop, ConfigTemplateBuilder::new(), |mut configs| {
            configs.next().unwrap()
        })
        .expect("Failed to create OpenGL window");

    let window = window.unwrap();

    let context_attribs =
        ContextAttributesBuilder::new().build(Some(window.window_handle().unwrap().as_raw()));
    let context = unsafe {
        cfg.display()
            .create_context(&cfg, &context_attribs)
            .expect("Failed to create OpenGL context")
    };

    let surface_attribs = SurfaceAttributesBuilder::<WindowSurface>::new()
        .with_srgb(Some(true))
        .build(
            window.window_handle().unwrap().as_raw(),
            NonZeroU32::new(1024).unwrap(),
            NonZeroU32::new(768).unwrap(),
        );
    let surface = unsafe {
        cfg.display()
            .create_window_surface(&cfg, &surface_attribs)
            .expect("Failed to create OpenGL surface")
    };

    let context = context
        .make_current(&surface)
        .expect("Failed to make OpenGL context current");

    (event_loop, window, surface, context)
}

fn imgui_init(window: &Window) -> (WinitPlatform, imgui::Context) {
    let mut imgui_context = imgui::Context::create();
    imgui_context.set_ini_filename(None);

    let mut winit_platform = WinitPlatform::new(&mut imgui_context);
    winit_platform.attach_window(
        imgui_context.io_mut(),
        window,
        imgui_winit_support::HiDpiMode::Rounded,
    );

    imgui_context
        .fonts()
        .add_font(&[imgui::FontSource::DefaultFontData { config: None }]);

    imgui_context.io_mut().font_global_scale = (1.0 / winit_platform.hidpi_factor()) as f32;

    (winit_platform, imgui_context)
}

pub struct ClipboardSupport(pub ClipboardContext);

pub fn clipboard_init() -> Option<ClipboardSupport> {
    ClipboardContext::new().ok().map(ClipboardSupport)
}

impl ClipboardBackend for ClipboardSupport {
    fn get(&mut self) -> Option<String> {
        self.0.get_contents().ok()
    }
    fn set(&mut self, text: &str) {
        // ignore errors?
        let _ = self.0.set_contents(text.to_owned());
    }
}

fn render_fun(run: &mut bool, ui: &mut Ui)
{
    let instance = App::get_instance();
    let mut app = instance.lock().unwrap();

    app.refresh().unwrap();
    app.render(ui);

    draw_controls(ui, &mut app);


    unsafe{ igSetNextWindowPos([800.0f32, 50.0f32].into(), Condition::Appearing as i32, [1.5f32, 0.5f32].into()) };
    ui.show_demo_window(run);

}

pub struct UiState
{
    event_flag_clicked: bool,
    emevd_log_clicked: bool,
}

static mut UI_STATE: UiState = UiState
{
    event_flag_clicked: true,
    emevd_log_clicked: false,
};

fn draw_controls(ui: &mut Ui, app: &mut App)
{
    ui.window("Controls")
        .size([500.0,800.0], Condition::Appearing)
        .position([600.0f32, 50.0f32], Condition::Appearing)
        .build(||
    {
        if ui.collapsing_header("event flags", TreeNodeFlags::DEFAULT_OPEN)
        {
            if let Some(mock_game) = GameExt::get_game_ref::<MockGame>(app.game.deref())
            {
                if ui.button("raise random event flag")
                {
                    mock_game.raise_event_flag(EventFlag::new(chrono::offset::Local::now(), random::<u32>(), random::<u32>() % 2 == 0));
                }
            }
        }

        if ui.collapsing_header("emevd log", TreeNodeFlags::DEFAULT_OPEN)
        {
            if let Some(mock_game) = GameExt::get_game_ref::<MockGame>(app.game.deref())
            {
                if ui.button("raise random emevd event")
                {
                    let event = get_random_emevd_event(mock_game);
                    mock_game.raise_emevd_event(event);
                }
            }
        }

        #[allow(static_mut_refs)]
        let ui_state: &mut UiState = unsafe{&mut UI_STATE};

        ui.columns(2, "columnsId", true);

        if ui.button("event flags", )
        {
            ui_state.event_flag_clicked = true;
            ui_state.emevd_log_clicked = false;
        }

        if ui.button("emevd log")
        {
            ui_state.event_flag_clicked = false;
            ui_state.emevd_log_clicked = true;
        }


        ui.next_column();

        if ui_state.event_flag_clicked
        {
            ui.text("event flags");
        }

        if ui_state.emevd_log_clicked
        {
            ui.text("emevd log");
        }




        /*
        if ui.collapsing_header("position", TreeNodeFlags::empty())
        {
            ui.text("x:");
            ui.text("y:");
            ui.text("z:");
        }

        */
    });
}

fn get_random_emevd_event(mock_game: &MockGame) -> BufferedEmevdCall
{
    let mut log =  String::new();
    let emedf = mock_game.get_game_emevd_definitions();
    let mut rng = rand::rng();
    let event_id = rng.random_range(0..15000000);
    let group = rng.random_range(0..emedf.main_classes.len());
    let type_ = if emedf.main_classes[group].instrs.len() > 0
    {
        rng.random_range(0..emedf.main_classes[group].instrs.len())
    }
    else
    {
        0
    };

    let item = emedf.main_classes.iter().find(|p| p.index as u32 == group as u32);
    if let Some(class_doc) = item
    {
        log.push_str(class_doc.name.as_str());

        let item = class_doc.instrs.iter().find(|p| p.index as u32 == type_ as u32 );
        if let Some(inst_doc) = item
        {
            log.push(' ');
            log.push_str(inst_doc.name.as_str());
        }
        else
        {
            log.push_str("unknown type");
        }
    }
    else
    {
        log.push_str("unknown group");
    }

    log.push_str(format!("{} - {} [{}] ", event_id, group, type_).as_str());
    return BufferedEmevdCall::new(chrono::offset::Local::now(), event_id as u32, group as u32, type_ as u32, log);
}

fn init_data()
{
    let instance = App::get_instance();
    let app = instance.lock().unwrap();

    if let Some(mock_game) = GameExt::get_game_ref::<MockGame>(app.game.deref())
    {
        //event flags
        for _ in 0..200
        {
            mock_game.raise_event_flag(EventFlag::new(chrono::offset::Local::now(), random::<u32>(), random::<u32>() % 2 == 0));
        }

        //emevd events
        for _ in 0..200
        {
            let event = get_random_emevd_event(mock_game);
            mock_game.raise_emevd_event(event);
        }
    }
}

