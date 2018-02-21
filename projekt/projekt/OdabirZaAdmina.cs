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
    public partial class OdabirZaAdmina : Form
    {
        public OdabirZaAdmina()
        {
            InitializeComponent();
        }

        private void btnClan_Click(object sender, EventArgs e)
        {
            var forma = new Clanovi();
            forma.ShowDialog();
        }

        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            var forma = new Izvjestaj();
            forma.ShowDialog();
        }
    }
}
