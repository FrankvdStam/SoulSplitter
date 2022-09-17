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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SoulMemory.Memory
{
    internal static class ProcessClinger
    {
        public static bool Refresh(ref Process process, string name, Func<Exception> initialize, Action reset, out Exception exception) => Refresh(ref process, new List<string>(){name}, initialize, reset, out exception);

        public static bool Refresh(ref Process process, List<string> names, Func<Exception> initialize, Action reset, out Exception exception)
        {
            exception = null;

            try
            {
                //Process not attached - find it in the process list
                if (process == null)
                {
                    process = Process.GetProcesses().FirstOrDefault(i => names.Contains(i.ProcessName.ToLower()) && !i.HasExited && i.MainModule != null);
                    if (process == null)
                    {
                        exception = new Exception($"{string.Join(" ", names)} not running.");
                        return false;
                    }
                    else
                    {
                        //If initialization fails, set the exception, try again next time.
                        exception = initialize();
                        return exception == null;
                    }
                }
                //Process is attached, make sure it is still running
                else
                {
                    if (process.HasExited)
                    {
                        process = null;
                        reset();
                        exception = new Exception("Process exited");
                        return false;
                    }

                    //Nothing going on, process still running
                    return true;
                }
            }
            catch (Exception e)
            {
                reset();
                exception = e;
                return false;
            }
        }
    }
}
