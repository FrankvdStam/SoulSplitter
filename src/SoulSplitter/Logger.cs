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

using SoulMemory.Memory;
using System;
using System.IO;
using System.Linq;

namespace SoulSplitter
{
    internal class Logger
    {
        private static object _logLock = new object();

        public static void Log(string message)
        {
            lock (_logLock)
            {
                try
                {
                    var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"soulsplitter\soulsplitter.log");
                    var info = new FileInfo(filePath);

                    //Create the file if it does not exist
                    if (!info.Exists)
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                        File.Create(filePath).Close();
                        info = new FileInfo(filePath);
                    }

                    //If the logfile is bigger than 10 megabytes, the first 9 megabytes and keep the last 1
                    if (info.Length > 10_485_760)
                    {
                        var lines = File.ReadAllLines(filePath);
                        File.Delete(filePath);
                        File.WriteAllLines(filePath, lines.Skip(lines.Count() / 2));
                    }

                    //Log the message
                    using (var writer = File.AppendText(filePath))
                    {
                        writer.WriteLine($"{DateTime.Now.ToString("HH:mm:ss:fff")}: {message}");
                        writer.Flush();
                    }
                }
                catch
                {
                    //ignored
                }
            }
        }

        public static void Log(string message, Exception e) => Log(message + " " + e.Format());
        public static void Log(Exception e) => Log(e.Format());
        public static void TryOrLogError(Action action)
        {
            try
            {
                action();
            }
            catch(Exception e)
            {
                Log(e);
            }
        }
    }
}
