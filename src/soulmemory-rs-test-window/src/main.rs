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
use windows::Win32::Foundation::HINSTANCE;
use soulmemory_rs::App;
use soulmemory_rs::games::{GameExt, MockGame};
use rand::{random, Rng};
use soulmemory_rs::games::traits::buffered_emevd_logger::{BufferedEmevdCall, BufferedEmevdLogger};
use soulmemory_rs::games::traits::buffered_event_flags::EventFlag;

mod support;

fn main()
{
    App::init(&String::from("mockgame.exe"), HINSTANCE(std::ptr::null_mut()));
    let instance = App::get_instance();
    let mut app = instance.lock().unwrap();

    let mut system = support::init("test window");
    app.render_initialize(&mut system.imgui);

    //Have to drop these out of scope to not lock the render loop later on
    drop(app);
    drop(instance);

    init_data();

    system.main_loop(render_fun);
}


fn render_fun(run: &mut bool, ui: &mut Ui)
{
    let instance = App::get_instance();
    let mut app = instance.lock().unwrap();

    app.refresh().unwrap();
    app.render(ui);

    draw_controls(ui, &mut app);
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
        .position([500.0f32, 50.0f32], Condition::Appearing)
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
    let emevd = mock_game.get_game_emevd_definitions();
    let mut rng = rand::rng();
    let group = rng.random_range(0..emevd.main_classes.len());
    let type_ = if emevd.main_classes[group].instrs.len() > 0
    {
        rng.random_range(0..emevd.main_classes[group].instrs.len())
    }
    else
    {
        0
    };

    return BufferedEmevdCall::new(chrono::offset::Local::now(), group as u32, type_ as u32);
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
