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
    public partial class Clanovi : Form
    {
        public Clanovi()
        {
            InitializeComponent();
            
        }

        private void Clanovi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'izvjestajSet.Clanovi' table. You can move, or remove it, as needed.
            this.clanoviTableAdapter.Fill(this.izvjestajSet.Clanovi);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var forma = new NoviClan();
            forma.Id = 0;
            var rezultat = forma.ShowDialog();
            if (rezultat == DialogResult.OK)
            {
                this.clanoviTableAdapter.Fill(this.izvjestajSet.Clanovi);
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var forma = new NoviClan();
            forma.Id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            var rezultat = forma.ShowDialog();
            if (rezultat == DialogResult.OK)
            {
                this.clanoviTableAdapter.Fill(this.izvjestajSet.Clanovi);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Obrisati zapis?", "Upit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                izvjestajSet.Clanovi[dataGridView1.CurrentRow.Index].Delete();
                clanoviTableAdapter.Update(izvjestajSet.Clanovi);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clanoviTableAdapter.FillBy(this.izvjestajSet.Clanovi, prezimeToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
