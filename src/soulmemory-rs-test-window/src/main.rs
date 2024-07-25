use std::ops::Deref;
use imgui::{Condition, TreeNodeFlags, Ui};
use windows::Win32::Foundation::HINSTANCE;
use rand::random;
use soulmemory_rs::App;
use soulmemory_rs::games::*;

mod support;

fn main() {
    App::init(&String::from("mockgame.exe"), HINSTANCE(std::ptr::null_mut()));

    let system = support::init("test window");
    system.main_loop(move |run, ui|
    {
        let instance = App::get_instance();
        let mut app = instance.lock().unwrap();

        app.refresh().unwrap();
        app.render(ui);

        draw_controls(ui, &mut app);
        ui.show_demo_window(run);
    });
}

fn draw_controls(ui: &mut Ui, app: &mut App)
{
    ui.window("Controls")
        .size([500.0,800.0], Condition::Appearing)
        .position([500.0f32, 50.0f32], Condition::Appearing)
        .build(|| {
        if ui.collapsing_header("position", TreeNodeFlags::empty())
        {
            ui.text("x:");
            ui.text("y:");
            ui.text("z:");
        }

        if ui.collapsing_header("event flags", TreeNodeFlags::DEFAULT_OPEN)
        {
            if let Some(mock_game) = GameExt::get_game_ref::<MockGame>(app.game.deref())
            {
                if ui.button("raise random event flag")
                {
                    mock_game.raise_event_flag(random::<u32>(), random::<u32>() % 2 == 0);
                }
            }
        }
    });
}