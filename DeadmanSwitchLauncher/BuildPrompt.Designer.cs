using System.ComponentModel;

namespace DeadmanSwitchLauncher {
    partial class BuildPrompt {
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
            this.buildPromptLabel = new System.Windows.Forms.Label();
            this.liveBtn = new System.Windows.Forms.Button();
            this.ptbBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buildPromptLabel
            // 
            this.buildPromptLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buildPromptLabel.Location = new System.Drawing.Point(12, 9);
            this.buildPromptLabel.Name = "buildPromptLabel";
            this.buildPromptLabel.Size = new System.Drawing.Size(493, 54);
            this.buildPromptLabel.TabIndex = 0;
            // 
            // liveBtn
            // 
            this.liveBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.liveBtn.Location = new System.Drawing.Point(12, 66);
            this.liveBtn.Name = "liveBtn";
            this.liveBtn.Size = new System.Drawing.Size(161, 70);
            this.liveBtn.TabIndex = 1;
            this.liveBtn.Text = "button1";
            this.liveBtn.UseVisualStyleBackColor = true;
            this.liveBtn.Click += new System.EventHandler(this.liveBtn_Click);
            // 
            // ptbBtn
            // 
            this.ptbBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ptbBtn.Location = new System.Drawing.Point(337, 66);
            this.ptbBtn.Name = "ptbBtn";
            this.ptbBtn.Size = new System.Drawing.Size(161, 70);
            this.ptbBtn.TabIndex = 2;
            this.ptbBtn.Text = "button2";
            this.ptbBtn.UseVisualStyleBackColor = true;
            this.ptbBtn.Click += new System.EventHandler(this.ptbBtn_Click);
            // 
            // BuildPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 149);
            this.Controls.Add(this.ptbBtn);
            this.Controls.Add(this.liveBtn);
            this.Controls.Add(this.buildPromptLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuildPrompt";
            this.Text = "BuildPrompt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.buildPrompt_FormClosing);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button ptbBtn;

        private System.Windows.Forms.Button liveBtn;

        private System.Windows.Forms.Label buildPromptLabel;

        #endregion
    }
}