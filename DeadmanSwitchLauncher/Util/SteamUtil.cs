using Microsoft.Win32;

namespace DeadmanSwitchLauncher.Util {
    public class SteamUtil {
        private static string getInstallPath(RegistryHive hive, string key, string entry) {
            var installPath = "";

            var result = RegistryUtil.getKeyValue(hive, key, entry);
            if (result != null)
                installPath = (string) result;

            return installPath;
        }

        public static string getSteamInstallPath() =>
            getInstallPath(RegistryHive.CurrentUser, Consts.STEAM_SUBKEY, Consts.STEAM_PATH_KEY);

        public static string getDBDInstallPath() =>
            getInstallPath(RegistryHive.LocalMachine, Consts.DBD_LOCATION_KEY, Consts.DBD_INSTALL_KEY);
    }
}