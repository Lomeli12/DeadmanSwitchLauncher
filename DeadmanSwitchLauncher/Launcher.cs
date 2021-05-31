using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeadmanSwitchLauncher.Config;
using DeadmanSwitchLauncher.Util;

namespace DeadmanSwitchLauncher {
    public sealed partial class Launcher : Form {
        private string liveFolder { get; set; }
        private string ptbFolder { get; set; }
        private string appFolder { get; set; }
        private bool saveSettigs { get; set; } = true;

        public Launcher() {
            InitializeComponent();
            initLocalization();

            configSetup();
            setupBuilds();

            liveBuildRadio.Checked = DMSLConfig.getConfig().dbdBuild == DBDBuild.LIVE;
            ptbBuildRadio.Checked = DMSLConfig.getConfig().dbdBuild == DBDBuild.PTB;
        }

        private void initLocalization() {
            Text = Resources.dbdLauncherTitle;
            liveBuildRadio.Text = Resources.dbdLauncherRadioLive;
            ptbBuildRadio.Text = Resources.dbdLauncherRadioPTB;
            settingsBtn.Text = Resources.dbdLauncherSettings;
            launchBtn.Text = DMSLConfig.getConfig().swapWithoutLaunch
                ? Resources.dbdLauncherSwap
                : Resources.dbdLauncherStart;
        }

        // Attempts to launch the game. If a swap is necessary, it tries to swap the builds before attempting to launch
        private void launchBtn_Click(object sender, EventArgs e) {
            // I really really hate this
            var build = DMSLConfig.getConfig().dbdBuild;
            if ((build == DBDBuild.LIVE && !liveBuildRadio.Checked) ||
                (build == DBDBuild.PTB && !ptbBuildRadio.Checked)) {
                DMSLConfig.getConfig().dbdBuild = DBDBuildUtil.opposite(build);
                build = DMSLConfig.getConfig().dbdBuild;

                var swapTask = Task.Run(() => {
                    var restartSteam = SteamUtil.isSteamRunning();
                    if (restartSteam) SteamUtil.closeSteam();
                    switch (build) {
                        case DBDBuild.LIVE:
                            swapFolders(ptbFolder, liveFolder,
                                Path.Combine(appFolder, Consts.LIVE_MANIFEST));
                            break;
                        case DBDBuild.PTB:
                            swapFolders(liveFolder, ptbFolder,
                                Path.Combine(appFolder, Consts.PTB_MANIFEST));
                            break;
                        default:
                            Console.WriteLine(Resources.dbdInstallHow);
                            break;
                    }

                    if (restartSteam) SteamUtil.startSteam();
                });
                if (!swapTask.Wait(TimeSpan.FromMinutes(3))) {
                    Console.WriteLine(Resources.dbdInstallHow);
                    MessageBox.Show(Resources.dbdLaunchTimeout, Resources.dbdLaunchTimeoutTitle,
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (!DMSLConfig.getConfig().swapWithoutLaunch) Process.Start("steam://rungameid/" + Consts.DBD_STEAM_ID);
            if (!DMSLConfig.getConfig().keepOpenOnLaunch) Close();
        }

        // Swap the currently running build with the saved build (i.e. Live <-> PTB)
        private void swapFolders(string oldFolder, string newFolder, string newManifest) {
            if (!Directory.Exists(oldFolder))
                Directory.Move(DMSLConfig.getConfig().dbdPath, oldFolder);
            if (Directory.Exists(newFolder))
                Directory.Move(newFolder, DMSLConfig.getConfig().dbdPath);

            File.Copy(newManifest, Path.Combine(appFolder, Consts.CURRENT_MANIFEST), true);
        }

        // Prompts the user to give the install location of DBD. It'll attempt to auto retrieve this info from registry
        // but gives the user a chance to point to the directory themselves
        private void configSetup() {
            if (!Directory.Exists(DMSLConfig.getConfig().dbdPath))
                DMSLConfig.isNewConfig = true;

            if (DMSLConfig.isNewConfig) {
                MessageBox.Show(Resources.dbdDisableAutoUpdate, Resources.dbdDisableAutoUpdateTitle,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                var dbdInstall = new DBDInstallPrompt();
                dbdInstall.ShowDialog();
            }
        }

        // Setup process for getting the launcher to work. First it gets a copy of both the Live and PTB builds of 
        // the game and app manifest, renames them accordingly as to not overwrite each other, and then restores
        // whichever the user initially had installed
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

        // Makes a copy of either the Live or PTB build folder and app manifest
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
            File.Copy(currentManifest, targetManifest, true);
            Directory.CreateDirectory(DMSLConfig.getConfig().dbdPath);

            SteamUtil.startSteam();
        }

        // Save config before closing, if it hasn't been deleted
        private void launcherClosing(object sender, FormClosingEventArgs e) {
            if (saveSettigs)
                DMSLConfig.saveConfig();
        }

        // Opens the settings dialog. If the user decided to clear their settings,
        // DON'T SAVE A NEW CONFIG FILE AFTER THEY JUST CHOSE DELETED IT
        private void settingsBtn_Click(object sender, EventArgs e) {
            var settings = new Settings();
            settings.ShowDialog();
            initLocalization();
            if (!settings.settingsCleared) return;
            saveSettigs = false;
            Close();
        }
    }
}