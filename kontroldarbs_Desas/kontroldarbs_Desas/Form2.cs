using System;
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
        bool gajiens = true;//ja gajiens ir true iet 1. speletajs(X), ja gajiens ir false iet 2. speletajs(O).

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

        private void A1_Click(object sender, EventArgs e)
        {
            if (gajiens == true)
            {
                A1.Text = "X";
                gajiens = false;
            }
            else if (gajiens == false)
            {
                A1.Text = "O";
                gajiens = true;
            }
            A1.Enabled = false;//lai otrs spēlētājs nevarētu savu figūru uzlikt virsu.
        }

        private void A2_Click(object sender, EventArgs e)
        {
            if (gajiens == true)
            {
                A2.Text = "X";
                gajiens = false;
            }
            else if (gajiens == false)
            {
                A2.Text = "O";
                gajiens = true;
            }
            A2.Enabled = false;
        }

        private void A3_Click(object sender, EventArgs e)
        {
            if (gajiens == true)
            {
                A3.Text = "X";
                gajiens = false;
            }
            else if (gajiens == false)
            {
                A3.Text = "O";
                gajiens = true;
            }
            A3.Enabled = false;
        }
        private void B1_Click(object sender, EventArgs e)
        {
            if (gajiens == true)
            {
                B1.Text = "X";
                gajiens = false;
            }
            else if (gajiens == false)
            {
                B1.Text = "O";
                gajiens = true;
            }
            B1.Enabled = false;
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (gajiens == true)
            {
                B2.Text = "X";
                gajiens = false;
            }
            else if (gajiens == false)
            {
                B2.Text = "O";
                gajiens = true;
            }
            B2.Enabled = false;
        }
        private void B3_Click(object sender, EventArgs e)
        {
            if (gajiens == true)
            {
                B3.Text = "X";
                gajiens = false;
            }
            else if (gajiens == false)
            {
                B3.Text = "O";
                gajiens = true;
            }
            B3.Enabled = false;
        }
        private void C1_Click(object sender, EventArgs e)
        {
            if (gajiens == true)
            {
                C1.Text = "X";
                gajiens = false;
            }
            else if (gajiens == false)
            {
                C1.Text = "O";
                gajiens = true;
            }
            C1.Enabled = false;
        }
        private void C2_Click(object sender, EventArgs e)
        {
            if (gajiens == true)
            {
                C2.Text = "X";
                gajiens = false;
            }
            else if (gajiens == false)
            {
                C2.Text = "O";
                gajiens = true;
            }
            C2.Enabled = false;
        }
        private void C3_Click(object sender, EventArgs e)
        {
            if (gajiens == true)
            {
                C3.Text = "X";
                gajiens = false;
            }
            else if (gajiens == false)
            {
                C3.Text = "O";
                gajiens = true;
            }
            C3.Enabled = false;
        }
    }//beigas public partial class
}//beigas namespace
