use std::ffi::CStr;
use winapi::shared::ntdef::CHAR;

#[allow(dead_code)]
unsafe fn str_from_null_terminated_utf8(s: &[u8]) -> &str {
    CStr::from_ptr(s.as_ptr() as *const _).to_str().unwrap()
}

#[allow(dead_code)]
fn str_from_null_terminated_utf8_safe(s: &[u8]) -> &str {
    if s.iter().any(|&x| x == 0) {
        unsafe { str_from_null_terminated_utf8(s) }
    } else {
        std::str::from_utf8(s).unwrap()
    }
}

#[allow(dead_code)]
unsafe fn char_array_to_string(char_array: &[CHAR]) -> String {
    let data: Vec<u8> = char_array.iter().map(|&c| c as u8).collect();
    let data = str_from_null_terminated_utf8_safe(&data);
    data.to_ascii_lowercase()
}