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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaktPoga_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 sakt = new Form2();
            sakt.Show();

        }

        private void AizvertPoga_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InformacijaPoga_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desas ir 2 spēlētāju spēle, kurā mērķis ir savu simbolu ievietot 3 blakusesošos kvadrātos.\n" +
                "Spēlētājs uzvar ja ievieto 3 savus simbolus pēc kārtas vertikālā, horizontālā vai diagonālā virzienā.\n" +
                "Ja otrs spēlētājs jau savu simbolu kvadrātā jau ir ievietojis, tad savu simbolu tur vairs ievietot nevar.\n" +
                "Ja pēc 9 gājieniem neviens nav uzvarējis, ir neizšķirts\n\n" +
                "Veidojis Rūdolfs Rudmiezis 2022. gadā.", "Informācija par spēli");
        }
    }
}
