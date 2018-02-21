using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt
{
    public partial class UrediPodatke : Form
    {
        public UrediPodatke()
        {
            InitializeComponent();
            izvjestajTableAdapter.Adapter.RowUpdated += Adapter_RowUpdated;
        }

        void Adapter_RowUpdated(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e)
        {
            if (e.StatementType == StatementType.Insert)
            {
                var cmd = new OleDbCommand("SELECT @@IDENTITY", e.Command.Connection);
                var id = (int)cmd.ExecuteScalar();
                e.Row["ID"] = id;
                e.Row.AcceptChanges();
            }
        }


        private void UrediPodatke_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'izvjestajSet.Clanovi' table. You can move, or remove it, as needed.
            this.clanoviTableAdapter.Fill(this.izvjestajSet.Clanovi);
            // TODO: This line of code loads data into the 'izvjestajSet.Izvjestaj' table. You can move, or remove it, as needed.
            this.izvjestajTableAdapter.Fill(this.izvjestajSet.Izvjestaj);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            izvjestajBindingSource.EndEdit();
            izvjestajTableAdapter.Update(izvjestajSet.Izvjestaj);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var forma = new UrediPodatke();
            forma.Close();
        }
    }
}
