use crate::util::vector3f::Vector3f;

pub trait PlayerPosition
{
    fn get_position(&self) -> Vector3f;
    fn set_position(&self, position: &Vector3f);
}
