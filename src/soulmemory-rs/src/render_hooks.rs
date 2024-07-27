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

//use hudhook::{windows::Win32::Foundation::HINSTANCE as HUDHOOK_HINSTANCE, ImguiRenderLoop};
use hudhook::*;
use hudhook::Hudhook;
use hudhook::hooks::dx11::ImguiDx11Hooks;
use hudhook::hooks::dx12::ImguiDx12Hooks;
use hudhook::hooks::dx9::ImguiDx9Hooks;
use imgui::Ui;
use crate::App;
use crate::games::dx_version::DxVersion;

pub struct RenderHooks;

impl RenderHooks
{
    pub fn init()
    {
        let instance = App::get_instance();
        let app = instance.lock().unwrap();

        let render_hooks  = RenderHooks::new();
        let mut builder = Hudhook::builder();

        builder = match app.game.get_dx_version()
        {
            DxVersion::Dx9  => builder.with::<ImguiDx9Hooks>(render_hooks),
            DxVersion::Dx11 => builder.with::<ImguiDx11Hooks>(render_hooks),
            DxVersion::Dx12 => builder.with::<ImguiDx12Hooks>(render_hooks),
        };

        //builder.with_hmodule(HUDHOOK_HINSTANCE(app.hmodule.0));

        if let Err(e) = builder.build().apply()
        {
            panic!("{:?}", e)
        }
    }

    pub fn new() -> Self { RenderHooks {} }
}

impl ImguiRenderLoop for RenderHooks
{
    fn render(&mut self, ui: &mut Ui)
    {
        let instance = App::get_instance();
        let mut app = instance.lock().unwrap();
        app.render(ui);
    }
}