using System;
using System.IO;
using System.Windows.Forms;
using Courvix_VPN.Forms;
using Courvix_VPN.Properties;

namespace Courvix_VPN
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        private static void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            CustomMessageBox.Show("Courvix VPN",
                Resources.UnhandledException);
            File.AppendAllText(Strings.ErrorLogs, (e.ExceptionObject as Exception)?.ToString());
        }
    }
}
