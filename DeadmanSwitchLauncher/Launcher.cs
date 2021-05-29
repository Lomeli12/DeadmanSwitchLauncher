using System;
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

            liveBuildRadio.Checked = DMSLConfig.getConfig().dbdBuild == DBDBuild.LIVE;
            ptbBuildRadio.Checked = DMSLConfig.getConfig().dbdBuild == DBDBuild.PTB;

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
            var parentDir = Directory.GetParent(DMSLConfig.getConfig().dbdPath);
            if (parentDir == null) {
                //TODO: Warning
                return;
            }

            liveFolder = Path.Combine(parentDir.ToString(),
                Consts.LIVE_FOLDER);
            ptbFolder = Path.Combine(parentDir.ToString(), Consts.PTB_FOLDER);
            var parentParentDir = Directory.GetParent(parentDir.ToString());
            if (parentParentDir == null) {
                //TODO: Warning
                return;
            }

            appFolder = parentParentDir.ToString();

            if (!Directory.Exists(liveFolder) && !Directory.Exists(ptbFolder)) {
                var buildPrompt = new BuildPrompt();
                buildPrompt.ShowDialog();

                processInstallFolder(buildPrompt.build);

                MessageBox.Show(buildPrompt.build == DBDBuild.LIVE
                    ? Resources.dbdInstallPTB
                    : Resources.dbdInstallLive);

                processInstallFolder(DBDBuildUtil.opposite(buildPrompt.build));

                Directory.Delete(DMSLConfig.getConfig().dbdPath);
                Directory.Move(buildPrompt.build == DBDBuild.LIVE ? liveFolder : ptbFolder,
                    DMSLConfig.getConfig().dbdPath);

                DMSLConfig.getConfig().dbdBuild = buildPrompt.build;
            }
        }

        private void processInstallFolder(DBDBuild build) {
            SteamUtil.closeSteam();

            var currentManifest = Path.Combine(appFolder, Consts.CURRENT_MANIFEST);
            var targetFolder = DMSLConfig.getConfig().dbdPath;
            var targetManifest = currentManifest;

            switch (build) {
                case DBDBuild.LIVE:
                    targetFolder = liveFolder;
                    targetManifest = Path.Combine(appFolder, Consts.LIVE_MANIFEST);
                    break;
                case DBDBuild.PTB:
                    targetFolder = ptbFolder;
                    targetManifest = Path.Combine(appFolder, Consts.PTB_MANIFEST);
                    break;
                default:
                    Console.WriteLine(Resources.dbdInstallHow);
                    break;
            }

            Directory.Move(DMSLConfig.getConfig().dbdPath, targetFolder);
            File.Copy(currentManifest, targetManifest);
            Directory.CreateDirectory(DMSLConfig.getConfig().dbdPath);

            SteamUtil.startSteam();
        }

        private void launcherClosing(object sender, FormClosingEventArgs e) {
            DMSLConfig.saveConfig();
        }
    }
}