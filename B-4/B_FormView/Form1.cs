﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_FormView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnModal_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.setText = this.btnModal.Text + "실행";
            frm2.ShowDialog();
        }

        private void btnModaless_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.setText = this.btnModaless.Text = "실행";
            frm3.Show();
        }
    }
}
