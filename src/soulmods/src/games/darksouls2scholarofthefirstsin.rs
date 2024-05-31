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

use std::collections::VecDeque;
use std::sync::{Arc, Mutex};
use ilhook::x64::{CallbackOption, Hooker, HookFlags, HookPoint, Registers};
use ilhook::x64::HookType;
use mem_rs::prelude::*;
use log::info;
static mut SCHOLAR: Option<Process> = None;
static mut SEND_MORPHEME_HOOK: Option<HookPoint> = None;
static mut MORPHEME_QUEUE: Option<Arc<Mutex<VecDeque<MorphemeMessage>>>> = None;

#[repr(C)]
#[derive(Clone)]
pub struct MorphemeMessage
{
    message_id: u32,
    event_action_category: u32,
}

#[repr(C)]
pub struct MorphemeMessageBuffer
{
    length: usize,
    buffer: [MorphemeMessage; 10],
}

#[no_mangle]
pub extern "C" fn GetQueuedDarkSouls2MorphemeMessages2(morpheme_message_buffer: &mut MorphemeMessageBuffer)
{
    unsafe
    {
        let mut queue = MORPHEME_QUEUE.as_mut().unwrap().lock().unwrap();
        morpheme_message_buffer.length = if queue.len() > 10 { 10 } else { queue.len() };
        for i in 0..morpheme_message_buffer.buffer.len()
        {
            if let Some(message) = queue.pop_front()
            {
                morpheme_message_buffer.buffer[i] = message;
            }
            else
            {
                return;
            }
        }
    }
}


#[no_mangle]
pub extern "C" fn GetQueuedDarkSouls2MorphemeMessages(raw_pointer: *mut u32)
{
    unsafe
    {
        info!("GetQueuedDarkSouls2ScholarMorphemeMessages");


        let raw_ptr = std::ptr::addr_of!(raw_pointer);
        info!("buffer: {:?}", raw_ptr);

        let mut queue = MORPHEME_QUEUE.as_mut().unwrap().lock().unwrap();

        //if no length is set, send back the current length

        let base_addr = raw_pointer as *mut u32;
        if *raw_pointer == 0
        {
            *raw_pointer = queue.len() as u32;
        }
        else
        {
            //If length is set, pop length items and send them back

            info!("base addr {:?}", base_addr);
            for i in 0..*raw_pointer as usize
            {
                if let Some(message) = queue.pop_front()
                {
                    let address_offset = 4 + (i * std::mem::size_of::<MorphemeMessage>());
                    info!("address offset {:?}", address_offset);


                    let message_id_addr = raw_pointer.byte_offset(address_offset as isize);
                    let event_action_category_addr = raw_pointer.byte_offset((address_offset + 4) as isize);

                    info!("base message_id_addr {:?}", message_id_addr);
                    info!("base event_action_category_addr {:?}", event_action_category_addr);

                    *message_id_addr = message.message_id;
                    *event_action_category_addr = message.event_action_category;
                }
            }
        }
    }
}

pub fn init_scholar()
{
    unsafe
    {
        SCHOLAR = Some(Process::new("darksoulsii.exe"));
        SCHOLAR.as_mut().unwrap().refresh().unwrap();
        let mut dequeue = VecDeque::new();
        dequeue.push_back(MorphemeMessage{ message_id: 31, event_action_category: 151 });
        dequeue.push_back(MorphemeMessage{ message_id: 31, event_action_category: 2323 });
        MORPHEME_QUEUE = Some(Arc::new(Mutex::new(dequeue)));

        let send_morpheme_message_address = SCHOLAR.as_ref().unwrap().scan_abs("send_morpheme_message", "48 89 6c 24 10 48 89 74 24 18 48 89 7c 24 20 41 56 48 83 ec 20 48 8b 01 44 8b 4a 0c", 0, Vec::new()).unwrap().get_base_address();

        unsafe extern "win64" fn send_morpheme_message_hook_fn(registers: *mut Registers, _:usize)
        {
            let morpheme_message = (*registers).rdx;

            let mut buffer = [0; 4];
            SCHOLAR.as_ref().unwrap().read_memory_abs((morpheme_message + 12) as usize, &mut buffer);
            let message_id = u32::from_ne_bytes(buffer);

            if message_id == 30
            {
                let network_ptr = (*registers).rcx;
                let network = SCHOLAR.as_mut().unwrap().create_pointer(network_ptr as usize, vec![0x18, 0x6c978]);
                let event_action_category = network.read_u32_rel(Some(0x10));
                info!("network {} message_id {} eventActionCategory {}", network_ptr, message_id, event_action_category);

                let mut guard = MORPHEME_QUEUE.as_mut().unwrap().lock().unwrap();
                guard.push_back(MorphemeMessage{message_id, event_action_category});
            }
        }

        SEND_MORPHEME_HOOK = Some(Hooker::new(send_morpheme_message_address, HookType::JmpBack(send_morpheme_message_hook_fn), CallbackOption::None, 0, HookFlags::empty()).hook().unwrap());
    }
}