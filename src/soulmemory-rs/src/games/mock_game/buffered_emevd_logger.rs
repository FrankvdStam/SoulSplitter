use std::sync::{Arc, Mutex};
use crate::darkscript3::sekiro_emedf::Emedf;
use crate::games::MockGame;
use crate::games::traits::buffered_emevd_logger::{BufferedEmevdCall, BufferedEmevdLogger};

impl BufferedEmevdLogger for MockGame
{
    fn get_emevd_buffer(&self) -> &Arc<Mutex<Vec<BufferedEmevdCall>>>{
        &self.emevd_buffer
    }

    fn get_game_emevd_definitions(&self) -> &Emedf
    {
        return &self.emedf;
    }
}