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

use crate::widgets::widget::Widget;
use imgui::{TreeNodeFlags, Ui};
use windows::Win32::UI::Input::KeyboardAndMouse::VK_OEM_5;
use crate::games::*;
use std::ops::DerefMut;

pub struct MiscWidget
{

}

impl MiscWidget
{
    pub fn new() -> Self { MiscWidget{}}

    fn render_misc_sekiro(&mut self, sekiro: &mut Sekiro, ui: &Ui)
    {
        if ui.button("quitout") || ui.io().keys_down[VK_OEM_5.0 as usize]
        {
            sekiro.request_quitout();
        }
    }
}

impl Widget for MiscWidget
{
    fn render(&mut self, game: &mut Box<dyn Game>, ui: &Ui)
    {
        if let Some(sekiro) = GameExt::get_game_mut::<Sekiro>(game.deref_mut())
        {
            if ui.collapsing_header("misc", TreeNodeFlags::FRAMED)
            {
                self.render_misc_sekiro(sekiro, ui);
            }
        }
    }
}