namespace DeadmanSwitchLauncher {
    public class Consts {
        // Executables
        public static readonly string DBD_EXE = "DeadByDaylight.exe";
        public static readonly string STEAM_EXE = "steam.exe";

        // Install directories
        public static readonly string CURRENT_FOLDER = "Dead by Daylight";
        public static readonly string LIVE_FOLDER = CURRENT_FOLDER + " - LIVE";
        public static readonly string PTB_FOLDER = CURRENT_FOLDER + " - PTB";

        // AppManifest
        public static readonly string CURRENT_MANIFEST = "appmanifest_381210.acf";
        public static readonly string LIVE_MANIFEST = CURRENT_MANIFEST + ".live";
        public static readonly string PTB_MANIFEST = CURRENT_MANIFEST + ".ptb";

        // Registry stuff
        private static readonly string UNINSTALL_SUBKEY = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
        public static readonly string DBD_LOCATION_KEY = UNINSTALL_SUBKEY + @"\Steam App 381210";
        public static readonly string DBD_INSTALL_KEY = "InstallLocation";
        public static readonly string STEAM_SUBKEY = @"SOFTWARE\Valve\Steam";
        public static readonly string STEAM_PATH_KEY = "SteamPath";
    }
}
