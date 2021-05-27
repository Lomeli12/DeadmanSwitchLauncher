using System;
using System.Windows.Forms;
using DeadmanSwitchLauncher.Properties;
using DeadmanSwitchLauncher.Util;

namespace DeadmanSwitchLauncher {
    public sealed partial class DBDInstallPrompt : Form {
        public DBDInstallPrompt() {
            InitializeComponent();
            Text = Resources.dbdInstallPromptTitle;
            installLabel.Text = Resources.dbdInstallPromptLabel;
            openBrowserBtn.Text = Resources.dbdInstallPromptButton;
            finishedBtn.Text = Resources.dbdInstallPromptFinished;

            var dbdPath = SteamUtil.getDBDInstallPath();
            if (!string.IsNullOrWhiteSpace(dbdPath))
                pathTextBox.Text = dbdPath;
        }

        private void openBrowserBtn_Click(object sender, EventArgs e) {
            var result = pathDialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(pathDialog.SelectedPath))
                pathTextBox.Text = pathDialog.SelectedPath;
        }

        private void finishedBtn_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
