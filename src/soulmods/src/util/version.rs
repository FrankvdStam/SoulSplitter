use std::ffi::c_void;
use std::fmt::{Display, Formatter};
use std::mem::MaybeUninit;
use std::path::PathBuf;
use std::cmp::Ordering;
use windows::core::PCWSTR;
use windows::Win32::Storage::FileSystem::{GET_FILE_VERSION_INFO_FLAGS, GetFileVersionInfoExW, GetFileVersionInfoSizeW, VerQueryValueW, VS_FIXEDFILEINFO};


pub struct Version
{
    pub major: u16,
    pub minor: u16,
    pub build: u16,
    pub revision: u16,
}

impl Default for Version
{
    fn default() -> Self
    {
        Version { major: 0, minor: 0, build: 0, revision: 0 }
    }
}

impl Display for Version
{
    fn fmt(&self, f: &mut Formatter<'_>) -> std::fmt::Result {
        write!(f, "{}.{}.{}.{}", self.major, self.minor, self.build, self.revision)
    }
}

impl Version
{
    pub fn from_file_version_info(path: PathBuf) -> Self
    {
        unsafe
        {
            let mut os_str = path.into_os_string();
            os_str.push("\0");

            let str = os_str.to_string_lossy();

            let mut thing: Vec<u16> = str.encode_utf16().collect();
            let pcwstr = PCWSTR::from_raw(thing.as_mut_ptr());

            let mut dwlen: u32 = 0;
            let file_version_info_size = GetFileVersionInfoSizeW(pcwstr, Some(&mut dwlen));
            let mut buffer: Vec<u8> = vec![0; file_version_info_size as usize];

            let get_file_version_info_result = GetFileVersionInfoExW(
                GET_FILE_VERSION_INFO_FLAGS(0x02),
                pcwstr,
                0,
                file_version_info_size,
                buffer.as_mut_ptr() as *mut c_void
            );

            if get_file_version_info_result.is_err()
            {
                return Version::default();
            }

            let mut pu_len = 0;
            let mut info_ptr = MaybeUninit::<*const VS_FIXEDFILEINFO>::uninit();

            let ver_query_value_w_result = VerQueryValueW(
                buffer.as_mut_ptr() as *const c_void,
                windows::core::w!("\\"),
                info_ptr.as_mut_ptr().cast(),
                &mut pu_len
            );

            if ver_query_value_w_result.0 == 0
            {
                return Version::default();
            }

            let fixed_file_info = *(info_ptr.assume_init());

            Version{
                major: (fixed_file_info.dwFileVersionMS >> 16) as u16,
                minor: fixed_file_info.dwFileVersionMS as u16,
                build: (fixed_file_info.dwFileVersionLS >> 16) as u16,
                revision: fixed_file_info.dwFileVersionLS as u16
            }
        }
    }
}

impl PartialEq for Version
{
    fn eq(&self, other: &Self) -> bool
    {
        if self.major == other.major && self.minor == other.minor && self.build == other.build && self.revision == other.revision
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

impl PartialOrd for Version
{
    fn partial_cmp(&self, other: &Self) -> Option<Ordering>
    {
        if self.major > other.major
        {
            return Some(Ordering::Greater);
        }
        else if self.major < other.major
        {
            return Some(Ordering::Less);
        }

        if self.minor > other.minor
        {
            return Some(Ordering::Greater);
        }
        else if self.minor < other.minor
        {
            return Some(Ordering::Less);
        }

        if self.build > other.build
        {
            return Some(Ordering::Greater);
        }
        else if self.build < other.build
        {
            return Some(Ordering::Less);
        }

        if self.revision > other.revision
        {
            return Some(Ordering::Greater);
        }
        else if self.revision < other.revision
        {
            return Some(Ordering::Less);
        }

        return Some(Ordering::Equal);
    }
}