using System;
using System.Windows.Forms;
using DeadmanSwitchLauncher.Config;

namespace DeadmanSwitchLauncher {
    public partial class BuildPrompt : Form {
        public DBDBuild build { get; set; }
        private bool FINISHED;

        public BuildPrompt() {
            InitializeComponent();
            initLocalization();
        }

        private void initLocalization() {
            Text = Resources.dbdBuildPromptTitle;
            buildPromptLabel.Text = Resources.dbdBuildPromptLabel;
            liveBtn.Text = Resources.dbdBuildPromptLive;
            ptbBtn.Text = Resources.dbdBuildPromptPTB;
        }

        private void liveBtn_Click(object sender, EventArgs e) {
            build = DBDBuild.LIVE;
            FINISHED = true;
            Close();
        }

        private void ptbBtn_Click(object sender, EventArgs e) {
            build = DBDBuild.PTB;
            FINISHED = true;
            Close();
        }

        private void buildPrompt_FormClosing(object sender, FormClosingEventArgs e) {
            if (FINISHED) return;
            MessageBox.Show(Resources.dbdBuildPromptCancel, Resources.dbdBuildPromptCancelTitle,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.Cancel = true;
        }
    }
}