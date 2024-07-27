// This file is part of the SoulSplitter distribution (https://github.com/FrankvdStam/SoulSplitter).
// Copyright (c) 2022 Frank van der Stam.
// https://github.com/FrankvdStam/SoulSplitter/blob/main/LICENSE
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, version 3.
//
// This program is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
// General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program. If not, see <http://www.gnu.org/licenses/>.

use std::io::Read;
use std::sync::{Arc, Mutex};
use std::net::TcpListener;
use std::sync::atomic::{AtomicBool, Ordering};
use std::thread;
use std::thread::JoinHandle;
use log::info;
use serde::{Deserialize, Serialize};

#[allow(dead_code)]
pub struct Server
{
    messages: Arc<Mutex<Vec<Message>>>,
    shutdown: Arc<AtomicBool>,
    handle: Option<JoinHandle<()>>
}

impl Default for Server
{
    fn default() -> Server
    {
        Server
        {
            messages: Arc::new(Mutex::new(Vec::new())),
            shutdown: Arc::new(AtomicBool::new(false)),
            handle: None,
        }
    }
}

impl Drop for Server
{
    fn drop(&mut self)
    {
        if !self.shutdown.load(Ordering::Relaxed)
        {
            self.shutdown();
        }
    }
}

#[allow(dead_code)]
impl Server
{
    pub fn get_message(&mut self) -> Option<Message>
    {
        let mut guard = self.messages.lock().unwrap();
        return guard.pop();
    }

    pub fn shutdown(&mut self)
    {
        self.shutdown.store(true, Ordering::Relaxed);
        let handle = self.handle.take().expect("attempting to take an empty handle in server");
        handle.join().unwrap();
    }

    pub fn new(addr: String) -> Self
    {
        let shutdown = Arc::new(AtomicBool::new(false));
        let messages = Arc::new(Mutex::new(Vec::new()));

        let thread_shutdown = Arc::clone(&shutdown);
        let thread_messages = Arc::clone(&messages);

        let handle = thread::spawn(move ||
        {
            let listener = TcpListener::bind(addr).unwrap();
            for stream in listener.incoming()
            {
                if thread_shutdown.load(Ordering::Relaxed)
                {
                    return;
                }

                match stream
                {
                    Ok(mut s) =>
                    {
                        //Receive json data
                        let mut buffer = [0; 1024];
                        s.read(&mut buffer).unwrap();
                        let command = String::from_utf8(Vec::from(buffer)).unwrap().trim_matches(char::from(0)).to_string();

                        //Try to parse a received string as json
                        match serde_json::from_str::<Message>(command.as_str())
                        {
                            Ok(message) =>
                            {
                                let mut guard = thread_messages.lock().unwrap();
                                guard.push(message);
                            }
                            Err(e) => info!("Parsing incoming message failed. {} Raw massage:\n{}", e, command)
                        }
                    },
                    Err(e) => info!("connection failed {}", e)
                }
            }
        });

        Server
        {
            messages,
            shutdown,
            handle: Some(handle),
        }
    }
}




#[allow(non_snake_case)]
#[derive(Serialize, Deserialize)]
pub struct Message
{
    pub MessageType: String,
    pub TasInputsFilePath: String
}

#[cfg(test)]
mod tests
{
    use crate::util::server::Message;

    #[test]
    pub fn json_test()
    {
        let json = r#"{
      "MessageType": "TasStart",
      "TasInputsFilePath": ""
    } "#;

        let result = serde_json::from_str::<Message>(json);
        match result
        {
            Ok(message) =>
            {
                println!("{}", message.MessageType);
            }
            Err(_) => {}
        }
    }

    #[test]
    pub fn json_test2()
    {
        let json = r#"{
          "MessageType": "TasReadInputFromFile",
          "TasInputsFilePath": "C:\\temp\\tas_inputs.json"
        }"#;

        let result = serde_json::from_str::<Message>(json);
        match result
        {
            Ok(message) =>
                {
                    println!("{}", message.MessageType);
                }
            Err(_) => {}
        }
    }
}