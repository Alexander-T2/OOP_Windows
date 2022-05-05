using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (footTextBox.Text == "" && yardTextBox.Text != "")
            {
                try
                {
                    footTextBox.Text = Convert.ToString(Convert.ToDouble(yardTextBox.Text) * 3);
                    yardTextBox.Text = "";
                }
                catch
                {
                    MessageBox.Show("Ошибка в вводе данных", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    footTextBox.Text = "";
                    yardTextBox.Text = "";
                }
            }
            else if(footTextBox.Text != "" && yardTextBox.Text == "")
            {
                try
                {
                    yardTextBox.Text = Convert.ToString(Convert.ToDouble(footTextBox.Text) / 3);
                    footTextBox.Text = "";
                }
                catch
                {
                    MessageBox.Show("Ошибка в вводе данных", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    footTextBox.Text = "";
                    yardTextBox.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Ровно одно поле полное", "Вообще-то", MessageBoxButtons.OK, MessageBoxIcon.Information);
                footTextBox.Text = "";
                yardTextBox.Text = "";
            }
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            footTextBox.Text = "";
            yardTextBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
