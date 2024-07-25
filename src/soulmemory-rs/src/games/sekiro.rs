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

#![allow(dead_code)]
#![allow(unused_imports)]

use std::ops::Deref;
use std::any::Any;
use std::mem;
use std::sync::{Arc, Mutex};
use log::info;
use mem_rs::prelude::*;
use crate::App;
use crate::games::{ChrDbgFlag, GameExt, GetSetChrDbgFlags};
use crate::games::dx_version::DxVersion;
use crate::games::game::Game;
use crate::games::traits::player_position::PlayerPosition;
use crate::games::traits::buffered_event_flags::{BufferedEventFlags, EventFlag};
use crate::util::vector3f::Vector3f;
use crate::games::ilhook::*;

type FnGetEventFlag = fn(event_flag_man: u64, event_flag: u32) -> u8;

#[derive(Eq, PartialEq, Hash, Copy, Clone)]
#[repr(usize)]
pub enum SekiroChrDbgFlag
{
    PlayerNoDead = 0,
    PlayerExterminate = 1,
    PlayerExterminateStamina = 2,
    PlayerNoGoodsConsume = 3,
    PlayerNoResourceItemConsume = 4,
    PlayerNoRevivalConsume = 5,
    PlayerHide = 9,
    PlayerSilenced = 10,
    AllNoDead = 11,
    AllNoDamage = 12,
    AllNoHit = 13,
    AllNoAttack = 14,
    AllNoMove = 15,
    AllNoUpdateAi = 16,
}


pub struct Sekiro
{
    process: Process,

    event_flags: Arc<Mutex<Vec<EventFlag>>>,
    event_flag_man: Pointer,
    position: Pointer,
    chr_dbg_flags: Pointer,
    fn_get_event_flag: FnGetEventFlag,
    set_event_flag_hook: Option<HookPoint>,

    menu_man: Pointer,
}

impl Sekiro
{
    pub fn new() -> Self
    {
        Sekiro
        {
            process: Process::new("sekiro.exe"),
            event_flags: Arc::new(Mutex::new(Vec::new())),
            event_flag_man: Pointer::default(),
            position: Pointer::default(),
            chr_dbg_flags: Pointer::default(),
            fn_get_event_flag: |_,_|{0},
            set_event_flag_hook: None,

            menu_man: Pointer::default(),
        }
    }


    pub fn request_quitout(&self)
    {
        self.menu_man.write_u32_rel(Some(0x23c), 1);
    }
}

impl PlayerPosition for Sekiro
{
    fn get_position(&self) -> Vector3f
    {
        if !self.process.is_attached()
        {
            return Vector3f::default();
        }

        let x = self.position.read_f32_rel(Some(0x80));
        let y = self.position.read_f32_rel(Some(0x84));
        let z = self.position.read_f32_rel(Some(0x88));

        return Vector3f::new(x, y, z);
    }

    fn set_position(&self, position: &Vector3f)
    {
        self.position.write_f32_rel(Some(0x80), position.x);
        self.position.write_f32_rel(Some(0x84), position.y);
        self.position.write_f32_rel(Some(0x88), position.z);
    }
}


impl GetSetChrDbgFlags for Sekiro
{
    fn get_flags(&self) -> Vec<ChrDbgFlag>
    {
        let mut buffer = [0u8; 17];
        self.chr_dbg_flags.read_memory_rel(None, &mut buffer);

        let mut result = Vec::new();
        result.push((SekiroChrDbgFlag::PlayerNoDead                as u32, String::from("Player No Dead")                 , buffer[SekiroChrDbgFlag::PlayerNoDead                   as usize] == 1));
        result.push((SekiroChrDbgFlag::PlayerExterminate           as u32, String::from("Player Exterminate")             , buffer[SekiroChrDbgFlag::PlayerExterminate              as usize] == 1));
        result.push((SekiroChrDbgFlag::PlayerExterminateStamina    as u32, String::from("Player Exterminate Stamina")     , buffer[SekiroChrDbgFlag::PlayerExterminateStamina       as usize] == 1));
        result.push((SekiroChrDbgFlag::PlayerNoGoodsConsume        as u32, String::from("Player No Goods Consume")        , buffer[SekiroChrDbgFlag::PlayerNoGoodsConsume           as usize] == 1));
        result.push((SekiroChrDbgFlag::PlayerNoResourceItemConsume as u32, String::from("Player No Resource Item Consume"), buffer[SekiroChrDbgFlag::PlayerNoResourceItemConsume    as usize] == 1));
        result.push((SekiroChrDbgFlag::PlayerNoRevivalConsume      as u32, String::from("Player No Revival Consume")      , buffer[SekiroChrDbgFlag::PlayerNoRevivalConsume         as usize] == 1));
        result.push((SekiroChrDbgFlag::PlayerHide                  as u32, String::from("Player Hide")                    , buffer[SekiroChrDbgFlag::PlayerHide                     as usize] == 1));
        result.push((SekiroChrDbgFlag::PlayerSilenced              as u32, String::from("Player Silenced")                , buffer[SekiroChrDbgFlag::PlayerSilenced                 as usize] == 1));
        result.push((SekiroChrDbgFlag::AllNoDead                   as u32, String::from("All No Dead")                    , buffer[SekiroChrDbgFlag::AllNoDead                      as usize] == 1));
        result.push((SekiroChrDbgFlag::AllNoDamage                 as u32, String::from("All No Damage")                  , buffer[SekiroChrDbgFlag::AllNoDamage                    as usize] == 1));
        result.push((SekiroChrDbgFlag::AllNoHit                    as u32, String::from("All No Hit")                     , buffer[SekiroChrDbgFlag::AllNoHit                       as usize] == 1));
        result.push((SekiroChrDbgFlag::AllNoAttack                 as u32, String::from("All No Attack")                  , buffer[SekiroChrDbgFlag::AllNoAttack                    as usize] == 1));
        result.push((SekiroChrDbgFlag::AllNoMove                   as u32, String::from("All No Move")                    , buffer[SekiroChrDbgFlag::AllNoMove                      as usize] == 1));
        result.push((SekiroChrDbgFlag::AllNoUpdateAi               as u32, String::from("All No Update Ai")               , buffer[SekiroChrDbgFlag::AllNoUpdateAi                  as usize] == 1));
        return result;
    }

    fn set_flag(&self, flag: u32, value: bool)
    {
        if self.process.is_attached()
        {
            let value = match value{ true => 1, false => 0};
            self.chr_dbg_flags.write_u8_rel(Some(flag as usize), value);
        }
    }
}


impl BufferedEventFlags for Sekiro
{
    fn access_flag_storage(&self) -> &Arc<Mutex<Vec<EventFlag>>>
    {
        return &self.event_flags;
    }

    fn get_event_flag_state(&self, event_flag: u32) -> bool {
        let result = (self.fn_get_event_flag)(self.event_flag_man.read_u64_rel(None), event_flag);
        return result == 1;
    }
}

impl Game for Sekiro
{
    fn refresh(&mut self) -> Result<(), String> {
        if !self.process.is_attached()
        {
            unsafe
            {
                self.process.refresh()?;

                self.event_flag_man = self.process.scan_rel("SprjEventFlagMan", "48 8b 0d ? ? ? ? 48 89 5c 24 50 48 89 6c 24 58 48 89 74 24 60", 3, 7, vec![0])?;
                self.position = self.process.scan_rel("WorldChrManImp", "48 8B 35 ? ? ? ? 44 0F 28 18", 3, 7, vec![0, 0x48, 0x28])?;
                self.chr_dbg_flags = self.process.scan_rel("chr dbg", "80 3d ? ? ? ? 00 0f ? ? ? ? ? 48 8b 9b d0 11 00 00", 2, 7, Vec::new())?;
                self.menu_man = self.process.scan_rel("MenuMan", "48 8b 05 ? ? ? ? 0f b6 d1 48 8b 88 08 33 00 00", 3, 7, vec![0])?;

                let set_event_flag_address = self.process.scan_abs("set_event_flag", "40 55 41 54 41 55 41 56 48 83 ec 58 80 b9 28 02 00 00 00 45 0f b6 e1 45 0f b6 e8 44 8b f2 48 8b e9", 0, Vec::new())?.get_base_address();
                let get_event_flag_address = self.process.scan_abs("get_event_flag", "40 53 48 83 ec 20 80 b9 28 02 00 00 00 8b da", 0, Vec::new())?.get_base_address();
                self.fn_get_event_flag = mem::transmute(get_event_flag_address);

                #[cfg(target_arch = "x86_64")]
                {
                    let h = Hooker::new(set_event_flag_address, HookType::JmpBack(set_event_flag_hook_fn), CallbackOption::None, 0, HookFlags::empty());
                    self.set_event_flag_hook = Some(h.hook().unwrap());
                }


                info!("event_flag_man base address: 0x{:x}", self.event_flag_man.get_base_address());
                info!("WorldChrManImp base address: 0x{:x}", self.position.get_base_address());
                info!("chr dbg flags  base address: 0x{:x}", self.chr_dbg_flags.get_base_address());
                info!("MenuMan        base address: 0x{:x}", self.menu_man.get_base_address());
                info!("set event flag address     : 0x{:x}", set_event_flag_address);
                info!("get event flag address     : 0x{:x}", get_event_flag_address);
            }
        }
        else
        {
            self.process.refresh()?;
        }
        Ok(())
    }

    fn get_dx_version(&self) -> DxVersion {
        DxVersion::Dx11
    }
    fn event_flags(&mut self) -> Option<Box<&mut dyn BufferedEventFlags>> { Some(Box::new(self)) }
    fn player_position(&mut self) -> Option<Box<&mut dyn PlayerPosition>>{ Some(Box::new(self)) }
    fn as_any(&self) -> &dyn Any
    {
        self
    }
    fn as_any_mut(&mut self) -> &mut dyn Any { self }
}

#[cfg(target_arch = "x86_64")]
unsafe extern "win64" fn set_event_flag_hook_fn(registers: *mut Registers, _:usize)
{
    let instance = App::get_instance();
    let app = instance.lock().unwrap();

    if let Some(vanilla) = GameExt::get_game_ref::<Sekiro>(app.game.deref())
    {
        let event_flag_id = (*registers).rdx as u32;
        let value = (*registers).r8 as u8;

        let mut guard = vanilla.event_flags.lock().unwrap();
        guard.push(EventFlag::new(chrono::offset::Local::now(), event_flag_id, value != 0));
    }
}