use std::collections::HashMap;
use std::env::args;
use std::ops::Deref;
use std::ptr;
use hudhook::tracing::event;
use ilhook::x64::Registers;
use log::info;
use crate::App;
use crate::darkscript3::sekiro_emedf::ArgDoc;
use crate::games::{GameExt, Sekiro};
use crate::games::traits::buffered_emevd_logger::{BufferedEmevdCall, BufferedEmevdLogger};

#[cfg(target_arch = "x86_64")]
pub unsafe extern "win64" fn emevd_event_hook_fn(registers: *mut Registers, _:usize)
{
    let instance = App::get_instance();
    let app = instance.lock().unwrap();

    if let Some(sekiro) = GameExt::get_game_ref::<Sekiro>(app.game.deref())
    {
        let sprj_emk_event_ins_ptr = (*registers).r8;
        let event_type_ptr = ptr::read((sprj_emk_event_ins_ptr + 0xb0) as *const u64);
        let event_group = ptr::read(event_type_ptr as *const u64) as u32;
        let event_type = ptr::read((event_type_ptr + 0x4) as *const u64) as u32;
        let event_id = ptr::read((sprj_emk_event_ins_ptr + 0x28) as *const u64) as u32;
        let arg_struct_ptr = ptr::read((sprj_emk_event_ins_ptr + 0xb8) as *const u64);

        let emedf = sekiro.get_game_emevd_definitions();

        let mut s = String::new();
        s.push_str(format!("{} - {} [{}] ", event_id, event_group, event_type).as_str());

        let item = emedf.main_classes.iter().find(|p| p.index as u32 == event_group);
        if let Some(class_doc) = item
        {
            s.push_str(class_doc.name.as_str());

            let item = class_doc.instrs.iter().find(|p| p.index as u32 == event_type);
            if let Some(inst_doc) = item
            {
                s.push(' ');
                s.push_str(inst_doc.name.as_str());

                if arg_struct_ptr != 0
                {
                    format_args(&inst_doc.args, arg_struct_ptr, &mut s);
                }
            }
            else
            {
                s.push_str("unknown type");
            }
        }
        else
        {
            s.push_str("unknown group");
        }

        //info!("{}", s);

        let mut guard = sekiro.emevd_buffer.lock().unwrap();
        guard.push(BufferedEmevdCall::new(chrono::offset::Local::now(), event_id, event_group, event_type, s));
    }
}

unsafe fn format_args(args: &Vec<ArgDoc>, arg_struct_ptr: u64, str: &mut String)
{
    let emevdtypes: HashMap<u64, &str> = HashMap::from([
        (0, "byte"),
        (1, "ushort"),
        (2, "uint"),
        (3, "sbyte"),
        (4, "short"),
        (5, "int"),
        (6, "float"),
    ]);

    let emevdtypesizes: HashMap<u64, u32> = HashMap::from([
        (0, 1),
        (1, 2),
        (2, 4),
        (3, 1),
        (4, 2),
        (5, 4),
        (6, 4),
    ]);

    let mut binary_index: u64 = 0;
    for i in 0..args.len()
    {

        let arg = &args[i];
        let type_ = emevdtypes[&arg.type_];
        let size = emevdtypesizes[&arg.type_];

        //info!("arg {} arg_struct_ptr {} binary_index {} type_ {} size {}", arg.name, arg_struct_ptr, binary_index, type_, size);

        format_single_arg(type_, arg_struct_ptr, binary_index, str);

        //handle binary index increment
        //cursed 1 byte sized storage optimization
        //if current type size is 1 byte and next type size is 1 byte, only increment binary index by 1
        if size == 1 && i+1 < args.len() && emevdtypesizes[&args[i+1].type_] == 1
        {
            binary_index += 1;
        }
        else
        {
            //are we aligned? If no we are currently in the middle of a byte size optimization, should increment to the nearest 4byte aligned value
            let remainder = binary_index % 4;
            if remainder != 0
            {
                binary_index += remainder;
            }
            else //already aligned, inc by 4
            {
                binary_index += 4;
            }
        }
    }
}

unsafe fn format_single_arg(type_: &str, arg_struct_ptr: u64, binary_index: u64, str: &mut String)
{
    match type_
    {
        "byte" =>
        {
            let value = ptr::read((arg_struct_ptr + binary_index) as *const u64) as i8;
            str.push_str(format!(" {},", value).as_str());
        },
        "ushort" =>
        {
            let value = ptr::read((arg_struct_ptr + binary_index) as *const u64) as u16;
            str.push_str(format!(" {},", value).as_str());
        },
        "uint" =>
        {
            let value = ptr::read((arg_struct_ptr + binary_index) as *const u64) as u32;
            str.push_str(format!(" {},", value).as_str());
        },
        "sbyte" =>
        {
            let value = ptr::read((arg_struct_ptr + binary_index) as *const u64) as u8;
            str.push_str(format!(" {},", value).as_str());
        },
        "short" =>
        {
            let value = ptr::read((arg_struct_ptr + binary_index) as *const u64) as i16;
            str.push_str(format!(" {},", value).as_str());
        },
        "int" =>
        {
            let value = ptr::read((arg_struct_ptr + binary_index) as *const u64) as i32;
            str.push_str(format!(" {},", value).as_str());
        },
        "float" =>
        {
            let value = ptr::read((arg_struct_ptr + binary_index) as *const u64) as f32;
            str.push_str(format!(" {},", value).as_str());
        },
        _ => str.push_str(format!("unsupported arg type {}", type_).as_str())
    }
}

/*
private static readonly Dictionary<string, int> Types = new Dictionary<string, int>()
{
["byte"] = 0,
["ushort"] = 1,
["uint"] = 2,
["sbyte"] = 3,
["short"] = 4,
["int"] = 5,
["float"] = 6,
};
private static readonly Dictionary<int, string> RevTypes = Types.ToDictionary(e => e.Value, e => e.Key);
private static readonly Dictionary<string, int> Widths = new()
{
["byte"] = 1,
["ushort"] = 2,
["uint"] = 4,
["sbyte"] = 1,
["short"] = 2,
["int"] = 4,
["float"] = 4,
};
*/