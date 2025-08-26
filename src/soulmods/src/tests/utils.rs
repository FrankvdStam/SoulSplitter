use std::fmt::{Display, Formatter};
use std::time::Duration;

pub struct FormattableDuration(pub Duration);

impl Display for FormattableDuration
{
    fn fmt(&self, f: &mut Formatter<'_>) -> std::fmt::Result
    {
        let milliseconds =  self.0.as_millis() % 1000;
        let seconds =  self.0.as_millis() / 1000 % 60;
        let minutes = (self.0.as_secs() / 60) % 60;
        let hours = (self.0.as_secs() / 60) / 60;

        write!(f, "{:0>2}:{:0>2}:{:0>2}:{:0>3}", hours, minutes, seconds, milliseconds)
    }
}