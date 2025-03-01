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
use rand::random;
use soulmemory_rs::App;
use soulmemory_rs::games::*;

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