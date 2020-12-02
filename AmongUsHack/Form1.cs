using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmongUsHack
{
    public partial class Form1 : Form
    {
        Memory.Mem memory = new Memory.Mem();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(94, 76, 90);

            setSpeedTextBox.BackColor = System.Drawing.Color.FromArgb(255, 226, 209);
            setVisionTextBox.BackColor = System.Drawing.Color.FromArgb(255, 226, 209);
            setKillTimeoutTextBox.BackColor = System.Drawing.Color.FromArgb(255, 226, 209);

            setSpeedButton.BackColor = System.Drawing.Color.FromArgb(225, 240, 196);
            setVisionCrewmateButton.BackColor = System.Drawing.Color.FromArgb(225, 240, 196);
            setKillTimeoutButton.BackColor = System.Drawing.Color.FromArgb(225, 240, 196);
            setThemeTo1Button.BackColor = System.Drawing.Color.FromArgb(225, 240, 196);
            setThemeTo2Button.BackColor = System.Drawing.Color.FromArgb(225, 240, 196);
            setThemeTo3Button.BackColor = System.Drawing.Color.FromArgb(225, 240, 196);

            speedLabel.ForeColor = System.Drawing.Color.FromArgb(107, 171, 144);
            visionLabel.ForeColor = System.Drawing.Color.FromArgb(107, 171, 144);
            killTimeoutLabel.ForeColor = System.Drawing.Color.FromArgb(107, 171, 144);
            setThemeLabel.ForeColor = System.Drawing.Color.FromArgb(107, 171, 144);
            creditLabel.ForeColor = System.Drawing.Color.FromArgb(107, 171, 144);
            creditLabel2.ForeColor = System.Drawing.Color.FromArgb(107, 171, 144);

            speedLabel.BackColor = System.Drawing.Color.FromArgb(94, 76, 90);
            visionLabel.BackColor = System.Drawing.Color.FromArgb(94, 76, 90);
            killTimeoutLabel.BackColor = System.Drawing.Color.FromArgb(94, 76, 90);
            setThemeLabel.BackColor = System.Drawing.Color.FromArgb(94, 76, 90);
            creditLabel.BackColor = System.Drawing.Color.FromArgb(94, 76, 90);
            creditLabel2.BackColor = System.Drawing.Color.FromArgb(94, 76, 90);

            setThemeTo1Button.Text = "Active Theme";
            setThemeTo2Button.Text = "Theme 2";
            setThemeTo3Button.Text = "Theme 3";
        }

        private void setThemeTo1Button_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(94, 76, 90);

            setSpeedTextBox.ForeColor = System.Drawing.Color.Black;
            setVisionTextBox.ForeColor = System.Drawing.Color.Black;
            setKillTimeoutTextBox.ForeColor = System.Drawing.Color.Black;

            setSpeedTextBox.BackColor = System.Drawing.Color.FromArgb(255, 226, 209);
            setVisionTextBox.BackColor = System.Drawing.Color.FromArgb(255, 226, 209);
            setKillTimeoutTextBox.BackColor = System.Drawing.Color.FromArgb(255, 226, 209);

            setSpeedButton.BackColor = System.Drawing.Color.FromArgb(225, 240, 196);
            setVisionCrewmateButton.BackColor = System.Drawing.Color.FromArgb(225, 240, 196);
            setKillTimeoutButton.BackColor = System.Drawing.Color.FromArgb(225, 240, 196);
            setThemeTo1Button.BackColor = System.Drawing.Color.FromArgb(225, 240, 196);
            setThemeTo2Button.BackColor = System.Drawing.Color.FromArgb(225, 240, 196);
            setThemeTo3Button.BackColor = System.Drawing.Color.FromArgb(225, 240, 196);

            speedLabel.ForeColor = System.Drawing.Color.FromArgb(107, 171, 144);
            visionLabel.ForeColor = System.Drawing.Color.FromArgb(107, 171, 144);
            killTimeoutLabel.ForeColor = System.Drawing.Color.FromArgb(107, 171, 144);
            setThemeLabel.ForeColor = System.Drawing.Color.FromArgb(107, 171, 144);
            creditLabel.ForeColor = System.Drawing.Color.FromArgb(107, 171, 144);
            creditLabel2.ForeColor = System.Drawing.Color.FromArgb(107, 171, 144);

            speedLabel.BackColor = System.Drawing.Color.FromArgb(94, 76, 90);
            visionLabel.BackColor = System.Drawing.Color.FromArgb(94, 76, 90);
            killTimeoutLabel.BackColor = System.Drawing.Color.FromArgb(94, 76, 90);
            setThemeLabel.BackColor = System.Drawing.Color.FromArgb(94, 76, 90);
            creditLabel.BackColor = System.Drawing.Color.FromArgb(94, 76, 90);
            creditLabel2.BackColor = System.Drawing.Color.FromArgb(94, 76, 90);

            setThemeTo1Button.Text = "Active Theme";
            setThemeTo2Button.Text = "Theme 2";
            setThemeTo3Button.Text = "Theme 3";
        }

        private void setThemeTo2Button_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(255, 192, 159);

            setSpeedTextBox.ForeColor = System.Drawing.Color.Black;
            setVisionTextBox.ForeColor = System.Drawing.Color.Black;
            setKillTimeoutTextBox.ForeColor = System.Drawing.Color.Black;

            setSpeedTextBox.BackColor = System.Drawing.Color.FromArgb(252, 245, 199);
            setVisionTextBox.BackColor = System.Drawing.Color.FromArgb(252, 245, 199);
            setKillTimeoutTextBox.BackColor = System.Drawing.Color.FromArgb(252, 245, 199);

            setSpeedButton.BackColor = System.Drawing.Color.FromArgb(225, 238, 147);
            setVisionCrewmateButton.BackColor = System.Drawing.Color.FromArgb(225, 238, 147);
            setKillTimeoutButton.BackColor = System.Drawing.Color.FromArgb(225, 238, 147);
            setThemeTo1Button.BackColor = System.Drawing.Color.FromArgb(225, 238, 147);
            setThemeTo2Button.BackColor = System.Drawing.Color.FromArgb(225, 238, 147);
            setThemeTo3Button.BackColor = System.Drawing.Color.FromArgb(225, 238, 147);

            speedLabel.ForeColor = System.Drawing.Color.FromArgb(173, 247, 182);
            visionLabel.ForeColor = System.Drawing.Color.FromArgb(173, 247, 182);
            killTimeoutLabel.ForeColor = System.Drawing.Color.FromArgb(173, 247, 182);
            setThemeLabel.ForeColor = System.Drawing.Color.FromArgb(173, 247, 182);
            creditLabel.ForeColor = System.Drawing.Color.FromArgb(173, 247, 182);
            creditLabel2.ForeColor = System.Drawing.Color.FromArgb(173, 247, 182);

            speedLabel.BackColor = System.Drawing.Color.FromArgb(255, 192, 159);
            visionLabel.BackColor = System.Drawing.Color.FromArgb(255, 192, 159);
            killTimeoutLabel.BackColor = System.Drawing.Color.FromArgb(255, 192, 159);
            setThemeLabel.BackColor = System.Drawing.Color.FromArgb(255, 192, 159);
            creditLabel.BackColor = System.Drawing.Color.FromArgb(255, 192, 159);
            creditLabel2.BackColor = System.Drawing.Color.FromArgb(255, 192, 159);

            setThemeTo1Button.Text = "Theme 1";
            setThemeTo2Button.Text = "Active Theme";
            setThemeTo3Button.Text = "Theme 3";
        }

        private void setThemeTo3Button_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(255, 155, 133);

            setSpeedTextBox.ForeColor = System.Drawing.Color.White;
            setVisionTextBox.ForeColor = System.Drawing.Color.White;
            setKillTimeoutTextBox.ForeColor = System.Drawing.Color.White;

            setSpeedTextBox.BackColor = System.Drawing.Color.FromArgb(238, 96, 85);
            setVisionTextBox.BackColor = System.Drawing.Color.FromArgb(238, 96, 85);
            setKillTimeoutTextBox.BackColor = System.Drawing.Color.FromArgb(238, 96, 85);

            setSpeedButton.BackColor = System.Drawing.Color.FromArgb(96, 211, 148);
            setVisionCrewmateButton.BackColor = System.Drawing.Color.FromArgb(96, 211, 148);
            setKillTimeoutButton.BackColor = System.Drawing.Color.FromArgb(96, 211, 148);
            setThemeTo1Button.BackColor = System.Drawing.Color.FromArgb(96, 211, 148);
            setThemeTo2Button.BackColor = System.Drawing.Color.FromArgb(96, 211, 148);
            setThemeTo3Button.BackColor = System.Drawing.Color.FromArgb(96, 211, 148);

            speedLabel.ForeColor = System.Drawing.Color.FromArgb(170, 246, 131);
            visionLabel.ForeColor = System.Drawing.Color.FromArgb(170, 246, 131);
            killTimeoutLabel.ForeColor = System.Drawing.Color.FromArgb(170, 246, 131);
            setThemeLabel.ForeColor = System.Drawing.Color.FromArgb(170, 246, 131);
            creditLabel.ForeColor = System.Drawing.Color.FromArgb(170, 246, 131);
            creditLabel2.ForeColor = System.Drawing.Color.FromArgb(170, 246, 131);

            speedLabel.BackColor = System.Drawing.Color.FromArgb(255, 155, 133);
            visionLabel.BackColor = System.Drawing.Color.FromArgb(255, 155, 133);
            killTimeoutLabel.BackColor = System.Drawing.Color.FromArgb(255, 155, 133);
            setThemeLabel.BackColor = System.Drawing.Color.FromArgb(255, 155, 133);
            creditLabel.BackColor = System.Drawing.Color.FromArgb(255, 155, 133);
            creditLabel2.BackColor = System.Drawing.Color.FromArgb(255, 155, 133);

            setThemeTo1Button.Text = "Theme 1";
            setThemeTo2Button.Text = "Theme 2";
            setThemeTo3Button.Text = "Active Theme";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Speed:
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("GameAssembly.dll+014B20F0,5C,14,14", "float", setSpeedTextBox.Text);
        }

        private void setVisionCrewmateButton_Click(object sender, EventArgs e)
        {
            // Vision:
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("GameAssembly.dll+014B20F0,5C,14,18", "float", setVisionTextBox.Text);
            memory.WriteMemory("GameAssembly.dll+014B20F0,5C,14,1C", "float", setVisionTextBox.Text);
        }

        private void setKillTimeoutButton_Click(object sender, EventArgs e)
        {
            // Kill Cooldown:
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("GameAssembly.dll+014B20F0,5C,14,20", "float", setKillTimeoutTextBox.Text);
        }
    }
}
