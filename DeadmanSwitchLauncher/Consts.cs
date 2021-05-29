using System;
using System.IO;

namespace DeadmanSwitchLauncher {
    public class Consts {
        // Executables
        public static readonly string DBD_EXE = "DeadByDaylight.exe";

        // Steam
        public static readonly string STEAM_PROCESS = "steam";
        public static readonly string DBD_STEAM_ID = "381210";

        // Install directories
        public static readonly string CURRENT_FOLDER = "Dead by Daylight";
        public static readonly string LIVE_FOLDER = CURRENT_FOLDER + " - LIVE";
        public static readonly string PTB_FOLDER = CURRENT_FOLDER + " - PTB";

        // AppManifest
        public static readonly string CURRENT_MANIFEST = "appmanifest_" + DBD_STEAM_ID + ".acf";
        public static readonly string LIVE_MANIFEST = CURRENT_MANIFEST + ".live";
        public static readonly string PTB_MANIFEST = CURRENT_MANIFEST + ".ptb";

        // Registry stuff
        private static readonly string UNINSTALL_SUBKEY = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
        public static readonly string DBD_LOCATION_KEY = UNINSTALL_SUBKEY + @"\Steam App " + DBD_STEAM_ID;
        public static readonly string DBD_INSTALL_KEY = "InstallLocation";
        public static readonly string STEAM_SUBKEY = @"SOFTWARE\Valve\Steam";
        public static readonly string STEAM_PATH_KEY = "SteamExe";

        // Config
        public static readonly string DATA_FOLDER = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DeadmanSwitchLauncher");
        public static readonly string CONFIG_FILE = Path.Combine(DATA_FOLDER, "config.cfg");
    }
}