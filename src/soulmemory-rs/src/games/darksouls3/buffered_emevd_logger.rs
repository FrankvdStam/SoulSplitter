use std::sync::{Arc, Mutex};
use crate::darkscript3::emevd_definition::EmevdDefinition;
use crate::games::DarkSouls3;
use crate::games::traits::buffered_emevd_logger::{BufferedEmevdCall, BufferedEmevdLogger};

impl BufferedEmevdLogger for DarkSouls3
{
    fn get_emevd_buffer(&self) -> &Arc<Mutex<Vec<BufferedEmevdCall>>>{
        &self.emevd_buffer
    }

    fn get_game_emevd_definitions(&self) -> &EmevdDefinition
    {
        return &self.emevd_definition;
    }
}