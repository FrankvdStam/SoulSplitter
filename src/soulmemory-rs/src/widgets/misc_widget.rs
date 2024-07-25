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