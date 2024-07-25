use crate::games::game::Game;

pub struct GameExt;

impl GameExt
{
    pub fn get_game_ref<T: 'static>(game: &dyn Game) -> Option<&T>
    {
        return game.as_any().downcast_ref::<T>();
    }

    pub fn get_game_mut<T: 'static>(game: &mut dyn Game) -> Option<&mut T>
    {
        return game.as_any_mut().downcast_mut::<T>();
    }
}