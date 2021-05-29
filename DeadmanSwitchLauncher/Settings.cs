using System;
using System.Windows.Forms;
using DeadmanSwitchLauncher.Config;

namespace DeadmanSwitchLauncher {
    public partial class Settings : Form {
        public Settings() {
            InitializeComponent();

            initLocalization();
        }

        public bool settingsCleared { get; private set; }

        private void initLocalization() {
            Text = Resources.dbdSettingsTitle;
            clearSettingsLabel.Text = Resources.dbdSettingsClear;
            clearSettingsBtn.Text = Resources.dbdSettingsClearButton;
            keepOpenBox.Text = Resources.dbdSettingsKeepLauncherOpen;
            okBtn.Text = Resources.dbdSettingsOk;
            cancelBtn.Text = Resources.dbdSettingsCancel;
        }

        private void clearSettingsBtn_Click(object sender, EventArgs e) {
            var response = MessageBox.Show(Resources.dbdSettingsSure,
                Resources.dbdSettingsSureTitle,
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (response == DialogResult.Yes) {
                settingsCleared = true;
                DMSLConfig.clearSettings();
                MessageBox.Show(Resources.dbdSettingsCleared, Resources.dbdSettingsClearedTitle,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void okBtn_Click(object sender, EventArgs e) {
            DMSLConfig.getConfig().keepOpenOnLaunch = keepOpenBox.Checked;
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            Close();
        }
    }
}