use std::{fmt, mem};
use std::fmt::Display;
use std::sync::{Arc, Mutex};
use chrono::{DateTime, Local};

#[derive(Clone, Copy)]
pub struct  EventFlag
{
    pub time: DateTime<Local>,
    pub flag: u32,
    pub state: bool,
}

impl Display for EventFlag
{
    fn fmt(&self, f: &mut fmt::Formatter<'_>) -> fmt::Result {
        write!(f, "{} - {: >10} - {}", self.time.format("%Y-%m-%d %H:%M:%S%.3f"), self.flag, self.state)
    }
}

impl EventFlag
{
    pub fn new(time: DateTime<Local>, flag: u32, state: bool,) -> Self {EventFlag { time, flag, state } }
}

pub trait BufferedEventFlags
{
    fn access_flag_storage(&self) -> &Arc<Mutex<Vec<EventFlag>>>;
    fn get_event_flag_state(&self, event_flag: u32) -> bool;

    fn get_buffered_flags(&mut self) -> Vec<EventFlag>
    {
        let mut event_flags = self.access_flag_storage().lock().unwrap();
        mem::replace(&mut event_flags, Vec::new())
    }
}