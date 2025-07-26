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

#![allow(dead_code)]
#![allow(unused_imports)]

mod game;
mod player_position;
mod chr_dbg_flag;
mod buffered_emevd_logger;
mod buffered_event_flags;
mod emevd;

use std::ops::Deref;
use std::any::Any;
use std::{mem, ptr};
use std::sync::{Arc, Mutex};
use log::info;
use mem_rs::prelude::*;
use crate::App;
use crate::darkscript3::emevd_definition::EmevdDefinition;
use crate::darkscript3::load_emevd;
use crate::games::{ChrDbgFlag, GameExt, GetSetChrDbgFlags};
use crate::games::dx_version::DxVersion;
use crate::games::game::Game;
use crate::games::traits::player_position::PlayerPosition;
use crate::games::traits::buffered_event_flags::{BufferedEventFlags, EventFlag, FnGetEventFlag};
use crate::games::traits::buffered_emevd_logger::*;
use crate::util::vector3f::Vector3f;
use crate::games::ilhook::*;


static EMEVD_JSON: &str = include_str!("../../../../../../darkscript3/sekiro-common.emedf.json");

pub struct Sekiro
{
    process: Process,

    event_flags: Arc<Mutex<Vec<EventFlag>>>,
    event_flag_man: Pointer,
    position: Pointer,
    chr_dbg_flags: Pointer,
    fn_get_event_flag: FnGetEventFlag,
    set_event_flag_hook: Option<HookPoint>,
    emevd_event_hook: Option<HookPoint>,

    menu_man: Pointer,
    emevd_definition: EmevdDefinition,
    emevd_buffer: Arc<Mutex<Vec<BufferedEmevdCall>>>,
}

impl Sekiro
{
    pub fn new() -> Self
    {
        Sekiro
        {
            process: Process::new_with_memory_type("sekiro.exe", MemoryType::Direct),
            event_flags: Arc::new(Mutex::new(Vec::new())),
            event_flag_man: Pointer::default(),
            position: Pointer::default(),
            chr_dbg_flags: Pointer::default(),
            fn_get_event_flag: |_,_|{0},
            set_event_flag_hook: None,
            emevd_event_hook: None,

            menu_man: Pointer::default(),
            emevd_definition: load_emevd(EMEVD_JSON),
            emevd_buffer: Arc::new(Mutex::new(Vec::new())),
        }
    }


    pub fn request_quitout(&self)
    {
        self.menu_man.write_u32_rel(Some(0x23c), 1);
    }
}
