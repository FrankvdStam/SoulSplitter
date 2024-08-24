use windows::Win32::Foundation::HINSTANCE;
use crate::util::Version;

pub static mut GLOBAL_HMODULE: HINSTANCE = HINSTANCE(0);
pub static mut GLOBAL_VERSION: Version = Version { major: 0, minor: 0, build: 0, revision: 0 };