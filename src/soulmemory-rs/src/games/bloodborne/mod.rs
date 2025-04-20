use std::any::Any;
use ilhook::x64::{CallbackOption, Hooker, HookFlags, HookPoint, HookType, Registers};
use log::info;
use mem_rs::prelude::*;
use crate::games::dx_version::DxVersion;
use crate::games::{Game};

pub struct Bloodborne
{
    process: Process,
    set_event_flag_hook: Option<HookPoint>,
}

impl Bloodborne
{
    pub fn new() -> Self
    {
        Bloodborne
        {
            process: Process::new("shadps4.exe"),
            set_event_flag_hook: None
        }
    }
}


impl Game for Bloodborne
{
    fn refresh(&mut self) -> Result<(), String> {
        if !self.process.is_attached()
        {
            unsafe
            {
                self.process.refresh()?;

                #[cfg(target_arch = "x86_64")]
                {
                    //TODO: setup proper AOB scan
                    let set_event_flag_address= 0x9013CBCC0;
                    let h = Hooker::new(set_event_flag_address, HookType::JmpBack(set_event_flag_hook_fn), CallbackOption::None, 0, HookFlags::empty());
                    self.set_event_flag_hook = Some(h.hook().unwrap());
                }
            }
        }

        return Ok(());
    }

    fn get_dx_version(&self) -> DxVersion {
        DxVersion::Dx12
    }

    fn as_any(&self) -> &dyn Any
    {
        self
    }
    fn as_any_mut(&mut self) -> &mut dyn Any { self }
}

#[cfg(target_arch = "x86_64")]
unsafe extern "win64" fn set_event_flag_hook_fn(registers: *mut Registers, _:usize)
{
    let event_flag_id = (*registers).rsi as u32;
    let value = (*registers).rdx as u8;

    info!("set_event_flag {} {}", event_flag_id, value);

    /*
    let instance = App::get_instance();
    let app = instance.lock().unwrap();

    if let Some(sekiro) = GameExt::get_game_ref::<Sekiro>(app.game.deref())
    {
        let event_flag_id = (*registers).rdx as u32;
        let value = (*registers).r8 as u8;

        let mut guard = sekiro.event_flags.lock().unwrap();
        guard.push(EventFlag::new(chrono::offset::Local::now(), event_flag_id, value != 0));
    }*/
}