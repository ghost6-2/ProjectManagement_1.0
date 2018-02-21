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
    public partial class PregledZaKorisnika : Form
    {
        public PregledZaKorisnika()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var forma = new PregledClanova();
            forma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var forma = new IzvjestajForma();
            forma.ShowDialog();
        }
    }
}
