using System.Windows.Forms;

namespace DeadmanSwitchLauncher {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            var dbdInstall = new DBDInstallPrompt();
            dbdInstall.ShowDialog();
        }
    }
}