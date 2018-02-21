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
    public partial class Izvjestaj : Form
    {
        public Izvjestaj()
        {
            InitializeComponent();
        }

        private void Izvjestaj_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'izvjestajSet.Izvjestaj' table. You can move, or remove it, as needed.
            this.izvjestajTableAdapter.Fill(this.izvjestajSet.Izvjestaj);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var forma = new NoviPodaci();
            forma.Id = 0;
            var rezultat = forma.ShowDialog();
            if (rezultat == DialogResult.OK)
            {
                this.izvjestajTableAdapter.Fill(this.izvjestajSet.Izvjestaj);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var forma = new NoviPodaci();
            forma.Id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            var rezultat = forma.ShowDialog();
            if (rezultat == DialogResult.OK)
            {
                this.izvjestajTableAdapter.Fill(this.izvjestajSet.Izvjestaj);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Obrisati zapis?", "Upit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                izvjestajSet.Izvjestaj[dataGridView1.CurrentRow.Index].Delete();
                izvjestajTableAdapter.Update(izvjestajSet.Izvjestaj);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            var forma = new IzvjestajForma();
            forma.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
    
}
