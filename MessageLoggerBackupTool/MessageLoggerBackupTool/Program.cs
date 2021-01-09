using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MessageLoggerBackupTool
{
    static class Program
    {

        [DllImport("kernel32.dll", EntryPoint = "GetStdHandle", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll", EntryPoint = "AllocConsole", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int AllocConsole();

        private const int STD_OUTPUT_HANDLE = -11;
        private const int MY_CODE_PAGE = 437;

        public static bool Debug = false;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i] == "--DEBUG")
                    {
                        AllocConsole();
                        IntPtr stdHandle = GetStdHandle(STD_OUTPUT_HANDLE);
                        Microsoft.Win32.SafeHandles.SafeFileHandle safeFileHandle = new Microsoft.Win32.SafeHandles.SafeFileHandle(stdHandle, true);
                        FileStream fileStream = new FileStream(safeFileHandle, FileAccess.Write);
                        System.Text.Encoding encoding = System.Text.Encoding.GetEncoding(MY_CODE_PAGE);
                        StreamWriter standardOutput = new StreamWriter(fileStream, encoding);
                        standardOutput.AutoFlush = true;
                        Console.SetOut(standardOutput);
                        Debug = true;
                    }
                }
            }
            if (Debug)
            {
                Console.Title = "Message Logger V2 Backup Tool Debug Output";
                Console.WriteLine("MessageLoggerBackupTool V.DEV-00001");
                Console.WriteLine("UI Init");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Debug)
            {
                Console.WriteLine("UI Start");
            }
            Application.Run(new MainWindow());
            if (Debug)
            {
                Console.WriteLine("Application exit");
                Console.WriteLine("Execution finished, exiting in 5s.");
                Thread.Sleep(5000);
            }
        }
    }
}
