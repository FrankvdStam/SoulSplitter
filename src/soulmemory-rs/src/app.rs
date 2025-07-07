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

use std::sync::{Arc, Mutex};
use windows::Win32::Foundation::HINSTANCE;
use imgui::{Condition, Context, Ui};
use crate::widgets::widget::Widget;
use crate::util::server::Server;
use crate::widgets::ai_toggle_widget::AiToggleWidget;
use crate::widgets::basic_position_widget::PlayerPositionWidget;
use crate::widgets::chr_dbg_flags_widget::ChrDbgFlagsWidget;
use crate::widgets::event_flag_widget::EventFlagWidget;
use crate::widgets::misc_widget::MiscWidget;
use crate::games::*;
use crate::util::WINDOW_TITLE_STR;
use crate::widgets::emevd_logger_widget::EmevdLoggerWidget;

pub struct App
{
    pub game: Box<dyn Game>,
    pub hmodule: HINSTANCE,
    #[allow(dead_code)]
    server: Server,
    widgets: Vec<Box<dyn Widget>>,
}

impl App
{
    pub fn init(process_name: &String, hmodule: HINSTANCE)
    {
        unsafe
        {
            if APP.is_some()
            {
                panic!("init called on app while it is already instantiated.");
            }
            APP = Some(Arc::new(Mutex::new(App::new(process_name, hmodule))));
        };
    }

    pub fn get_instance() -> Arc<Mutex<App>>
    {
        unsafe
        {
            if APP.is_none()
            {
                panic!("get_instance called on app while it is not instantiated.");
            }
            return Arc::clone(APP.as_mut().unwrap());
        };
    }

    pub fn new(process_name: &String, hmodule: HINSTANCE) -> Self
    {
        //Init the game we're injected in
        let game: Box<dyn Game> = match process_name.to_lowercase().as_str()
        {
            "mockgame.exe"              => Box::new(MockGame::new()),
            "darksouls.exe"             => Box::new(DarkSoulsPrepareToDieEdition::new()),
            #[cfg(target_arch = "x86_64")]
            "darksoulsii.exe"           => Box::new(DarkSouls2ScholarOfTheFirstSin::new()),
            #[cfg(target_arch = "x86")]
            "darksoulsii.exe"           => Box::new(DarkSouls2Vanilla::new()),
            "darksoulsremastered.exe"   => Box::new(DarkSoulsRemastered::new()),
            "darksoulsiii.exe"          => Box::new(DarkSouls3::new()),
            "sekiro.exe"                => Box::new(Sekiro::new()),
            "eldenring.exe"             => Box::new(EldenRing::new()),
            "armoredcore6.exe"          => Box::new(ArmoredCore6::new()),
            "shadps4.exe"               => Box::new(Bloodborne::new()),
            _                           => panic!("unsupported process: {}", process_name.to_lowercase()),
        };

        //get drawable widgets
        //let widgets = game.get_widgets();

        App
        {
            game,
            hmodule,
            server: Server::new(String::from("127.0.0.1:54345")),
            widgets: vec!
            {
                Box::new(EventFlagWidget::new()),
                Box::new(AiToggleWidget::new()),
                Box::new(PlayerPositionWidget::new()),
                Box::new(ChrDbgFlagsWidget::new()),
                Box::new(MiscWidget::new()),
                Box::new(EmevdLoggerWidget::new()),
            }
        }
    }

    pub fn refresh(&mut self) -> Result<(), String>
    {
        self.game.refresh()?;
        Ok(())
    }
    pub fn render_initialize(&mut self, _context: &mut Context)
    {
        return;


        //info!("initialize");
        //let style = context.style_mut();
//
        //style[StyleColor::Text]                   = [1.00f32, 1.00f32, 1.00f32, 1.00f32];
        //style[StyleColor::Text]                   = [1.00f32, 1.00f32, 1.00f32, 1.00f32];
        //style[StyleColor::TextDisabled]           = [0.50f32, 0.50f32, 0.50f32, 1.00f32];
        //style[StyleColor::WindowBg]               = [0.10f32, 0.10f32, 0.10f32, 1.00f32];
        //style[StyleColor::ChildBg]                = [0.00f32, 0.00f32, 0.00f32, 0.00f32];
        //style[StyleColor::PopupBg]                = [0.19f32, 0.19f32, 0.19f32, 0.92f32];
        //style[StyleColor::Border]                 = [0.19f32, 0.19f32, 0.19f32, 0.29f32];
        //style[StyleColor::BorderShadow]           = [0.00f32, 0.00f32, 0.00f32, 0.24f32];
        //style[StyleColor::FrameBg]                = [0.05f32, 0.05f32, 0.05f32, 0.54f32];
        //style[StyleColor::FrameBgHovered]         = [0.19f32, 0.19f32, 0.19f32, 0.54f32];
        //style[StyleColor::FrameBgActive]          = [0.20f32, 0.22f32, 0.23f32, 1.00f32];
        //style[StyleColor::TitleBg]                = [0.00f32, 0.00f32, 0.00f32, 1.00f32];
        //style[StyleColor::TitleBgActive]          = [0.06f32, 0.06f32, 0.06f32, 1.00f32];
        //style[StyleColor::TitleBgCollapsed]       = [0.00f32, 0.00f32, 0.00f32, 1.00f32];
        //style[StyleColor::MenuBarBg]              = [0.14f32, 0.14f32, 0.14f32, 1.00f32];
        //style[StyleColor::ScrollbarBg]            = [0.05f32, 0.05f32, 0.05f32, 0.54f32];
        //style[StyleColor::ScrollbarGrab]          = [0.34f32, 0.34f32, 0.34f32, 0.54f32];
        //style[StyleColor::ScrollbarGrabHovered]   = [0.40f32, 0.40f32, 0.40f32, 0.54f32];
        //style[StyleColor::ScrollbarGrabActive]    = [0.56f32, 0.56f32, 0.56f32, 0.54f32];
        //style[StyleColor::CheckMark]              = [0.33f32, 0.67f32, 0.86f32, 1.00f32];
        //style[StyleColor::SliderGrab]             = [0.34f32, 0.34f32, 0.34f32, 0.54f32];
        //style[StyleColor::SliderGrabActive]       = [0.56f32, 0.56f32, 0.56f32, 0.54f32];
        //style[StyleColor::Button]                 = [0.05f32, 0.05f32, 0.05f32, 0.54f32];
        //style[StyleColor::ButtonHovered]          = [0.19f32, 0.19f32, 0.19f32, 0.54f32];
        //style[StyleColor::ButtonActive]           = [0.20f32, 0.22f32, 0.23f32, 1.00f32];
        //style[StyleColor::Header]                 = [0.00f32, 0.00f32, 0.00f32, 0.52f32];
        //style[StyleColor::HeaderHovered]          = [0.00f32, 0.00f32, 0.00f32, 0.36f32];
        //style[StyleColor::HeaderActive]           = [0.20f32, 0.22f32, 0.23f32, 0.33f32];
        //style[StyleColor::Separator]              = [0.28f32, 0.28f32, 0.28f32, 0.29f32];
        //style[StyleColor::SeparatorHovered]       = [0.44f32, 0.44f32, 0.44f32, 0.29f32];
        //style[StyleColor::SeparatorActive]        = [0.40f32, 0.44f32, 0.47f32, 1.00f32];
        //style[StyleColor::ResizeGrip]             = [0.28f32, 0.28f32, 0.28f32, 0.29f32];
        //style[StyleColor::ResizeGripHovered]      = [0.44f32, 0.44f32, 0.44f32, 0.29f32];
        //style[StyleColor::ResizeGripActive]       = [0.40f32, 0.44f32, 0.47f32, 1.00f32];
        //style[StyleColor::Tab]                    = [0.00f32, 0.00f32, 0.00f32, 0.52f32];
        //style[StyleColor::TabHovered]             = [0.14f32, 0.14f32, 0.14f32, 1.00f32];
        //style[StyleColor::TabActive]              = [0.20f32, 0.20f32, 0.20f32, 0.36f32];
        //style[StyleColor::TabUnfocused]           = [0.00f32, 0.00f32, 0.00f32, 0.52f32];
        //style[StyleColor::TabUnfocusedActive]     = [0.14f32, 0.14f32, 0.14f32, 1.00f32];
        ////sty[StyleColor::l_DockingPreview]         = ImVec4:[, 0.67f32, 0.86f32, 1.00f32);
        ////sty[StyleColor::l_DockingEmptyBg]         = ImVec4:[, 0.00f32, 0.00f32, 1.00f32);
        //style[StyleColor::PlotLines]              = [1.00f32, 0.00f32, 0.00f32, 1.00f32];
        //style[StyleColor::PlotLinesHovered]       = [1.00f32, 0.00f32, 0.00f32, 1.00f32];
        //style[StyleColor::PlotHistogram]          = [1.00f32, 0.00f32, 0.00f32, 1.00f32];
        //style[StyleColor::PlotHistogramHovered]   = [1.00f32, 0.00f32, 0.00f32, 1.00f32];
        //style[StyleColor::TableHeaderBg]          = [0.00f32, 0.00f32, 0.00f32, 0.52f32];
        //style[StyleColor::TableBorderStrong]      = [0.00f32, 0.00f32, 0.00f32, 0.52f32];
        //style[StyleColor::TableBorderLight]       = [0.28f32, 0.28f32, 0.28f32, 0.29f32];
        //style[StyleColor::TableRowBg]             = [0.00f32, 0.00f32, 0.00f32, 0.00f32];
        //style[StyleColor::TableRowBgAlt]          = [1.00f32, 1.00f32, 1.00f32, 0.06f32];
        //style[StyleColor::TextSelectedBg]         = [0.20f32, 0.22f32, 0.23f32, 1.00f32];
        //style[StyleColor::DragDropTarget]         = [0.33f32, 0.67f32, 0.86f32, 1.00f32];
        //style[StyleColor::NavHighlight]           = [1.00f32, 0.00f32, 0.00f32, 1.00f32];
        //style[StyleColor::NavWindowingHighlight]  = [1.00f32, 0.00f32, 0.00f32, 0.70f32];
        //style[StyleColor::NavWindowingDimBg]      = [1.00f32, 0.00f32, 0.00f32, 0.20f32];
        //style[StyleColor::ModalWindowDimBg]       = [1.00f32, 0.00f32, 0.00f32, 0.35f32];
//
        //style.window_padding                          = [8.00f32, 8.00f32];
        //style.frame_padding                           = [5.00f32, 2.00f32];
        //style.cell_padding                            = [6.00f32, 6.00f32];
        //style.item_spacing                            = [6.00f32, 6.00f32];
        //style.item_inner_spacing                      = [6.00f32, 6.00f32];
        //style.touch_extra_padding                     = [0.00f32, 0.00f32];
        //style.indent_spacing                          = 25f32;
        //style.scrollbar_size                          = 15f32;
        //style.grab_min_size                           = 10f32;
        //style.window_border_size                      = 1f32;
        //style.child_border_size                       = 1f32;
        //style.popup_border_size                       = 1f32;
        //style.frame_border_size                       = 1f32;
        //style.tab_border_size                         = 1f32;
        //style.window_rounding                         = 7f32;
        //style.child_rounding                          = 4f32;
        //style.frame_rounding                          = 3f32;
        //style.popup_rounding                          = 4f32;
        //style.scrollbar_rounding                      = 9f32;
        //style.grab_rounding                           = 3f32;
        //style.log_slider_deadzone                     = 4f32;
        //style.tab_rounding                            = 4f32;
    }


    pub fn render(&mut self, ui: &mut Ui)
    {
        ui.window(WINDOW_TITLE_STR)
            //.flags(WindowFlags::NO_COLLAPSE | WindowFlags::NO_SCROLLBAR)
            .position([50.0f32, 50.0f32], Condition::Appearing)
            .size([500.0, 800.0], Condition::Appearing)
            .build(||
        {
            for w in &mut self.widgets
            {
                w.render(&mut self.game, ui);
            }
        });
        //ui.show_demo_window(&mut true);
    }
}




impl Default for App
{
    fn default() -> Self
    {
        App
        {
            game: Box::new(MockGame::new()),
            hmodule: HINSTANCE(std::ptr::null_mut()),
            server: Server::default(),
            widgets: Vec::new(),
        }
    }
}

static mut APP: Option<Arc<Mutex<App>>> = None;

