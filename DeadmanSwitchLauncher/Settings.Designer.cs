using System.ComponentModel;

namespace DeadmanSwitchLauncher {
    partial class Settings {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.clearSettingsLabel = new System.Windows.Forms.Label();
            this.clearSettingsBtn = new System.Windows.Forms.Button();
            this.keepOpenBox = new System.Windows.Forms.CheckBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clearSettingsLabel
            // 
            this.clearSettingsLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.clearSettingsLabel.Location = new System.Drawing.Point(12, 9);
            this.clearSettingsLabel.Name = "clearSettingsLabel";
            this.clearSettingsLabel.Size = new System.Drawing.Size(484, 62);
            this.clearSettingsLabel.TabIndex = 0;
            this.clearSettingsLabel.Text = "label1";
            // 
            // clearSettingsBtn
            // 
            this.clearSettingsBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.clearSettingsBtn.Location = new System.Drawing.Point(502, 9);
            this.clearSettingsBtn.Name = "clearSettingsBtn";
            this.clearSettingsBtn.Size = new System.Drawing.Size(143, 62);
            this.clearSettingsBtn.TabIndex = 1;
            this.clearSettingsBtn.Text = "button1";
            this.clearSettingsBtn.UseVisualStyleBackColor = true;
            this.clearSettingsBtn.Click += new System.EventHandler(this.clearSettingsBtn_Click);
            // 
            // keepOpenBox
            // 
            this.keepOpenBox.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.keepOpenBox.Location = new System.Drawing.Point(12, 74);
            this.keepOpenBox.Name = "keepOpenBox";
            this.keepOpenBox.Size = new System.Drawing.Size(633, 63);
            this.keepOpenBox.TabIndex = 2;
            this.keepOpenBox.Text = "checkBox1";
            this.keepOpenBox.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            this.okBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.okBtn.Location = new System.Drawing.Point(353, 143);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(143, 62);
            this.okBtn.TabIndex = 3;
            this.okBtn.Text = "button1";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cancelBtn.Location = new System.Drawing.Point(504, 143);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(143, 62);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "button1";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 226);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.keepOpenBox);
            this.Controls.Add(this.clearSettingsBtn);
            this.Controls.Add(this.clearSettingsLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.CheckBox keepOpenBox;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;

        private System.Windows.Forms.Label clearSettingsLabel;
        private System.Windows.Forms.Button clearSettingsBtn;

        #endregion
    }
}