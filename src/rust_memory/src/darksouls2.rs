mod unlock_bonfire;
mod set_event_flag;

use chrono::prelude::*;
use detour::static_detour;
pub use crate::darksouls2::unlock_bonfire::init_unlock_bonfire_detour;
pub use crate::darksouls2::set_event_flag::init_event_flag_detour;
use crate::scan_cache::{MODULE_BASE, scan_absolute};
