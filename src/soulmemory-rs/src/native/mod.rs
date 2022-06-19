pub mod process;

#[cfg(target_os = "windows")]
mod windows_process;

#[cfg(target_os = "linux")]
mod linux_process;

use crate::native::process::Process;


#[cfg(target_os = "linux")]
mod linux_process;
pub fn create_process(process_names: Vec<String>) -> Box<dyn Process>
{
    #[cfg(target_os = "windows")] return Box::new(windows_process::WindowsProcess::new(process_names));

    #[cfg(target_os = "linux")]
    todo();
}