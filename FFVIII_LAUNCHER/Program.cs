using System;
using System.Diagnostics;
using System.IO;

namespace FFVIII_LAUNCHER
{
    internal class Program
    {
        #region Methods

        private static void launch_FF8Launcher(string[] args)
        {
            //Maki: I did set the launcher to GUI not console so the another
            //  allocConsole is not fighting with parent console.
            //  not going to redirect the output because sometimes I debug
            //  directly via the EXE entry point
            string str = "FFVIII.exe"; // per themadpatter launcher worked great for the other FF titles too that had the absurd
            //6MB launcher for III, IV, IVA.
            // so you can change this string and make another game run.
            ProcessStartInfo startInfo = new(str)
            {
                UseShellExecute = true,
                ErrorDialog = true,
                Arguments = args.Length > 1 ? args[1] : string.Empty
            };
            if (!File.Exists(str))
                throw new FileNotFoundException(new FileNotFoundException().Message + " :  " + str);
            Console.WriteLine($"Starting {str}...");
            Process process = Process.Start(startInfo);
            process.WaitForExit(); //Maki: for graphic debugger 
        }

        private static void Main(string[] args) => launch_FF8Launcher(args); //Maki: why?

        #endregion Methods
    }
}
