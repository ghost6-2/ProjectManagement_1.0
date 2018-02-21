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
    public partial class LoginForma : Form
    {
        public LoginForma()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginTableAdapter.FillByUserPass(izvjestajSet.Login, txtUser.Text, txtPass.Text);
            if(izvjestajSet.Login.Count > 0)
            {
                if(izvjestajSet.Login[0].admin == true)
                {
                    var forma = new OdabirZaAdmina();
                    forma.ShowDialog();
                }
                else
                {
                    var forma = new PregledZaKorisnika();
                    forma.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Krivo korisničko ime ili lozinka!");
            }
        }

        private void btnNoviKor_Click(object sender, EventArgs e)
        {
            var forma = new UpisKorisnika();
            forma.ShowDialog();
        }

        private void LoginForma_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'izvjestajSet.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.izvjestajSet.Login);

        }
    }
}
