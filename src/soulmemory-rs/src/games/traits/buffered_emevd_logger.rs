use std::{fmt, mem};
use std::fmt::Display;
use std::sync::{Arc, Mutex};
use chrono::{DateTime, Local};
use crate::darkscript3::sekiro_emedf::Emedf;

pub struct BufferedEmevdCall
{
    pub time: DateTime<Local>,
    pub event_id: u32,
    pub group: u32,
    pub type_: u32,
    pub log: String,
}

impl BufferedEmevdCall
{
    pub fn new(time: DateTime<Local>, event_id: u32, group: u32, type_: u32, log: String) -> Self
    {
        BufferedEmevdCall
        {
            time,
            event_id,
            group,
            type_,
            log
        }
    }
}

impl Display for BufferedEmevdCall
{
    fn fmt(&self, f: &mut fmt::Formatter<'_>) -> fmt::Result {
        write!(f, "{} - {: >10} - {}", self.time.format("%Y-%m-%d %H:%M:%S%.3f"), self.group, self.type_)
    }
}

pub trait BufferedEmevdLogger
{
    fn get_emevd_buffer(&self) -> &Arc<Mutex<Vec<BufferedEmevdCall>>>;

    fn get_buffered_emevd_calls(&mut self) -> Vec<BufferedEmevdCall>
    {
        let mut state = self.get_emevd_buffer().lock().unwrap();
        let buffer = mem::replace(&mut *state, Vec::new());
        return buffer;
    }

    fn get_game_emevd_definitions(&self) -> &Emedf;
}