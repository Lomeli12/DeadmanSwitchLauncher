using System.Diagnostics;
using Microsoft.Win32;

namespace DeadmanSwitchLauncher.Util {
    public class SteamUtil {
        public static void closeSteam() {
            var processes = Process.GetProcessesByName(Consts.STEAM_PROCESS);
            if (processes.Length <= 0) return;
            foreach (var pro in processes) {
                pro.Kill();
            }
        }

        public static void startSteam() {
            Process.Start(getSteamInstallPath());
        }

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