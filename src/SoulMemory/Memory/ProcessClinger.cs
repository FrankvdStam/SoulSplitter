using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
