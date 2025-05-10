use std::ffi::c_void;
use log::info;
use windows::Win32::System::Memory::{MEM_COMMIT, MEM_FREE, MEM_RESERVE, MEMORY_BASIC_INFORMATION, PAGE_EXECUTE_READWRITE, VirtualAlloc, VirtualQuery};

pub fn get_memory_regions() -> Vec<MEMORY_BASIC_INFORMATION>
{
    let mut result = Vec::new();
    let mut mbi = MEMORY_BASIC_INFORMATION::default();

    let mut address = 0usize;
    while unsafe { VirtualQuery(Some(address as *const c_void), &mut mbi, size_of::<MEMORY_BASIC_INFORMATION>()) } != 0
    {
        info!("region: {} - {}", mbi.BaseAddress as usize, mbi.RegionSize);
        result.push(mbi);
        address = address + mbi.RegionSize;
    }
    return result;
}

pub fn allocate_near_target(target: usize, range: usize, size: usize)
{
    let min_address = target - range;
    let max_address = target + range;

    let regions = get_memory_regions();

    let t = (regions[0].BaseAddress as usize) < max_address;

    for region in regions.iter().find(|i|
            i.State == MEM_FREE &&
            (i.BaseAddress as usize) > min_address &&
            (i.BaseAddress as usize) < max_address)
    {
        let alloc_result = unsafe{ VirtualAlloc(Some(region.BaseAddress as *const c_void), size, MEM_COMMIT | MEM_RESERVE, PAGE_EXECUTE_READWRITE) };
        info!("suitable region: {} {}", region.BaseAddress as usize, alloc_result as usize);
    }
}