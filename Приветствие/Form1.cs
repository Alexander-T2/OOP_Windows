﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;  
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Приветствие
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GayButton_Click(object sender, EventArgs e)
        {
            if(textBox.Text == "")
            {
                label1.Text = "神はこの美しい世界を祝福します!";
            }
            else
            {
                label1.Text = $"こんにちは, {textBox.Text}!";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
