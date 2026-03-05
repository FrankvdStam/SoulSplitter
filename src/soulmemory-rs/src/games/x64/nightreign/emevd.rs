use std::ops::Deref;
use std::ptr;
use ilhook::x64::Registers;
use crate::App;
use crate::darkscript3::emevd_format_event;
use crate::games::{GameExt, Nightreign};
use crate::games::traits::buffered_emevd_logger::{BufferedEmevdCall, BufferedEmevdLogger};

pub unsafe extern "win64" fn emevd_event_hook_fn(registers: *mut Registers, _:usize)
{
    unsafe
        {
            let instance = App::get_instance();
            let app = instance.lock().unwrap();

            if let Some(nightreign) = GameExt::get_game_ref::<Nightreign>(app.game.deref())
            {
                let cs_emk_event_ins_ptr = (*registers).r8;
                let event_type_ptr = ptr::read((cs_emk_event_ins_ptr + 0xc0) as *const u64);
                let event_group = ptr::read(event_type_ptr as *const u64) as u32;
                let event_type = ptr::read((event_type_ptr + 0x4) as *const u64) as u32;
                let event_id = ptr::read((cs_emk_event_ins_ptr + 0x30) as *const u64) as u32;
                let arg_struct_ptr = ptr::read((cs_emk_event_ins_ptr + 0xc8) as *const u64);

                let emedf = nightreign.get_game_emevd_definitions();
                let s = emevd_format_event(emedf, event_group, event_type, event_id, arg_struct_ptr);

                let mut guard = nightreign.emevd_buffer.lock().unwrap();
                guard.push(BufferedEmevdCall::new(chrono::offset::Local::now(), event_id, event_group, event_type, s));
            }
        }
}