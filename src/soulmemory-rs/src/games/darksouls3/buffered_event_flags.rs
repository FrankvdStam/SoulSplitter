use std::sync::{Arc, Mutex};
use crate::games::DarkSouls3;
use crate::games::traits::buffered_event_flags::{BufferedEventFlags, EventFlag};
use mem_rs::prelude::*;

impl BufferedEventFlags for DarkSouls3
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