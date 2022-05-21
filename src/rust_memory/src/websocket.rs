use simple_websockets::{Event, Responder};
use std::collections::HashMap;
use std::sync::{Mutex, TryLockResult};
use std::thread;
use simple_websockets::Message::Text;

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
                println!("writing to command buffer: {}", command);
                guard.push(command);
            }
            Err(_) => {}

        }
    }
}

pub fn read_command() -> Option<String>
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
                    println!("read from command buffer: {}", temp);
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
        let event_hub = simple_websockets::launch(12345).expect("failed to listen on port 12345");
        // map between client ids and the client's `Responder`:
        let mut clients: HashMap<u64, Responder> = HashMap::new();

        loop {
            //stop the server when signalled
            unsafe
            {
                match KILL_SERVER.as_ref().unwrap().try_lock()
                {
                    Ok(mut guard) => {
                        if *guard {
                            return;
                    }},
                    _ => {}
                }
            }

            match event_hub.poll_event() {
                Event::Connect(client_id, responder) => {
                    println!("A client connected with id #{}", client_id);
                    // add their Responder to our `clients` map:
                    clients.insert(client_id, responder);
                },
                Event::Disconnect(client_id) => {
                    println!("Client #{} disconnected.", client_id);
                    // remove the disconnected client from the clients map:
                    clients.remove(&client_id);
                },
                Event::Message(client_id, message) =>
                {
                    println!("Received a message from client #{}: {:?}", client_id, message);

                    // retrieve this client's `Responder`:
                    let responder = clients.get(&client_id).unwrap();
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
    });
}