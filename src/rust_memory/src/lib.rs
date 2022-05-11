#![feature(naked_functions)]
#![feature(const_mut_refs)]
#![feature(once_cell)]

mod native;
mod memory;

pub mod detours;
pub mod elden_ring;

pub use crate::memory::*;
pub use crate::native::*;
pub use crate::elden_ring::*;

extern "C"
{
     pub fn update_igt_detour(fd4ptr: usize, frame_delta: f32);
}

#[used] #[no_mangle]
static USED_UPDATE_IGT_DETOUR: unsafe extern "C" fn(usize, f32) = update_igt_detour;