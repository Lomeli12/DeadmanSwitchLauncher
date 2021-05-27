using Microsoft.Win32;

namespace DeadmanSwitchLauncher.Util {
    public class RegistryUtil {

        public static object getKeyValue(RegistryHive hive, string key, string entry) {
            // Tries to get the keys from Registry64, as otherwise using normal Registy.LocalMachine only gets 32bit keys
            using (var registryKey = RegistryKey.OpenBaseKey(hive, RegistryView.Registry64).OpenSubKey(key)) {
                if (registryKey == null) return null;
                foreach (var valueName in registryKey.GetValueNames()) {
                    if (entry.Equals(valueName))
                        return registryKey.GetValue(valueName);
                }
            }
            return null;
        }
    }
}