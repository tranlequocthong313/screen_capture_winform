using Microsoft.Win32;
using System.Runtime.CompilerServices;

namespace ScreenCapture
{
    internal static class Program
    {
        private static string appGuid = "c0a76b5a-12ab-45c5-b9d9-d693faa6e7b9";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Check if there is one running instance then stop openning  
            using (Mutex mutex = new Mutex(false, "Global\\" + appGuid))
            {
                if (!mutex.WaitOne(0, false))
                {
                    return;
                }

                SetOpenOnStartup();

                ApplicationConfiguration.Initialize();
                Application.Run(new Main());
            }
        }

        private static void SetOpenOnStartup()
        {
            var registry = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (registry.GetValue("ScreenCapture") == null)
            {
                registry.SetValue("ScreenCapture", Application.ExecutablePath.ToString());
            }
        }
    }
}