using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt
{
    public partial class NoviPodaci : Form
    {
        public NoviPodaci()
        {
            InitializeComponent();
        }

        private void NoviPodaci_Load(object sender, EventArgs e)
        {
            if (Id == 0)
            {
                var red = izvjestajSet.Izvjestaj.NewIzvjestajRow();
                izvjestajSet.Izvjestaj.AddIzvjestajRow(red);
            }
            else
            {
                izvjestajTableAdapter.FillByID(izvjestajSet.Izvjestaj, Id);
            }

        }
        public int Id;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Polja niste unijeli! Pregledajte i ispravite grešku!");
            }
            else
            {
                izvjestajBindingSource.EndEdit();
                izvjestajTableAdapter.Update(izvjestajSet.Izvjestaj);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var unos = Console.ReadLine();

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar) || e.KeyChar==8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar) || e.KeyChar == 8 ? false : true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar) || e.KeyChar == 8 ? false : true;
        }
    }
    
}
