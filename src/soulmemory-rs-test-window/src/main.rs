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
use soulmemory_rs::glow_window;

fn main()
{
    App::init(&String::from("mockgame.exe"), HINSTANCE(std::ptr::null_mut()));
    init_data();
    glow_window::run_custom_window(Some(&mut draw_controls));
}

fn draw_controls(ui: &mut Ui, app: &mut App)
{
    let _ = app.refresh();

    ui.show_demo_window(&mut true);

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

