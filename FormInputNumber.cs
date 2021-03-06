﻿using SampleApplication.SQL;
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
    public partial class FormInputNumber : Form
    {
        public FormInputNumber()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            manager.setNumber("");
            this.Close();
        }


        private void TB_Number_MouseDown(object sender, MouseEventArgs e)
        {
            FormNumericKeyboard formKeybortNumeric = new FormNumericKeyboard();
            formKeybortNumeric.setManager(this.manager);
            formKeybortNumeric.Show();
        }

        private void FormInputNumber_Activated(object sender, EventArgs e)
        {
            if (manager.getNumber() != "")
            {
                TB_Number.Text = manager.getNumber();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
