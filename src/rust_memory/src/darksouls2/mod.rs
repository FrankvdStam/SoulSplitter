mod event_key_guide;
mod set_event_flag;
mod unlock_bonfire;

pub use event_key_guide::init_event_guide_flag_detour;
pub use event_key_guide::disable_event_guide_flag_detour;

pub use set_event_flag::init_event_flag_detour;
pub use set_event_flag::disable_event_flag_detour;

pub use unlock_bonfire::init_unlock_bonfire_detour;
pub use unlock_bonfire::disable_unlock_bonfire_detour;