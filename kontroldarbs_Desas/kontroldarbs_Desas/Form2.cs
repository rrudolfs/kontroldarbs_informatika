﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kontroldarbs_Desas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void AizvertPoga2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 virsraksts = new Form1();
            virsraksts.Show();
        }
    }
}
