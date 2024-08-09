use std::fmt::{Display};
use std::time::Duration;

pub trait DurationExt
{
    fn from_parts(hours: u64, minutes: u64, seconds: u64, milliseconds: u64) -> Duration;
    fn format(&self) -> String;
}

impl DurationExt for Duration
{
    fn from_parts(hours: u64, minutes: u64, seconds: u64, milliseconds: u64) -> Duration
    {
        Duration::from_millis(
            //hours
        ((hours * 60) * 60 * 1000) +
            //minutes
            (minutes * 60 * 1000) +
            //seconds
            (seconds * 1000) +
            //millis
            milliseconds
        )
    }

    fn format(&self) -> String
    {
        let total_millis = self.as_millis();
        let hours = total_millis / 1000 / 60 / 60;
        let minutes = (total_millis / 1000 / 60) % 60;
        let seconds = if (total_millis / 1000 / 60) == 0 { 0 } else { (total_millis / 1000) % (total_millis / 1000 / 60) };
        let millis = total_millis - (hours * 60 * 60 * 1000 +
                                            minutes * 60 * 1000 +
                                            seconds * 1000);

        return format!(
            "{:02}:{:02}:{:02}.{:03}",
           hours,
           minutes,
           seconds,
           millis
        );
    }
}


#[cfg(test)]
mod tests
{
    use std::time::Duration;
    use crate::util::DurationExt;

    #[test]
    fn from_parts_format_tests()
    {
        assert_eq!(
            format!("{:?}", Duration::from_millis(171839)),
            String::from("00:02:51.839")
        );

        assert_eq!(
            Duration::from_millis(171839).format(),
            String::from("00:02:51.839")
        );

        assert_eq!(
            Duration::from_parts(0, 0, 0, 0).format(),
            String::from("00:00:00.000")
        );

        assert_eq!(
            Duration::from_parts(5, 45, 14, 0).format(),
            String::from("05:45:14.000")
        );

        assert_eq!(
            Duration::from_parts(12, 0, 12, 547).format(),
            String::from("12:00:12.547")
        );







        //let igt = Duration::from_parts(5, 45, 45, 0);
        //let rta = Duration::from_parts(5, 51, 44, 0);
        //let igt = Duration::from_parts(0, 3, 0, 93);
        //let rta = Duration::from_parts(0, 2, 59, 02);

    }
}