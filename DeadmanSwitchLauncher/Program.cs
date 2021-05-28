using System;
using System.Windows.Forms;
using DeadmanSwitchLauncher.Config;

namespace DeadmanSwitchLauncher {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            DMSLConfig.getConfig();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Launcher());
        }
    }
}