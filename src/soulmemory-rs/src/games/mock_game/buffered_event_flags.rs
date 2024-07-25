use std::sync::{Arc, Mutex};
use crate::games::mock_game::BufferedEventFlags;
use crate::games::mock_game::MockGame;
use crate::games::traits::buffered_event_flags::EventFlag;

impl BufferedEventFlags for MockGame
{
    fn access_flag_storage(&self) -> &Arc<Mutex<Vec<EventFlag>>>
    {
        return &self.event_flags;
    }

    fn get_event_flag_state(&self, _event_flag: u32) -> bool
    {
        return true;
    }
}