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
    public partial class PregledClanova : Form
    {
        public PregledClanova()
        {
            InitializeComponent();
        }

        private void PregledClanova_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'izvjestajSet.Clanovi' table. You can move, or remove it, as needed.
            this.clanoviTableAdapter.Fill(this.izvjestajSet.Clanovi);

        }
    }
}
