using System.ComponentModel;

namespace DeadmanSwitchLauncher {
    sealed partial class DBDInstallPrompt {
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
            this.installLabel = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.pathDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openBrowserBtn = new System.Windows.Forms.Button();
            this.finishedBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // installLabel
            // 
            this.installLabel.Location = new System.Drawing.Point(12, 9);
            this.installLabel.Name = "installLabel";
            this.installLabel.Size = new System.Drawing.Size(424, 19);
            this.installLabel.TabIndex = 0;
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(12, 31);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(343, 22);
            this.pathTextBox.TabIndex = 1;
            // 
            // openBrowserBtn
            // 
            this.openBrowserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.openBrowserBtn.Location = new System.Drawing.Point(361, 30);
            this.openBrowserBtn.Name = "openBrowserBtn";
            this.openBrowserBtn.Size = new System.Drawing.Size(75, 28);
            this.openBrowserBtn.TabIndex = 2;
            this.openBrowserBtn.UseVisualStyleBackColor = true;
            this.openBrowserBtn.Click += new System.EventHandler(this.openBrowserBtn_Click);
            // 
            // finishedBtn
            // 
            this.finishedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.finishedBtn.Location = new System.Drawing.Point(12, 59);
            this.finishedBtn.Name = "finishedBtn";
            this.finishedBtn.Size = new System.Drawing.Size(424, 42);
            this.finishedBtn.TabIndex = 3;
            this.finishedBtn.Text = "button1";
            this.finishedBtn.UseVisualStyleBackColor = true;
            this.finishedBtn.Click += new System.EventHandler(this.finishedBtn_Click);
            // 
            // DBDInstallPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 111);
            this.Controls.Add(this.finishedBtn);
            this.Controls.Add(this.openBrowserBtn);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.installLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DBDInstallPrompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button finishedBtn;

        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.FolderBrowserDialog pathDialog;
        private System.Windows.Forms.Button openBrowserBtn;

        private System.Windows.Forms.Label installLabel;

        #endregion
    }
}
