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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // setSpeedButton
            // 
            this.setSpeedButton.Location = new System.Drawing.Point(331, 46);
            this.setSpeedButton.Name = "setSpeedButton";
            this.setSpeedButton.Size = new System.Drawing.Size(84, 38);
            this.setSpeedButton.TabIndex = 1;
            this.setSpeedButton.Text = "Set";
            this.setSpeedButton.UseVisualStyleBackColor = true;
            this.setSpeedButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // setSpeedTextBox
            // 
            this.setSpeedTextBox.Location = new System.Drawing.Point(40, 50);
            this.setSpeedTextBox.Name = "setSpeedTextBox";
            this.setSpeedTextBox.Size = new System.Drawing.Size(260, 31);
            this.setSpeedTextBox.TabIndex = 2;
            this.setSpeedTextBox.Text = "1.0";
            this.setSpeedTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Speed";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
    }
}

