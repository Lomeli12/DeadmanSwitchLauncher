using System.IO;
using System.Windows.Forms;
using DeadmanSwitchLauncher.Config;
using DeadmanSwitchLauncher.Util;

namespace DeadmanSwitchLauncher {
    public sealed partial class Launcher : Form {
        private string liveFolder { get; set; }
        private string ptbFolder { get; set; }

        private string appFolder { get; set; }

        public Launcher() {
            InitializeComponent();

            Text = Resources.dbdLauncherTitle;
            liveBuildRadio.Text = Resources.dbdLauncherRadioLive;
            ptbBuildRadio.Text = Resources.dbdLauncherRadioPTB;
            settingsBtn.Text = Resources.dbdLauncherSettings;
            launchBtn.Text = Resources.dbdLauncherStart;

            configSetup();
            setupBuilds();
        }

        private void configSetup() {
            if (!Directory.Exists(DMSLConfig.getConfig().dbdPath))
                DMSLConfig.isNewConfig = true;

            if (DMSLConfig.isNewConfig) {
                var dbdInstall = new DBDInstallPrompt();
                dbdInstall.ShowDialog();
            }
        }

        private void setupBuilds() {
            liveFolder = Path.Combine(Directory.GetParent(DMSLConfig.getConfig().dbdPath).ToString(),
                Consts.LIVE_FOLDER);
            ptbFolder = Path.Combine(Directory.GetParent(DMSLConfig.getConfig().dbdPath).ToString(), Consts.PTB_FOLDER);
            appFolder = Directory.GetParent(Directory.GetParent(DMSLConfig.getConfig().dbdPath).ToString()).ToString();

            if (!Directory.Exists(liveFolder) && !Directory.Exists(ptbFolder)) {
                var buildPrompt = new BuildPrompt();
                buildPrompt.ShowDialog();

                processInstallFolder(buildPrompt.build, liveFolder, ptbFolder, appFolder);
            }
        }

        private void processInstallFolder(DBDBuild build, string live, string ptb, string app) {
            SteamUtil.closeSteam();
            switch (build) {
                case DBDBuild.LIVE:
                    Directory.Move(DMSLConfig.getConfig().dbdPath, live);
                    File.Copy(Path.Combine(appFolder, Consts.CURRENT_MANIFEST),
                        Path.Combine(appFolder, Consts.LIVE_MANIFEST));
                    break;
                case DBDBuild.PTB:
                    Directory.Move(DMSLConfig.getConfig().dbdPath, ptb);
                    File.Copy(Path.Combine(appFolder, Consts.CURRENT_MANIFEST),
                        Path.Combine(appFolder, Consts.PTB_MANIFEST));
                    break;
            }

            Directory.CreateDirectory(DMSLConfig.getConfig().dbdPath);

            SteamUtil.startSteam();
        }

        private void launcherClosing(object sender, FormClosingEventArgs e) {
            DMSLConfig.saveConfig();
        }
    }
}