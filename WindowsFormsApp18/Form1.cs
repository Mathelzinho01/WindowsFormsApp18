﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIMC_Click(object sender, EventArgs e)
        {
            IMCForm imcForm = new IMCForm();
            imcForm.Show();
        }

        private void btnFormas_Click(object sender, EventArgs e)
        {
            FormasForm formasForm = new FormasForm();
            formasForm.Show();
        }
    }
}
