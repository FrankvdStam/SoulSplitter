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

#![allow(unused_imports)]
#![allow(unused_variables)]
#![allow(dead_code)]

use std::ops::DerefMut;
use imgui::{TreeNodeFlags, Ui};
use crate::games::*;
use crate::widgets::widget::Widget;
use crate::tas::toggle_mode::ToggleMode;

pub struct AiToggleWidget
{
    selected_toggle_mode_index: u32,
}

impl AiToggleWidget
{
    pub fn new() -> Self
    {
        AiToggleWidget { selected_toggle_mode_index: 0}
    }
}

impl Widget for AiToggleWidget
{
    fn render(&mut self, game: &mut Box<dyn Game>, ui: &Ui)
    {
        #[cfg(target_arch = "x86_64")]
        if let Some(dsr) = GameExt::get_game_mut::<DarkSoulsRemastered>(game.deref_mut())
        {
            if ui.collapsing_header("AI timer", TreeNodeFlags::FRAMED)
            {
                ui.text("ai timer value: ");
                ui.same_line();
                ui.text(format!("{}", dsr.get_ai_timer_value()));

                let _a = ui.push_item_width(100.0f32);
                ui.input_float("auto toggle timing", &mut dsr.ai_timer_toggle_threshold).build();

                ui.text("Auto toggle mode:");
                ui.radio_button("None", &mut self.selected_toggle_mode_index, 0);
                ui.radio_button("Right hand", &mut self.selected_toggle_mode_index, 1);
                ui.radio_button("Left hand", &mut self.selected_toggle_mode_index, 2);

                dsr.ai_timer_toggle_mode = match self.selected_toggle_mode_index
                {
                    0 => ToggleMode::None,
                    1 => ToggleMode::Right,
                    2 => ToggleMode::Left,
                    _ => panic!("unsupported toggle mode: {}", self.selected_toggle_mode_index),
                };
            }
        }
    }
}