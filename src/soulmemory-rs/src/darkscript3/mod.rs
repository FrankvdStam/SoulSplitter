// This file is part of the SoulSplitter distribution (https://github.com/FrankvdStam/SoulSplitter).
// Copyright (c) 2022 Frank van der Stam.
// https://github.com/FrankvdStam/SoulSplitter/blob/main/LICENSE
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, version 3.
//
// This program is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
// General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program. If not, see <http://www.gnu.org/licenses/>.

#![allow(dead_code)]

use std::collections::HashMap;
use lazy_static::lazy_static;
use crate::darkscript3::emevd_definition::{ArgDoc, EmevdDefinition};
use std::ptr;

pub mod emevd_definition;

lazy_static!
{
    static ref EMEVDTYPES: HashMap<u64, &'static str> = HashMap::from([
        (0, "byte"),
        (1, "ushort"),
        (2, "uint"),
        (3, "sbyte"),
        (4, "short"),
        (5, "int"),
        (6, "float"),
    ]);

    static ref EMEVDTYPESIZES: HashMap<u64, u32> = HashMap::from([
        (0, 1),
        (1, 2),
        (2, 4),
        (3, 1),
        (4, 2),
        (5, 4),
        (6, 4),
    ]);
}

pub fn load_emevd(json: &str) -> EmevdDefinition
{
    let deserialized: EmevdDefinition = serde_json::from_str(json).unwrap();
    return deserialized;
}

pub fn emevd_format_event(emevd_definition: &EmevdDefinition, event_group: u32, event_type: u32, event_id: u32, arg_struct_ptr: u64) -> String
{
    let mut s = String::new();
    s.push_str(format!("{} - {} [{}] ", event_id, event_group, event_type).as_str());

    let item = emevd_definition.main_classes.iter().find(|p| p.index as u32 == event_group);
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

    return s;
}



fn format_args(args: &Vec<ArgDoc>, arg_struct_ptr: u64, str: &mut String)
{
    let mut binary_index: u64 = 0;
    for i in 0..args.len()
    {
        let arg = &args[i];
        let type_ = EMEVDTYPES[&arg.type_];
        let size = EMEVDTYPESIZES[&arg.type_];

        //info!("arg {} arg_struct_ptr {} binary_index {} type_ {} size {}", arg.name, arg_struct_ptr, binary_index, type_, size);

        format_single_arg(type_, arg_struct_ptr, binary_index, str);

        //handle binary index increment
        //cursed 1 byte sized storage optimization
        //if current type size is 1 byte and next type size is 1 byte, only increment binary index by 1
        if size == 1 && i+1 < args.len() && EMEVDTYPESIZES[&args[i+1].type_] == 1
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

fn format_single_arg(type_: &str, arg_struct_ptr: u64, binary_index: u64, str: &mut String)
{
    unsafe
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
}
