use std::collections::HashMap;
use serde::{Deserialize};

#[allow(dead_code)]
#[derive(Deserialize, Debug)]
pub struct EmevdDefinition
{
    pub main_classes: Vec<ClassDoc>
}

#[allow(dead_code)]
#[derive(Deserialize, Debug)]
pub struct ClassDoc
{
    pub name: String,
    pub index: u64,
    pub instrs: Vec<InstrDoc>
}

#[allow(dead_code)]
#[derive(Deserialize, Debug)]
pub struct InstrDoc
{
    pub name: String,
    pub index: u64,
    pub args: Vec<ArgDoc>
}

#[allow(dead_code)]
#[derive(Deserialize, Debug)]
pub struct ArgDoc
{
    pub name: String,
    pub type_: u64,
    pub enum_name: Option<String>,
    //pub default: i64,
    //pub min: i64,
    //pub max: i64,
    //pub increment: u64,
    pub format_string: String,
}

#[allow(dead_code)]
#[derive(Deserialize, Debug)]
pub struct EnumDoc
{
    pub name: String,
    pub values: HashMap<String, String>,
}

#[allow(dead_code)]
#[derive(Deserialize, Debug)]
pub struct DarkScriptType
{
    pub name: String,
    pub multi_names: Vec<String>,
    pub cmds: Vec<String>,
    pub data_type: String,
    pub type_: String,
    pub types: Vec<String>,
    pub override_enum: String,
    //override_types: Vec<String, DarkScriptTypeOverride>,
    pub detail_name: String,
}

#[allow(dead_code)]
#[derive(Deserialize, Debug)]
pub struct DarkScriptDoc
{
    pub aliases: HashMap<String, String>,
    pub enum_aliases: HashMap<String, String>,
    pub replacements: HashMap<String, String>,
    pub global_enums: Vec<String>,
    pub meta_aliases: HashMap<String, Vec<String>>,
    pub meta_types: Vec<DarkScriptType>
}