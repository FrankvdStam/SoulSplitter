mod set_event_flag;
use crate::detours::set_event_flag::init_event_flag_detour;
use crate::detours::set_event_flag::disable_event_flag_detour;



pub fn init()
{
    init_event_flag_detour();
}

pub fn exit()
{
    disable_event_flag_detour();
}
