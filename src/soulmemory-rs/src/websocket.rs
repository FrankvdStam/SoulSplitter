use simple_websockets::{Event, Responder};
use std::collections::HashMap;
use std::sync::{Mutex, TryLockResult};
use std::thread;
use std::time::Duration;
use log::info;
use simple_websockets::Message::Text;
use serde::{Deserialize, Serialize};
use serde_json::Result;

static mut COMMAND_BUFFER: Option<Mutex<Vec<String>>> = None;

fn init_command_buffer()
{
    unsafe
    {
        if COMMAND_BUFFER.is_none()
        {
            COMMAND_BUFFER = Some(Mutex::new(Vec::new()));
        }
    }
}


pub fn write_command(command: String)
{
    unsafe
    {
        match COMMAND_BUFFER.as_ref().unwrap().try_lock()
        {
            Ok(mut guard) =>
            {
                //println!("writing to command buffer: {}", command);
                guard.push(command);
            }
            Err(_) => {}

        }
    }
}

pub fn read_command_str() -> Option<String>
{
    unsafe
    {
        match COMMAND_BUFFER.as_ref().unwrap().try_lock()
        {
            Ok(mut guard) =>
            {
                let command = guard.pop();
                if command.is_some()
                {
                    let temp = command.unwrap();
                    //println!("read from command buffer: {}", temp);
                    return Some(temp)
                }
                return None;
            }
            Err(e) => { println!("Failed to read {}", e); }
        }
    }
    return None;
}


static mut KILL_SERVER: Option<Mutex<bool>> = None;
pub fn kill_websocket_server()
{
    loop
    {
        unsafe
        {
            match KILL_SERVER.as_ref().unwrap().try_lock()
            {
                Ok(mut guard) =>
                {
                    *guard = true;
                    thread::sleep(Duration::from_secs(1));
                    return;
                },
                _ => {},
            }
        }
    }
}

pub fn init_websocket_server()
{
    init_command_buffer();
    unsafe{ KILL_SERVER = Some(Mutex::new(false)) };

    thread::spawn(||
    {
        // listen for WebSockets on port 8080:
        let event_hub = simple_websockets::launch(54345).expect("failed to listen on port 54345");
        // map between client ids and the client's `Responder`:
        let mut clients: HashMap<u64, Responder> = HashMap::new();

        loop {
            //stop the server when signalled
            unsafe
            {
                match KILL_SERVER.as_ref().unwrap().try_lock()
                {
                    Ok(guard) => {
                        if *guard {
                            //drop(event_hub);
                            //drop(clients);
                            info!("Websocket cleaned up");
                            return;
                    }},
                    _ => {}
                }
            }

            if !event_hub.is_empty()
            {
                match event_hub.poll_event() {
                    Event::Connect(client_id, responder) => {
                        //println!("A client connected with id #{}", client_id);
                        // add their Responder to our `clients` map:
                        clients.insert(client_id, responder);
                    },
                    Event::Disconnect(client_id) => {
                        //println!("Client #{} disconnected.", client_id);
                        // remove the disconnected client from the clients map:
                        clients.remove(&client_id);
                    },
                    Event::Message(_client_id, message) =>
                    {
                        //println!("Received a message from client #{}: {:?}", client_id, message);

                        // retrieve this client's `Responder`:
                        //let responder = clients.get(&client_id).unwrap();
                        // echo the message back:
                        //responder.send(message);

                        match message
                        {
                            Text(command) => write_command(command),
                            _ => {}
                        }
                    },
                }
            }
        }
    });
}


#[allow(non_snake_case)]
#[derive(Serialize, Deserialize)]
pub struct Message
{
    pub MessageType: String,
    pub DarkSouls3ReadEventFlagMessage: Option<DarkSouls3ReadEventFlagMessage>,
    pub EventFlagLogMode: i32,
    pub EventFlags: Vec<u32>,
    pub TasInputsFilePath: String
}

#[allow(non_snake_case)]
#[derive(Serialize, Deserialize)]
pub struct DarkSouls3ReadEventFlagMessage
{
    pub SprjEventFlagManager: u64,
    pub EventFlagId: u32,
    pub State: bool,
}



pub fn json_test()
{
    let json = r#"{
        "MessageType": "DarkSouls3ReadEventFlagMessage",
        "DarkSouls3ReadEventFlagMessage": {
            "SprjEventFlagManager": 140688608397088,
            "EventFlagId": 14000802,
            "State": true
        }
    }"#;

    let result = serde_json::from_str::<Message>(json);
    match result
    {
        Ok(message) =>
        {
            println!("{}", message.MessageType);
            println!("{}", message.DarkSouls3ReadEventFlagMessage.unwrap().SprjEventFlagManager);
        }
        Err(_) => {}
    }
}