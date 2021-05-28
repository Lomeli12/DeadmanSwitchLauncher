using System.Windows.Forms;
using DeadmanSwitchLauncher.Config;

namespace DeadmanSwitchLauncher {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            if (DMSLConfig.isNewConfig) {
                var dbdInstall = new DBDInstallPrompt();
                dbdInstall.ShowDialog();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            DMSLConfig.saveConfig();
        }
    }
}