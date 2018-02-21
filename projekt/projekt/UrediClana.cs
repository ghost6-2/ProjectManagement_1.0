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
    public partial class UrediClana : Form
    {
        public UrediClana()
        {
            InitializeComponent();
            clanoviTableAdapter.Adapter.RowUpdated += Adapter_RowUpdated;
        }

        void Adapter_RowUpdated (object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e)
        {
            if(e.StatementType == StatementType.Insert)
            {
                var cmd = new OleDbCommand("SELECT @@IDENTITY", e.Command.Connection);
                var id = (int)cmd.ExecuteScalar();
                e.Row["ID"] = id;
                e.Row.AcceptChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var forma = new UrediClana();
            forma.Close();
        }

        private void UrediClana_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'izvjestajSet.Izvjestaj' table. You can move, or remove it, as needed.
            this.izvjestajTableAdapter.Fill(this.izvjestajSet.Izvjestaj);
            // TODO: This line of code loads data into the 'izvjestajSet.Clanovi' table. You can move, or remove it, as needed.
            this.clanoviTableAdapter.Fill(this.izvjestajSet.Clanovi);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clanoviBindingSource.EndEdit();
            clanoviTableAdapter.Update(izvjestajSet.Clanovi);
        }
    }
}
