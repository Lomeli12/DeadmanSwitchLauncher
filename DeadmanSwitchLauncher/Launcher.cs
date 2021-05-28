using System.Windows.Forms;
using DeadmanSwitchLauncher.Config;

namespace DeadmanSwitchLauncher {
    public partial class Launcher : Form {
        public Launcher() {
            InitializeComponent();

            Text = Resources.dbdLauncherTitle;
            liveBuildRadio.Text = Resources.dbdLauncherRadioLive;
            ptbBuildRadio.Text = Resources.dbdLauncherRadioPTB;
            settingsBtn.Text = Resources.dbdLauncherSettings;
            launchBtn.Text = Resources.dbdLauncherStart;

            if (DMSLConfig.isNewConfig) {
                var dbdInstall = new DBDInstallPrompt();
                dbdInstall.ShowDialog();
            }
        }

        private void LauncherClosing(object sender, FormClosingEventArgs e) {
            DMSLConfig.saveConfig();
        }
    }
}