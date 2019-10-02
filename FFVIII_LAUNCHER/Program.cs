using System;
using System.Diagnostics;
using System.IO;

namespace FFVIII_LAUNCHER
{
    internal class Program
    {
        #region Methods

        private static void launch_FF8Launcher()
        {
            string str = "FFVIII.exe"; // per themadpatter launcher worked great for the other FF titles too that had the absurd
            //6MB launcher for III, IV, IVA.
            // so you can change this string and make another game run.
            ProcessStartInfo startInfo = new ProcessStartInfo(str)
            {
                UseShellExecute = true,
                ErrorDialog = true,
                //Arguments = "jp" //uncomment to launch japanese
            };
            if (!File.Exists(str))
                throw new FileNotFoundException(new FileNotFoundException().Message + " :  " + str);
            Process process;
            Console.WriteLine($"Starting {str}...");
            process = Process.Start(startInfo);
        }

        private static void Main(string[] args) => launch_FF8Launcher();

        #endregion Methods
    }
}
