mod native;
mod memory;

pub use crate::memory::pattern_scanner::to_pattern;
pub use crate::memory::pattern_scanner::scan;
pub use crate::memory::pointer;

pub use crate::native::create_process;

#[cfg(test)]
mod tests {
    #[test]
    fn it_works()
    {
    }
}
