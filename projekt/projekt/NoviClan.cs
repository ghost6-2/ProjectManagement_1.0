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
    public partial class NoviClan : Form
    {
        public NoviClan()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            Close();
        }

        private void NoviClan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'izvjestajSet.Clanovi' table. You can move, or remove it, as needed.
            if (Id == 0)
            {
                var red = izvjestajSet.Clanovi.NewClanoviRow();
                izvjestajSet.Clanovi.AddClanoviRow(red);
            }
            else
            {
                clanoviTableAdapter.FillById(izvjestajSet.Clanovi,Id);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Polja niste unijeli! Pregledajte i ispravite grešku!");
            }
            else
            {
                clanoviBindingSource.EndEdit();
                clanoviTableAdapter.Update(izvjestajSet.Clanovi);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        public int Id;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8)
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
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = char.IsNumber(e.KeyChar) || e.KeyChar == 8 ? false : true;
        }
    }
}
