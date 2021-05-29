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
    }
}