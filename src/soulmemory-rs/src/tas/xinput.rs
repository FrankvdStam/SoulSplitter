use std::ffi::c_void;
use std::{fs, mem};
use std::fmt::Error;
use std::sync::{Mutex, TryLockResult};
use detour::static_detour;
use log::info;
use winapi::shared::minwindef::{BYTE, DWORD, HMODULE, WORD};
use winapi::shared::ntdef::{NULL, SHORT};
use winapi::shared::winerror::ERROR_SUCCESS;
use winapi::um::xinput;
use winapi::um::xinput::XINPUT_STATE;
use winapi::um::xinput::XINPUT_GAMEPAD;
use serde::{Deserialize, Serialize};

//Instead of fighting with winapi over *const i8, it is far easier to just defined these functions ourselves, and then we can just pass in a string without any memes.
#[link(name = "kernel32")]
extern "stdcall" {
    //fn LoadLibraryA(lp_proc_name: *const u8) -> HMODULE;
    fn GetProcAddress(h_module: *const c_void, lp_proc_name: *const u8) -> *const c_void;
    fn GetModuleHandleA(lp_module_name: *const u8) -> HMODULE;
}



static_detour!{ static XInputGetStateDetour: fn(DWORD, *mut XINPUT_STATE) -> DWORD; }

type XInputGetState = fn(dw_user_index: DWORD, p_state: *mut XINPUT_STATE) -> DWORD;

pub fn hook_xinput()
{
    unsafe
    {
        {
            let hmodule = GetModuleHandleA("xinput1_3.dll\0".as_ptr());
            if hmodule != NULL as HMODULE
            {
                let address = GetProcAddress(hmodule as *const c_void, "XInputGetState\0".as_ptr());
                info!("xinput 1_3 address 0x{:x}", address as u64);
                let original_func: XInputGetState = mem::transmute(address);
                XInputGetStateDetour.initialize(original_func, xinput_get_state_detour).unwrap().enable().unwrap();
                return;
            }
        }

        {
            let hmodule = GetModuleHandleA("xinput1_4.dll\0".as_ptr());
            if hmodule != NULL as HMODULE
            {
                let address = GetProcAddress(hmodule as *const c_void, "XInputGetState\0".as_ptr());
                info!("xinput 1_4 address 0x{:x}", address as u64);
                let original_func: XInputGetState = mem::transmute(address);
                XInputGetStateDetour.initialize(original_func, xinput_get_state_detour).unwrap().enable().unwrap();
                return;
            }
        }

        {
            let hmodule = GetModuleHandleA("xinput9_1_0.dll\0".as_ptr());
            if hmodule != NULL as HMODULE
            {
                let address = GetProcAddress(hmodule as *const c_void, "XInputGetState\0".as_ptr());
                info!("xinput 9_1_0 address 0x{:x}", address as u64);
                let original_func: XInputGetState = mem::transmute(address);
                XInputGetStateDetour.initialize(original_func, xinput_get_state_detour).unwrap().enable().unwrap();
                return;
            }
        }
    }
}

fn set_xinput_state_zero(p_state: *mut XINPUT_STATE)
{
    unsafe
    {
        (*p_state).dwPacketNumber = 0;
        (*p_state).Gamepad.wButtons = 0;
        (*p_state).Gamepad.bLeftTrigger = 0;
        (*p_state).Gamepad.bRightTrigger = 0;
        (*p_state).Gamepad.sThumbLX = 0;
        (*p_state).Gamepad.sThumbLY = 0;
        (*p_state).Gamepad.sThumbRX = 0;
        (*p_state).Gamepad.sThumbRY = 0;
    }
}

fn xinput_get_state_detour(dw_user_index: DWORD, p_state: *mut XINPUT_STATE) -> DWORD
{
    if dw_user_index != 0
    {
        //Forward the call to xinput, to restore controller functionality
        return XInputGetStateDetour.call(dw_user_index, p_state);
    }

    unsafe
    {
        match TAS_STATE
        {
            TasState::Stopped =>
            {
                //Forward the call to xinput, to restore controller functionality
                return  XInputGetStateDetour.call(dw_user_index, p_state);
            }

            TasState::Running =>
            {
                match INPUTS.try_lock()
                {
                    Ok(mut inputs) =>
                    {
                        if TAS_INPUT_INDEX < inputs.len()
                        {
                            //Should the TAS be giving inputs
                            let should_input = inputs[TAS_INPUT_INDEX].Index < inputs[TAS_INPUT_INDEX].Count;

                            //Is the requested waiting period active?
                            let should_waiting = inputs[TAS_INPUT_INDEX].Index >= inputs[TAS_INPUT_INDEX].Count && inputs[TAS_INPUT_INDEX].Index < inputs[TAS_INPUT_INDEX].Count + inputs[TAS_INPUT_INDEX].Wait;


                            if should_input
                            {
                                (*p_state).dwPacketNumber           = 0;
                                (*p_state).Gamepad.wButtons         = inputs[TAS_INPUT_INDEX].wButtons;
                                (*p_state).Gamepad.bLeftTrigger     = inputs[TAS_INPUT_INDEX].bLeftTrigger;
                                (*p_state).Gamepad.bRightTrigger    = inputs[TAS_INPUT_INDEX].bRightTrigger;
                                (*p_state).Gamepad.sThumbLX         = inputs[TAS_INPUT_INDEX].sThumbLX;
                                (*p_state).Gamepad.sThumbLY         = inputs[TAS_INPUT_INDEX].sThumbLY;
                                (*p_state).Gamepad.sThumbRX         = inputs[TAS_INPUT_INDEX].sThumbRX;
                                (*p_state).Gamepad.sThumbRY         = inputs[TAS_INPUT_INDEX].sThumbRY;
                            }

                            if should_waiting
                            {
                                set_xinput_state_zero(p_state);
                            }

                            inputs[TAS_INPUT_INDEX].Index += 1;
                            if inputs[TAS_INPUT_INDEX].Index >= inputs[TAS_INPUT_INDEX].Count + inputs[TAS_INPUT_INDEX].Wait
                            {
                                inputs[TAS_INPUT_INDEX].Index = 0; //reset index
                                TAS_INPUT_INDEX += 1;
                            }
                            return ERROR_SUCCESS;
                        }
                        else
                        {
                            tas_stop();
                            //Don't return here, because the object has not been zero-ed.
                            //return ERROR_SUCCESS;
                        }
                    }
                    Err(_) =>
                    {
                        info!("Failed to get inputs lock");
                    },
                }

                //0 initialize, in case the caller does not.
                set_xinput_state_zero(p_state);
                return ERROR_SUCCESS;
            }
        }
    }
}


//Managing inputs from the websocket =================================================================================================================================================

static mut TAS_STATE: TasState = TasState::Stopped;
static mut TAS_INPUT_INDEX: usize = 0;

lazy_static::lazy_static! {
    static ref INPUTS: Mutex<Vec<XInputGamepad >> = Mutex::new(Vec::new());
}

pub fn tas_read_inputs_from_file(filepath: &str) -> Result<(), String>
{
    match INPUTS.try_lock()
    {
        Ok(mut inputs) =>
        {
            inputs.clear();
            match fs::read_to_string(filepath)
            {
                Ok(json) =>
                {
                    match serde_json::from_str::<Vec<XInputGamepad>>(json.as_str())
                    {
                        Ok(inputs_from_file) =>
                        {
                            for r in inputs_from_file
                            {
                                inputs.push(r);
                            }
                            info!("Read {} inputs from file", inputs.len());
                            Ok(())
                        },
                        Err(e) => Err(format!("Failed to parse json {:?} - {}", e, json))
                    }
                },
                Err(e) => Err(format!("Failed to read file {}", e))
            }
        }
        Err(_) => Err(String::from("Failed to obtain lock"))
    }
}

pub fn tas_start()
{
    unsafe
    {
        if TAS_STATE != TasState::Running
        {
            info!("Starting TAS");
            TAS_STATE = TasState::Running;
            TAS_INPUT_INDEX = 0;
        }
    }
}

pub fn tas_stop()
{
    unsafe
    {
        TAS_STATE = TasState::Stopped;
        TAS_INPUT_INDEX = 0;

        match INPUTS.try_lock()
        {
            Ok(mut inputs) =>
            {
                for i in 0..inputs.len()
                {
                    inputs[i].Index = 0;
                }
            }
            _ => {}
        }
        info!("Stopped TAS");
    }
}

enum TasState
{
    Running,
    Stopped,
}

#[allow(non_snake_case)]
#[derive(Serialize, Deserialize)]
struct XInputGamepad
{
    wButtons: WORD,
    bLeftTrigger: BYTE,
    bRightTrigger: BYTE,
    sThumbLX: SHORT,
    sThumbLY: SHORT,
    sThumbRX: SHORT,
    sThumbRY: SHORT,
    Count: u32,
    Wait: u32,
    Index: u32,
}

#[cfg(test)]
mod tests {
    use crate::xinput::XInputGamepad;

    #[test]
    fn deserialize()
    {
        let json = r#"
           [
              {
                "wButtons": 4096,
                "bLeftTrigger": 0,
                "bRightTrigger": 0,
                "sThumbLX": 1884,
                "sThumbLY": -671,
                "sThumbRX": 841,
                "sThumbRY": 526,
                "Count": 1,
                "Index": 0
              },
              {
                "wButtons": 0,
                "bLeftTrigger": 0,
                "bRightTrigger": 0,
                "sThumbLX": 1821,
                "sThumbLY": -570,
                "sThumbRX": 841,
                "sThumbRY": 469,
                "Count": 60,
                "Index": 0
              },
              {
                "wButtons": 2,
                "bLeftTrigger": 0,
                "bRightTrigger": 0,
                "sThumbLX": 1821,
                "sThumbLY": -570,
                "sThumbRX": 841,
                "sThumbRY": 469,
                "Count": 1,
                "Index": 0
              }
            ]"#;

        let mut result = Vec::new();
        match serde_json::from_str::<Vec<XInputGamepad>>(json)
        {
            Ok(list) =>
            {
                for r in list
                {
                    result.push(r);
                }
            },
            Err(e) => println!("Failed to parse json {:?}", e)
        }

        assert_eq!(result.len(), 3);
    }
}