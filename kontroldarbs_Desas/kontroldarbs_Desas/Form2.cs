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
        bool uzvara = false;
        int skaits = 0;
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
            skaits++;
            parbaude();
            
            
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
            skaits++;
            parbaude();
            
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
            skaits++;
            parbaude();
            
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
            skaits++;
            parbaude();
            
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
            skaits++;
            parbaude();
            
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
            skaits++;
            parbaude();
            
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
            skaits++;
            parbaude();
            
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
            skaits++;
            parbaude();
            
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
            skaits++;
            parbaude();
            
        }

        private void parbaude()
        {
            if ((A1.Text == A2.Text)&& (A2.Text == A3.Text) && (A1.Enabled == false) && (A2.Enabled == false) && (A3.Enabled == false))
            {
                uzvara = true;
            }
            if ((B1.Text == B2.Text)&& (B2.Text == B3.Text) && (B1.Enabled == false) && (B2.Enabled == false) && (B3.Enabled == false))
            {
                uzvara = true;
            }
            if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (C1.Enabled == false) && (C2.Enabled == false) && (C3.Enabled == false))
            {
                uzvara = true;
            }
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (A1.Enabled == false) && (B1.Enabled == false) && (C1.Enabled == false))
            {
                uzvara = true;
            }
            if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (A2.Enabled == false) && (B2.Enabled == false) && (C2.Enabled == false))
            {
                uzvara = true;
            }
            if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (A3.Enabled == false) && (B3.Enabled == false) && (C3.Enabled == false))
            {
                uzvara = true;
            }
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (A1.Enabled == false) && (B2.Enabled == false) && (C3.Enabled == false))
            {
                uzvara = true;
            }
            if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (A3.Enabled == false) && (B2.Enabled == false) && (C1.Enabled == false))
            {
                uzvara = true;
            }


            if((uzvara == true)&&(gajiens==true))
            {
                this.Hide();
                Form3 apsveikums1 = new Form3();
                apsveikums1.Show();
            }
            if ((uzvara == true) && (gajiens == false))
            {
                this.Hide();
                Form4 apsveikums2 = new Form4();
                apsveikums2.Show();
            }
            if ((skaits == 9)&&(uzvara==false))
            {
                this.Hide();
                Form5 neizskirts = new Form5();
                neizskirts.Show();
            }
        }


       




    }//beigas public partial class
}//beigas namespace
