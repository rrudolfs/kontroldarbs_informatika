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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            AizvertPoga2.Enabled = true;
        }

        private void AizvertPoga2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 sakt = new Form2();
            sakt.Show();
        }

        private void ApsveikumaUzraksts_Click(object sender, EventArgs e)
        {

        }
    }
}
