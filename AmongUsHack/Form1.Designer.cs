namespace AmongUsHack
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.setSpeedButton = new System.Windows.Forms.Button();
            this.setSpeedTextBox = new System.Windows.Forms.TextBox();
            this.speedLabel = new System.Windows.Forms.Label();
            this.visionLabel = new System.Windows.Forms.Label();
            this.setVisionTextBox = new System.Windows.Forms.TextBox();
            this.setVisionCrewmateButton = new System.Windows.Forms.Button();
            this.setVisionImpostorButton = new System.Windows.Forms.Button();
            this.creditLabel = new System.Windows.Forms.Label();
            this.creditLabel2 = new System.Windows.Forms.Label();
            this.killTimeoutLabel = new System.Windows.Forms.Label();
            this.setKillTimeoutTextBox = new System.Windows.Forms.TextBox();
            this.setKillTimeoutButton = new System.Windows.Forms.Button();
            this.setThemeTo1Button = new System.Windows.Forms.Button();
            this.setThemeTo2Button = new System.Windows.Forms.Button();
            this.setThemeTo3Button = new System.Windows.Forms.Button();
            this.setThemeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // setSpeedButton
            // 
            this.setSpeedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(240)))), ((int)(((byte)(196)))));
            this.setSpeedButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.setSpeedButton.Location = new System.Drawing.Point(331, 46);
            this.setSpeedButton.Name = "setSpeedButton";
            this.setSpeedButton.Size = new System.Drawing.Size(84, 38);
            this.setSpeedButton.TabIndex = 1;
            this.setSpeedButton.Text = "Set";
            this.setSpeedButton.UseVisualStyleBackColor = false;
            this.setSpeedButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // setSpeedTextBox
            // 
            this.setSpeedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(209)))));
            this.setSpeedTextBox.Location = new System.Drawing.Point(40, 50);
            this.setSpeedTextBox.Name = "setSpeedTextBox";
            this.setSpeedTextBox.Size = new System.Drawing.Size(260, 31);
            this.setSpeedTextBox.TabIndex = 2;
            this.setSpeedTextBox.Text = "1.0";
            this.setSpeedTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(171)))), ((int)(((byte)(144)))));
            this.speedLabel.Location = new System.Drawing.Point(44, 22);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(74, 25);
            this.speedLabel.TabIndex = 3;
            this.speedLabel.Text = "Speed";
            this.speedLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // visionLabel
            // 
            this.visionLabel.AutoSize = true;
            this.visionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(171)))), ((int)(((byte)(144)))));
            this.visionLabel.Location = new System.Drawing.Point(44, 102);
            this.visionLabel.Name = "visionLabel";
            this.visionLabel.Size = new System.Drawing.Size(71, 25);
            this.visionLabel.TabIndex = 6;
            this.visionLabel.Text = "Vision";
            // 
            // setVisionTextBox
            // 
            this.setVisionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(209)))));
            this.setVisionTextBox.Location = new System.Drawing.Point(40, 130);
            this.setVisionTextBox.Name = "setVisionTextBox";
            this.setVisionTextBox.Size = new System.Drawing.Size(260, 31);
            this.setVisionTextBox.TabIndex = 5;
            this.setVisionTextBox.Text = "1.0";
            // 
            // setVisionCrewmateButton
            // 
            this.setVisionCrewmateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(240)))), ((int)(((byte)(196)))));
            this.setVisionCrewmateButton.Location = new System.Drawing.Point(331, 126);
            this.setVisionCrewmateButton.Name = "setVisionCrewmateButton";
            this.setVisionCrewmateButton.Size = new System.Drawing.Size(198, 38);
            this.setVisionCrewmateButton.TabIndex = 4;
            this.setVisionCrewmateButton.Text = "Set for Crewmate";
            this.setVisionCrewmateButton.UseVisualStyleBackColor = false;
            this.setVisionCrewmateButton.Click += new System.EventHandler(this.setVisionCrewmateButton_Click);
            // 
            // setVisionImpostorButton
            // 
            this.setVisionImpostorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(240)))), ((int)(((byte)(196)))));
            this.setVisionImpostorButton.Location = new System.Drawing.Point(535, 126);
            this.setVisionImpostorButton.Name = "setVisionImpostorButton";
            this.setVisionImpostorButton.Size = new System.Drawing.Size(205, 38);
            this.setVisionImpostorButton.TabIndex = 7;
            this.setVisionImpostorButton.Text = "Set for Impostor";
            this.setVisionImpostorButton.UseVisualStyleBackColor = false;
            this.setVisionImpostorButton.Click += new System.EventHandler(this.setVisionImpostorButton_Click);
            // 
            // creditLabel
            // 
            this.creditLabel.AutoSize = true;
            this.creditLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(171)))), ((int)(((byte)(144)))));
            this.creditLabel.Location = new System.Drawing.Point(12, 289);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(358, 25);
            this.creditLabel.TabIndex = 8;
            this.creditLabel.Text = "Among Us Hack by geard-dev#6274";
            // 
            // creditLabel2
            // 
            this.creditLabel2.AutoSize = true;
            this.creditLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(171)))), ((int)(((byte)(144)))));
            this.creditLabel2.Location = new System.Drawing.Point(439, 289);
            this.creditLabel2.Name = "creditLabel2";
            this.creditLabel2.Size = new System.Drawing.Size(434, 25);
            this.creditLabel2.TabIndex = 9;
            this.creditLabel2.Text = "Educational/Demonstrational Purposes Only";
            // 
            // killTimeoutLabel
            // 
            this.killTimeoutLabel.AutoSize = true;
            this.killTimeoutLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(171)))), ((int)(((byte)(144)))));
            this.killTimeoutLabel.Location = new System.Drawing.Point(439, 22);
            this.killTimeoutLabel.Name = "killTimeoutLabel";
            this.killTimeoutLabel.Size = new System.Drawing.Size(124, 25);
            this.killTimeoutLabel.TabIndex = 12;
            this.killTimeoutLabel.Text = "Kill Timeout";
            // 
            // setKillTimeoutTextBox
            // 
            this.setKillTimeoutTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(209)))));
            this.setKillTimeoutTextBox.Location = new System.Drawing.Point(435, 50);
            this.setKillTimeoutTextBox.Name = "setKillTimeoutTextBox";
            this.setKillTimeoutTextBox.Size = new System.Drawing.Size(260, 31);
            this.setKillTimeoutTextBox.TabIndex = 11;
            this.setKillTimeoutTextBox.Text = "5.0";
            // 
            // setKillTimeoutButton
            // 
            this.setKillTimeoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(240)))), ((int)(((byte)(196)))));
            this.setKillTimeoutButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.setKillTimeoutButton.Location = new System.Drawing.Point(726, 46);
            this.setKillTimeoutButton.Name = "setKillTimeoutButton";
            this.setKillTimeoutButton.Size = new System.Drawing.Size(84, 38);
            this.setKillTimeoutButton.TabIndex = 10;
            this.setKillTimeoutButton.Text = "Set";
            this.setKillTimeoutButton.UseVisualStyleBackColor = false;
            this.setKillTimeoutButton.Click += new System.EventHandler(this.setKillTimeoutButton_Click);
            // 
            // setThemeTo1Button
            // 
            this.setThemeTo1Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(240)))), ((int)(((byte)(196)))));
            this.setThemeTo1Button.Location = new System.Drawing.Point(40, 221);
            this.setThemeTo1Button.Name = "setThemeTo1Button";
            this.setThemeTo1Button.Size = new System.Drawing.Size(168, 38);
            this.setThemeTo1Button.TabIndex = 13;
            this.setThemeTo1Button.Text = "Theme 1";
            this.setThemeTo1Button.UseVisualStyleBackColor = false;
            this.setThemeTo1Button.Click += new System.EventHandler(this.setThemeTo1Button_Click);
            // 
            // setThemeTo2Button
            // 
            this.setThemeTo2Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(240)))), ((int)(((byte)(196)))));
            this.setThemeTo2Button.Location = new System.Drawing.Point(214, 221);
            this.setThemeTo2Button.Name = "setThemeTo2Button";
            this.setThemeTo2Button.Size = new System.Drawing.Size(168, 38);
            this.setThemeTo2Button.TabIndex = 14;
            this.setThemeTo2Button.Text = "Theme 2";
            this.setThemeTo2Button.UseVisualStyleBackColor = false;
            this.setThemeTo2Button.Click += new System.EventHandler(this.setThemeTo2Button_Click);
            // 
            // setThemeTo3Button
            // 
            this.setThemeTo3Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(240)))), ((int)(((byte)(196)))));
            this.setThemeTo3Button.Location = new System.Drawing.Point(388, 221);
            this.setThemeTo3Button.Name = "setThemeTo3Button";
            this.setThemeTo3Button.Size = new System.Drawing.Size(168, 38);
            this.setThemeTo3Button.TabIndex = 16;
            this.setThemeTo3Button.Text = "Theme 3";
            this.setThemeTo3Button.UseVisualStyleBackColor = false;
            this.setThemeTo3Button.Click += new System.EventHandler(this.setThemeTo3Button_Click);
            // 
            // setThemeLabel
            // 
            this.setThemeLabel.AutoSize = true;
            this.setThemeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(171)))), ((int)(((byte)(144)))));
            this.setThemeLabel.Location = new System.Drawing.Point(44, 193);
            this.setThemeLabel.Name = "setThemeLabel";
            this.setThemeLabel.Size = new System.Drawing.Size(135, 25);
            this.setThemeLabel.TabIndex = 17;
            this.setThemeLabel.Text = "Color Theme";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(76)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(878, 323);
            this.Controls.Add(this.setThemeLabel);
            this.Controls.Add(this.setThemeTo3Button);
            this.Controls.Add(this.setThemeTo2Button);
            this.Controls.Add(this.setThemeTo1Button);
            this.Controls.Add(this.killTimeoutLabel);
            this.Controls.Add(this.setKillTimeoutTextBox);
            this.Controls.Add(this.setKillTimeoutButton);
            this.Controls.Add(this.creditLabel2);
            this.Controls.Add(this.creditLabel);
            this.Controls.Add(this.setVisionImpostorButton);
            this.Controls.Add(this.visionLabel);
            this.Controls.Add(this.setVisionTextBox);
            this.Controls.Add(this.setVisionCrewmateButton);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.setSpeedTextBox);
            this.Controls.Add(this.setSpeedButton);
            this.Name = "Form1";
            this.Text = "Among Us Hacks by geard-dev";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button setSpeedButton;
        private System.Windows.Forms.TextBox setSpeedTextBox;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label visionLabel;
        private System.Windows.Forms.TextBox setVisionTextBox;
        private System.Windows.Forms.Button setVisionCrewmateButton;
        private System.Windows.Forms.Button setVisionImpostorButton;
        private System.Windows.Forms.Label creditLabel;
        private System.Windows.Forms.Label creditLabel2;
        private System.Windows.Forms.Label killTimeoutLabel;
        private System.Windows.Forms.TextBox setKillTimeoutTextBox;
        private System.Windows.Forms.Button setKillTimeoutButton;
        private System.Windows.Forms.Button setThemeTo1Button;
        private System.Windows.Forms.Button setThemeTo2Button;
        private System.Windows.Forms.Button setThemeTo3Button;
        private System.Windows.Forms.Label setThemeLabel;
    }
}

