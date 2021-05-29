using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace DeadmanSwitchLauncher.Config {
    public class DMSLConfig {
        private static DMSLConfig instance;
        public static bool isNewConfig = false;

        private DMSLConfig() { }

        public string dbdPath { get; set; }
        public DBDBuild dbdBuild { get; set; }
        public bool keepOpenOnLaunch { get; set; }

        private static void initConfig() {
            if (!Directory.Exists(Consts.DATA_FOLDER))
                Directory.CreateDirectory(Consts.DATA_FOLDER);
            if (!File.Exists(Consts.CONFIG_FILE)) {
                instance = new DMSLConfig();
                saveConfig();
                isNewConfig = true;
            } else {
                var input = "";
                using (var stream = new FileStream(Consts.CONFIG_FILE, FileMode.Open, FileAccess.Read))
                using (var reader = new StreamReader(stream, Encoding.UTF8))
                    input = reader.ReadToEnd();
                instance = JsonConvert.DeserializeObject<DMSLConfig>(input);
            }
        }

        public static DMSLConfig getConfig() {
            if (instance == null) initConfig();
            return instance;
        }

        public static DMSLConfig saveConfig() {
            if (instance == null) return instance;
            using (var stream = new FileStream(Consts.CONFIG_FILE, FileMode.Create, FileAccess.Write, FileShare.Read))
            using (var writer = new StreamWriter(stream, Encoding.UTF8))
                writer.Write(JsonConvert.SerializeObject(instance, Formatting.Indented));
            return instance;
        }

        public static void clearSettings() {
            if (instance == null) return;
            Directory.Delete(Consts.DATA_FOLDER, true);
            try {
                var gameParentDir = Directory.GetParent(instance.dbdPath).ToString();

                var tmpFolder = Path.Combine(gameParentDir, Consts.LIVE_FOLDER);
                if (Directory.Exists(tmpFolder))
                    Directory.Delete(tmpFolder, true);
                tmpFolder = Path.Combine(gameParentDir, Consts.PTB_FOLDER);
                if (Directory.Exists(tmpFolder))
                    Directory.Delete(tmpFolder, true);
                try {
                    var appParentDir = Directory.GetParent(gameParentDir).ToString();
                    var tmpManifest = Path.Combine(appParentDir, Consts.LIVE_MANIFEST);
                    if (File.Exists(tmpManifest))
                        File.Delete(tmpManifest);
                    tmpManifest = Path.Combine(appParentDir, Consts.PTB_MANIFEST);
                    if (File.Exists(tmpManifest))
                        File.Delete(tmpManifest);
                } catch (NullReferenceException ex) {
                    Console.WriteLine(@"Could not get app manifest directory. Does it not exist?");
                }
            } catch (NullReferenceException ex) {
                Console.WriteLine(@"Could not get parent directory. Does it not exist?");
            }
        }
    }
}