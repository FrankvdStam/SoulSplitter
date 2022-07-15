pub mod process;

#[cfg(target_os = "windows")]
mod windows_process;

#[cfg(target_os = "linux")]
mod linux_process;

use crate::native::process::Process;


#[cfg(target_os = "linux")]
mod linux_process;

pub fn get_current_process() -> Result<Box<dyn Process>, ()>
{
    #[cfg(target_os = "windows")]
    match windows_process::WindowsProcess::get_current_process()
    {
        Ok(p) => Ok(Box::new(p)),
        _ => Err(()),
    }

    #[cfg(target_os = "linux")]
    todo();
}

pub fn get_process_from_name(process_name: String) -> Result<Box<dyn Process>, ()>
{
    let mut v = Vec::new();
    v.push(process_name);
    return get_process_from_names(v);
}

pub fn get_process_from_names(process_names: Vec<String>) -> Result<Box<dyn Process>, ()>
{
    #[cfg(target_os = "windows")]
    match windows_process::WindowsProcess::from_names(process_names)
    {
        Ok(p) => Ok(Box::new(p)),
        _ => Err(()),
    }

    #[cfg(target_os = "linux")]
    todo();
}

