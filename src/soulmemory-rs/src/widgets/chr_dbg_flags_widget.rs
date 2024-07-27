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

use std::ops::DerefMut;
use imgui::{TreeNodeFlags, Ui};
use crate::games::{GetSetChrDbgFlags};
use crate::games::*;
use crate::widgets::widget::Widget;

pub struct ChrDbgFlagsWidget
{
    flags: Vec<(u32, String, bool)>,
    init: bool,
}

impl ChrDbgFlagsWidget
{
    pub fn new() -> Self{ ChrDbgFlagsWidget { flags: Vec::new(), init: false} }
}

impl Widget for ChrDbgFlagsWidget
{
    fn render(&mut self, game: &mut Box<dyn Game>, ui: &Ui)
    {
        if let Some(sekiro) = GameExt::get_game_mut::<Sekiro>(game.deref_mut())
        {
            if !self.init
            {
                self.flags = sekiro.get_flags();
                self.init = true;
            }

            if ui.collapsing_header("chr dbg", TreeNodeFlags::FRAMED)
            {
                for f in self.flags.iter_mut()
                {

                    if ui.checkbox(&f.1, &mut f.2)
                    {
                        sekiro.set_flag(f.0, f.2);
                    }
                }
            }
        }
    }
}
