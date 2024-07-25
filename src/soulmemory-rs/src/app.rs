// This file is part of the soulmemory-rs distribution (https://github.com/FrankvdStam/soulmemory-rs).
// Copyright (c) 2022 Frank van der Stam.
// https://github.com/FrankvdStam/soulmemory-rs/blob/main/LICENSE
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
use imgui::{Condition, Ui};
use crate::widgets::widget::Widget;
use crate::util::server::Server;
use crate::widgets::ai_toggle_widget::AiToggleWidget;
use crate::widgets::basic_position_widget::PlayerPositionWidget;
use crate::widgets::chr_dbg_flags_widget::ChrDbgFlagsWidget;
use crate::widgets::event_flag_widget::EventFlagWidget;
use crate::widgets::misc_widget::MiscWidget;
use crate::games::*;

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
            }
        }
    }

    pub fn refresh(&mut self) -> Result<(), String>
    {
        self.game.refresh()?;
        Ok(())
    }

    pub fn render(&mut self, ui: &mut Ui)
    {
        ui.window("soulmemory-rs")
            .position([50.0f32, 50.0f32], Condition::Appearing)
            .size([350.0, 800.0], Condition::Appearing)
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
