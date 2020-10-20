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
            this.creditLabel.Location = new System.Drawing.Point(3, 227);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(358, 25);
            this.creditLabel.TabIndex = 8;
            this.creditLabel.Text = "Among Us Hack by geard-dev#6274";
            // 
            // creditLabel2
            // 
            this.creditLabel2.AutoSize = true;
            this.creditLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(171)))), ((int)(((byte)(144)))));
            this.creditLabel2.Location = new System.Drawing.Point(400, 227);
            this.creditLabel2.Name = "creditLabel2";
            this.creditLabel2.Size = new System.Drawing.Size(434, 25);
            this.creditLabel2.TabIndex = 9;
            this.creditLabel2.Text = "Educational/Demonstrational Purposes Only";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(76)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(837, 261);
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
    }
}

