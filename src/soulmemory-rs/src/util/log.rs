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

use std::fs;
use log::*;
use log4rs::*;
use log4rs::append::console::ConsoleAppender;
use log4rs::append::file::FileAppender;
use log4rs::encode::pattern::PatternEncoder;
use log4rs::config::{Appender, Config, Logger, Root};

pub fn init_log(level: LevelFilter)
{
    let logfile_path = r#"C:/temp/soulmemory.log"#;
    let path = std::path::Path::new(logfile_path);

    if path.exists()
    {
        fs::remove_file(logfile_path).unwrap();
    }

    //Setup logger
    let stdout = ConsoleAppender::builder()
        .encoder(Box::new(PatternEncoder::new("{d(%Y-%m-%d %H:%M:%S%.3f)} - {m}{n}")))
        .build();

    let requests = FileAppender::builder()
        .encoder(Box::new(PatternEncoder::new("{d(%Y-%m-%d %H:%M:%S%.3f)} - {m}{n}")))
        .build(logfile_path)
        .unwrap();

    let config = Config::builder()
        .appender(Appender::builder().build("stdout", Box::new(stdout)))
        .appender(Appender::builder().build("log_file", Box::new(requests)))
        .logger(Logger::builder()
            .build("soulmemory-rs", level))
        .logger(Logger::builder()
            .appender("log_file")
            .additive(false)
            .build("soulmemory-rs::log_file", level))
        .build(Root::builder().appender("stdout").appender("log_file").build(level))
        .unwrap();

    let _handle = init_config(config).unwrap();
}
