use std::collections::HashMap;
use std::env::args;
use std::ops::Deref;
use std::ptr;
use hudhook::tracing::event;
use ilhook::x64::Registers;
use lazy_static::lazy_static;
use log::info;
use crate::App;
use crate::darkscript3::emevd_definition::ArgDoc;
use crate::darkscript3::emevd_format_event;
use crate::games::{GameExt, Sekiro};
use crate::games::traits::buffered_emevd_logger::{BufferedEmevdCall, BufferedEmevdLogger};

#[cfg(target_arch = "x86_64")]
pub unsafe extern "win64" fn emevd_event_hook_fn(registers: *mut Registers, _:usize)
{
    let instance = App::get_instance();
    let app = instance.lock().unwrap();

    if let Some(sekiro) = GameExt::get_game_ref::<Sekiro>(app.game.deref())
    {
        let sprj_emk_event_ins_ptr = (*registers).r8;
        let event_type_ptr = ptr::read((sprj_emk_event_ins_ptr + 0xb0) as *const u64);
        let event_group = ptr::read(event_type_ptr as *const u64) as u32;
        let event_type = ptr::read((event_type_ptr + 0x4) as *const u64) as u32;
        let event_id = ptr::read((sprj_emk_event_ins_ptr + 0x28) as *const u64) as u32;
        let arg_struct_ptr = ptr::read((sprj_emk_event_ins_ptr + 0xb8) as *const u64);

        let emedf = sekiro.get_game_emevd_definitions();
        let s = emevd_format_event(emedf, event_group, event_type, event_id, arg_struct_ptr);

        let mut guard = sekiro.emevd_buffer.lock().unwrap();
        guard.push(BufferedEmevdCall::new(chrono::offset::Local::now(), event_id, event_group, event_type, s));
    }
}
