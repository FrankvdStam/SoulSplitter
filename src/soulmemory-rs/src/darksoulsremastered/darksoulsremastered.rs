use lazy_static::lazy_static;
use crate::pointer::Pointer;
use crate::scan_cache::{MODULE_BASE, scan_relative};

//48 89 35 ? ? ? ? 48 8b 5c 24 30 48 8b 74 24 38 48 83 c4 20 5f c3

//pub struct DarkSoulsRemastered
//{
//    menu_man: Pointer,
//}
//
//impl DarkSoulsRemastered
//{
//    pub fn new() -> Self
//    {
//        unsafe
//        {
//            let menu_man_address = scan_relative("48 89 35 ? ? ? ? 48 8b 5c 24 30 48 8b 74 24 38 48 83 c4 20 5f c3", 3, 7).unwrap();
//
//            DarkSoulsRemastered
//            {
//                menu_man: Pointer::new(Box::new(Process::get_current_process().unwrap()), MODULE_BASE + menu_man_address, vec![0x0], true),
//            }
//        }
//    }
//
//    pub fn is_loaded(&self) -> bool
//    {
//        return self.menu_man.read_i32(Some(0x258)) == 1;
//    }
//}