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
    public partial class UpisKorisnika : Form
    {
        public UpisKorisnika()
        {
            InitializeComponent();
        }

        private void UpisKorisnika_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'izvjestajSet.Login' table. You can move, or remove it, as needed.
            
            var red = izvjestajSet.Login.NewLoginRow();
            izvjestajSet.Login.AddLoginRow(red);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var forma = new UpisKorisnika();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginBindingSource.EndEdit();
            this.loginTableAdapter.Update(this.izvjestajSet.Login);
            Close();
        }
    }
}
