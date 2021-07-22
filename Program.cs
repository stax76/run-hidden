
using System;
using System.Diagnostics;
using System.Linq;

namespace run_hidden
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Process p = new Process())
            {
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.FileName = args[0];

                args = args.Skip(1).ToArray();

                for (int i = 0; i < args.Length; i++)
                    if (args[i].Contains(" "))
                        args[i] = "\"" + args[i] + "\"";

                p.StartInfo.Arguments = string.Join(" ", args);
                p.Start();
                p.WaitForExit();
                Environment.ExitCode = p.ExitCode;
            }
        }
    }
}
