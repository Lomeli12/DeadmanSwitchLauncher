namespace DeadmanSwitchLauncher {
    sealed partial class Launcher {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.controlPanel = new System.Windows.Forms.Panel();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.dbdImageResources = new System.Windows.Forms.ImageList(this.components);
            this.launchBtn = new System.Windows.Forms.Button();
            this.buildTypePanel = new System.Windows.Forms.Panel();
            this.ptbBuildRadio = new System.Windows.Forms.RadioButton();
            this.liveBuildRadio = new System.Windows.Forms.RadioButton();
            this.controlPanel.SuspendLayout();
            this.buildTypePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.Transparent;
            this.controlPanel.Controls.Add(this.settingsBtn);
            this.controlPanel.Controls.Add(this.launchBtn);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPanel.Location = new System.Drawing.Point(0, 144);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(736, 140);
            this.controlPanel.TabIndex = 1;
            // 
            // settingsBtn
            // 
            this.settingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.settingsBtn.FlatAppearance.BorderSize = 0;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.settingsBtn.ForeColor = System.Drawing.Color.White;
            this.settingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsBtn.ImageIndex = 3;
            this.settingsBtn.ImageList = this.dbdImageResources;
            this.settingsBtn.Location = new System.Drawing.Point(12, 6);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(287, 128);
            this.settingsBtn.TabIndex = 0;
            this.settingsBtn.Text = "button2";
            this.settingsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // dbdImageResources
            // 
            this.dbdImageResources.ImageStream = ((System.Windows.Forms.ImageListStreamer) (resources.GetObject("dbdImageResources.ImageStream")));
            this.dbdImageResources.TransparentColor = System.Drawing.SystemColors.WindowText;
            this.dbdImageResources.Images.SetKeyName(0, "iconHelp_exitGates.png");
            this.dbdImageResources.Images.SetKeyName(1, "iconHelp_HowToWin_survivors.png");
            this.dbdImageResources.Images.SetKeyName(2, "iconItems_toolboxCommodious.png");
            this.dbdImageResources.Images.SetKeyName(3, "iconStatusEffects_repairing.png");
            this.dbdImageResources.Images.SetKeyName(4, "iconPerks_deadManSwitch.png");
            this.dbdImageResources.Images.SetKeyName(5, "splashBanner_ARCR.png");
            // 
            // launchBtn
            // 
            this.launchBtn.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.launchBtn.FlatAppearance.BorderSize = 0;
            this.launchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.launchBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.launchBtn.ForeColor = System.Drawing.Color.White;
            this.launchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.launchBtn.ImageIndex = 0;
            this.launchBtn.ImageList = this.dbdImageResources;
            this.launchBtn.Location = new System.Drawing.Point(437, 6);
            this.launchBtn.Name = "launchBtn";
            this.launchBtn.Size = new System.Drawing.Size(287, 128);
            this.launchBtn.TabIndex = 1;
            this.launchBtn.Text = "button1";
            this.launchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.launchBtn.UseVisualStyleBackColor = true;
            this.launchBtn.Click += new System.EventHandler(this.launchBtn_Click);
            // 
            // buildTypePanel
            // 
            this.buildTypePanel.BackColor = System.Drawing.Color.Transparent;
            this.buildTypePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buildTypePanel.Controls.Add(this.ptbBuildRadio);
            this.buildTypePanel.Controls.Add(this.liveBuildRadio);
            this.buildTypePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buildTypePanel.Location = new System.Drawing.Point(0, 0);
            this.buildTypePanel.Name = "buildTypePanel";
            this.buildTypePanel.Size = new System.Drawing.Size(736, 144);
            this.buildTypePanel.TabIndex = 0;
            // 
            // ptbBuildRadio
            // 
            this.ptbBuildRadio.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbBuildRadio.BackColor = System.Drawing.Color.Transparent;
            this.ptbBuildRadio.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ptbBuildRadio.ForeColor = System.Drawing.Color.White;
            this.ptbBuildRadio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ptbBuildRadio.ImageIndex = 2;
            this.ptbBuildRadio.ImageList = this.dbdImageResources;
            this.ptbBuildRadio.Location = new System.Drawing.Point(393, 12);
            this.ptbBuildRadio.Name = "ptbBuildRadio";
            this.ptbBuildRadio.Size = new System.Drawing.Size(331, 126);
            this.ptbBuildRadio.TabIndex = 1;
            this.ptbBuildRadio.TabStop = true;
            this.ptbBuildRadio.Text = "radioButton1";
            this.ptbBuildRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ptbBuildRadio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ptbBuildRadio.UseVisualStyleBackColor = false;
            // 
            // liveBuildRadio
            // 
            this.liveBuildRadio.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.liveBuildRadio.ForeColor = System.Drawing.Color.White;
            this.liveBuildRadio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.liveBuildRadio.ImageIndex = 1;
            this.liveBuildRadio.ImageList = this.dbdImageResources;
            this.liveBuildRadio.Location = new System.Drawing.Point(12, 12);
            this.liveBuildRadio.Name = "liveBuildRadio";
            this.liveBuildRadio.Size = new System.Drawing.Size(331, 126);
            this.liveBuildRadio.TabIndex = 0;
            this.liveBuildRadio.TabStop = true;
            this.liveBuildRadio.Text = "radioButton1";
            this.liveBuildRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.liveBuildRadio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.liveBuildRadio.UseVisualStyleBackColor = true;
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(736, 284);
            this.Controls.Add(this.buildTypePanel);
            this.Controls.Add(this.controlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "Launcher";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.launcherClosing);
            this.controlPanel.ResumeLayout(false);
            this.buildTypePanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button settingsBtn;

        private System.Windows.Forms.Button launchBtn;

        private System.Windows.Forms.ImageList dbdImageResources;

        private System.Windows.Forms.RadioButton liveBuildRadio;
        private System.Windows.Forms.RadioButton ptbBuildRadio;

        private System.Windows.Forms.Panel buildTypePanel;

        private System.Windows.Forms.Panel controlPanel;

        #endregion
    }
}