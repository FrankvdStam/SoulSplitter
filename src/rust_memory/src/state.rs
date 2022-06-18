use std::sync::Mutex;


static mut STATE_LOCK: Option<Mutex<bool>> = None;
static mut EVENT_FLAG_LOG_MODE: i32 = 0;
static mut EVENT_FLAG_EXCLUSIONS: Vec<u32> = Vec::new();

pub fn init_state()
{
    unsafe
    {
        STATE_LOCK = Some(Mutex::new(false));
    }
}

//Set from the websocket

pub fn set_event_flag_log_mode(log_mode: i32)
{
    unsafe
    {
        match STATE_LOCK.as_ref().unwrap().try_lock()
        {
            Ok(_) =>
            {
                EVENT_FLAG_LOG_MODE = log_mode;
                println!("set log mode {}", log_mode);
            }
            Err(e) => { println!("set_event_flag_log_mode error {}", e); }
        }
    }
}

pub fn set_event_flag_exclusion(exclusions: Vec<u32>)
{
    unsafe
    {
        match STATE_LOCK.as_ref().unwrap().try_lock()
        {
            Ok(_) =>
            {
                EVENT_FLAG_EXCLUSIONS = exclusions;
                println!("total exclusions: {}", EVENT_FLAG_EXCLUSIONS.len());
            }
            Err(e) => { println!("set_event_flag_exclusion error {}", e); }
        }
    }
}


//Used internally

pub fn is_event_flag_excluded(event_flag: u32) -> bool
{
    unsafe
    {
        match STATE_LOCK.as_ref().unwrap().try_lock()
        {
            Ok(_) =>
            {
                let is_excluded = EVENT_FLAG_EXCLUSIONS.contains(&event_flag);

                //If we're logging unique values, exclude this flag next call
                if EVENT_FLAG_LOG_MODE == 0 && !is_excluded
                {
                    EVENT_FLAG_EXCLUSIONS.push(event_flag);
                }

                return is_excluded;
            }
            Err(e) => { println!("is_event_flag_excluded error {}", e); }
        }
    }
    return false;
}