using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace LongRichAutomationUI.Common.Utilities
{
    class BrowserProcesses
    {
        public static void Kill(string processName)
        {

            try
            {
                Process[] runingProcesses = Process.GetProcesses();
                foreach (var process in runingProcesses)
                {
                    if (process.ProcessName.Contains(processName))
                    {
                        process.Kill();
                    }
                }
            }
            catch (Exception)
            {

            }
        }

    }
}
