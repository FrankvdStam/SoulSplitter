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

use mem_rs::prelude::{BaseReadWrite, ReadWrite};
use crate::games::{ChrDbgFlag, GetSetChrDbgFlags, Sekiro};

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