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

use imgui::{InputTextFlags, TreeNodeFlags, Ui};
use crate::darkscript3::sekiro_emedf::Emedf;
use crate::games::*;
use crate::games::traits::buffered_emevd_logger::BufferedEmevdCall;
use crate::widgets::widget::Widget;

pub struct EmevdLoggerWidget
{
    pub log: String,
    pub group_filer: Vec<bool>,
    pub auto_scroll: bool,
    pub init: bool,
}

impl EmevdLoggerWidget
{
    fn format_event(&self, event: &BufferedEmevdCall, emedf: &Emedf) -> String
    {
        let item = emedf.main_classes.iter().find(|p| p.index as u32 == event.group);
        if let Some(class_doc) = item
        {
            let item = class_doc.instrs.iter().find(|p| p.index as u32 == event.type_);
            if let Some(inst_doc) = item
            {
                return format!("{} - group: {} - type: {}", event.time.format("%H:%M:%S"), class_doc.name, inst_doc.name);
            }
            else
            {
                return format!("{} - known group {} but unknown type: {}", event.time.format("%H:%M:%S"), class_doc.name, event.type_);
            }
        }
        else
        {
            return format!("{} - unknown group and type: {} {}", event.time.format("%H:%M:%S"), event.group, event.type_);
        }
    }

    pub fn handle_buffered_events(&mut self, buffer: &Vec<BufferedEmevdCall>, emedf: &Emedf)
    {
        //process
        for event in buffer
        {
            let mut show = true;
            if let Some(group) = emedf.main_classes.iter().position(|p| p.index as u32 == event.group)
            {
                show = self.group_filer[group];
            }

            if show
            {
                let str = self.format_event(event, emedf);
                self.log.push_str(str.as_str());
                self.log.push('\n');
            }
        }
    }

    pub fn new() -> Self
    {
        EmevdLoggerWidget
        {
            log: String::new(),
            group_filer: Vec::new(),
            auto_scroll: true,
            init: false,
        }
    }

    pub fn init(&mut self, emedf: &Emedf)
    {
        if self.init
        {
            return;
        }

        //init group filters
        self.group_filer = vec![true; emedf.main_classes.len()];


        self.init = true;
    }
}

impl Widget for EmevdLoggerWidget
{
    fn render(&mut self, game: &mut Box<dyn Game>, ui: &Ui)
    {
        if let Some(buffered_emevd_logger) = game.buffered_emevd_logger()
        {

            if ui.collapsing_header("emevd log", TreeNodeFlags::FRAMED)
            {
                //get events
                let buffer = buffered_emevd_logger.get_buffered_emevd_calls();
                let emedf = buffered_emevd_logger.get_game_emevd_definitions();

                self.init(emedf);


                //render filters
                if ui.collapsing_header("filters", TreeNodeFlags::FRAMED)
                {
                    for i in 0..emedf.main_classes.len()
                    {
                        ui.checkbox(format!("{} - {}", emedf.main_classes[i].index, emedf.main_classes[i].name), &mut self.group_filer[i]);
                    }
                }

                ui.checkbox("auto-scroll", &mut self.auto_scroll);

                self.handle_buffered_events(&buffer, emedf);

                ui.child_window("emevd_log_scrollable")
                    .border(true)
                    .size(ui.content_region_avail())
                    .build(||
                {
                    ui.input_text_multiline("", &mut self.log, [400f32, 400f32])
                        .flags(InputTextFlags::READ_ONLY | InputTextFlags::NO_HORIZONTAL_SCROLL)
                        .build();


                    if self.auto_scroll
                    {
                        ui.set_scroll_y(ui.scroll_max_y());
                    }
                });


                if self.auto_scroll
                {
                    ui.set_scroll_y(ui.scroll_max_y());
                }






                //let id = ui.new_id_str("log");
                //ui.child_window("log").build(||
                //{
                //    if self.auto_scroll
                //    {
                //        ui.set_scroll_y(ui.scroll_max_y());
                //    }
                //});
            }


            //if ui.collapsing_header("event flags", TreeNodeFlags::FRAMED)
            //{
            //    ui.text("Log mode:");
            //    ui.radio_button("All", &mut self.selected_log_mode_index, 0);
            //    if ui.is_item_hovered()
            //    {
            //        ui.tooltip_text("Shows all flags. Might get overwhelming in certain area's or when performing certain actions.");
            //    }
//
            //    ui.radio_button("Unique", &mut self.selected_log_mode_index, 1);
            //    if ui.is_item_hovered()
            //    {
            //        ui.tooltip_text("Shows every flag only once. Repeated flags are ignored. Use the clear button to reset which flags have been 'seen' before.");
            //    }
//
            //    ui.same_line();
            //    if ui.button("clear unique list")
            //    {
            //        self.unique_event_flags.clear();
            //    }
//
            //    ui.radio_button("Use blacklist", &mut self.selected_log_mode_index, 2);
            //    if ui.is_item_hovered()
            //    {
            //        ui.tooltip_text("Use the blacklist tab to setup blacklisted flags, those flags will be ignored.");
            //    }
//
            //    if let Some(tab_bar) = ui.tab_bar("event_flags")
            //    {
            //        self.tab_event_flag_log(ui, game);
            //        self.tab_blacklist(ui, game);
            //        self.tab_watch_event_flags(ui, game);
            //        tab_bar.end();
            //    };
            //}
        }
    }
}
