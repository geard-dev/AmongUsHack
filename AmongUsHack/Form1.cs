﻿using System;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("GameAssembly.dll+0144A9D0,5C,14,14", "float", setSpeedTextBox.Text);
        }

        private void setVisionCrewmateButton_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("GameAssembly.dll+0144A9D0,5C,14,18", "float", setVisionTextBox.Text);
        }

        private void setVisionImpostorButton_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("GameAssembly.dll+0144A9D0,5C,14,1C", "float", setVisionTextBox.Text);
        }

        private void setKillTimeoutButton_Click(object sender, EventArgs e)
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            memory.WriteMemory("GameAssembly.dll+0144A9D0,5C,14,20", "float", setKillTimeoutTextBox.Text);
        }
    }
}
