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

use imgui::{TreeNodeFlags, Ui};
use log::info;
use crate::games::*;
use crate::widgets::widget::Widget;
use crate::util::vector3f::Vector3f;

pub struct PlayerPositionWidget
{
    position_input_vec: Vector3f,
    position_input_text: String,
    positions: Vec<(String, Vector3f)>,
}

impl PlayerPositionWidget
{
    pub fn new() -> Self
    {
        PlayerPositionWidget
        {
            position_input_vec: Vector3f::default(),
            position_input_text: String::new(),
            positions: Vec::new(),
        }
    }
}


impl Widget for PlayerPositionWidget
{
    fn render(&mut self, game: &mut Box<dyn Game>, ui: &Ui)
    {
        if let Some(position) = game.player_position()
        {
            let current_position = position.get_position();

            if ui.collapsing_header("positions", TreeNodeFlags::FRAMED)
            {
                //Display current pos
                ui.text("current position:");
                ui.text(format!("{:.2}", current_position.x));
                ui.same_line();
                ui.text(format!("{:.2}", current_position.y));
                ui.same_line();
                ui.text(format!("{:.2}", current_position.z));

                //Add positions to list
                if ui.button("import")
                {
                    self.position_input_vec.x = current_position.x;
                    self.position_input_vec.y = current_position.y;
                    self.position_input_vec.z = current_position.z;
                }
                ui.same_line();
                if ui.button("add")
                {
                    self.positions.push((self.position_input_text.clone(), self.position_input_vec.clone()));
                    self.position_input_text.clear();
                    self.position_input_vec = Vector3f::default();
                }

                ui.input_text("description: ", &mut self.position_input_text).build();
                let _a = ui.push_item_width(100f32);
                ui.input_float("x", &mut self.position_input_vec.x).build();
                ui.same_line();
                let _b =  ui.push_item_width(100f32);
                ui.input_float("y", &mut self.position_input_vec.y).build();
                ui.same_line();
                let _c = ui.push_item_width(100f32);
                ui.input_float("z", &mut self.position_input_vec.z).build();

                //Display list of positions
                ui.child_window("positions_scrollable")
                    .size([ui.content_region_avail()[0], 400.0f32])
                    .build(||
                        {
                            let mut delete_index = None;
                            for i in 0..self.positions.len()
                            {
                                ui.text(&self.positions[i].0);
                                if ui.button("restore")
                                {
                                    info!("restore {}", i);
                                    position.set_position(&self.positions[i].1);
                                }
                                ui.same_line();
                                if ui.button("delete")
                                {
                                    delete_index = Some(i);
                                }

                                ui.text(format!("{:.2}", &self.positions[i].1.x));
                                ui.same_line();
                                ui.text(format!("{:.2}", &self.positions[i].1.y));
                                ui.same_line();
                                ui.text(format!("{:.2}", &self.positions[i].1.z));
                            }

                            if let Some(index) = delete_index
                            {
                                self.positions.remove(index);
                            }
                        });
            }
        }
    }
}