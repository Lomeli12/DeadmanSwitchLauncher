using System.Diagnostics;
using Microsoft.Win32;

namespace DeadmanSwitchLauncher.Util {
    public class SteamUtil {
        // Gets all running processes that matches steam and closes them. Used during initial setup
        public static void closeSteam() {
            var processes = Process.GetProcessesByName(Consts.STEAM_PROCESS);
            if (processes.Length <= 0) return;
            foreach (var pro in processes) {
                pro.Kill();
            }
        }

        // It just runs steam
        public static void startSteam() {
            Process.Start(getSteamInstallPath());
        }

        // Generic "Get Install path from registry" function with null checks
        private static string getInstallPath(RegistryHive hive, string key, string entry) {
            var installPath = "";

            var result = RegistryUtil.getKeyValue(hive, key, entry);
            if (result != null)
                installPath = (string) result;

            return installPath;
        }

        // Uses the registry to get steam's install path
        public static string getSteamInstallPath() =>
            getInstallPath(RegistryHive.CurrentUser, Consts.STEAM_SUBKEY, Consts.STEAM_PATH_KEY);

        // Uses the registry to get DBD's install path
        public static string getDBDInstallPath() =>
            getInstallPath(RegistryHive.LocalMachine, Consts.DBD_LOCATION_KEY, Consts.DBD_INSTALL_KEY);
    }
}