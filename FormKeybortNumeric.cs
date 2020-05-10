using SampleApplication.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleApplication
{
    public partial class FormKeybortNumeric : Form
    {
        public FormKeybortNumeric()
        {
            InitializeComponent();
        }

        private void TB_result_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TB_result.Text += "1";
        }

        private void but2_Click(object sender, EventArgs e)
        {
            TB_result.Text += "2";
        }

        private void but3_Click(object sender, EventArgs e)
        {
            TB_result.Text += "3";
        }

        internal void setManager(Manager _manager)
        {
            manager = _manager;
            if (manager.getNumber() != "")
            {
                TB_result.Text = manager.getNumber();
            }
        }

        private void but4_Click(object sender, EventArgs e)
        {
            TB_result.Text += "4";
        }

        private void but5_Click(object sender, EventArgs e)
        {
            TB_result.Text += "5";
        }

        private void but6_Click(object sender, EventArgs e)
        {
            TB_result.Text += "6";
        }

        private void but7_Click(object sender, EventArgs e)
        {
            TB_result.Text += "7";
        }

        private void but8_Click(object sender, EventArgs e)
        {
            TB_result.Text += "8";
        }

        private void but9_Click(object sender, EventArgs e)
        {
            TB_result.Text += "9";
        }

        private void but0_Click(object sender, EventArgs e)
        {
            TB_result.Text += "0";
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            if (TB_result.TextLength >= 1)
            {
                 TB_result.Text= TB_result.Text.Remove(TB_result.TextLength - 1, 1); //delete the last character
            }
            else
            {
                TB_result.Text = "";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TB_result.Text = "";
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            manager.setNumber(TB_result.Text);
            this.Close();
        }

        private void butCanel_Click(object sender, EventArgs e)
        {
            manager.setNumber("");
            this.Close();
        }
    }
}
