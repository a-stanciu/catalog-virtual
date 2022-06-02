using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace PIUGlab2_4
{
    public partial class FormInregistrare : Form
    {
        private bool numeOk = false, parolaOk = false, confirmParolaOk = false;
        public FormInregistrare()
        {
            InitializeComponent();
        }

        private void txtNume_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(txtNume.Text, "^[a-zA-Z' -]*$").Success)
            {
                errNume.SetError(txtNume, "Numele nu este introdus corect.");
                numeOk = false;
            }
            else
            {
                errNume.Clear();
                numeOk = true;
            }
            activBtnInregistrare();
        }

        private void txtParola_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(txtParola.Text, "^(?=.*[0-9])(?=.*[a-zA-Z]).{8,}$").Success)
            {
                errParola.SetError(txtParola, "Parola nu îndeplinește cerințele minime.");
                parolaOk = false;
            }
            else
            {
                errParola.Clear();
                parolaOk = true;
            }
            activBtnInregistrare();
            txtConfirmParola_TextChanged(sender, e);
        }

        private void txtConfirmParola_TextChanged(object sender, EventArgs e)
        {
            if (txtParola.Text != txtConfirmParola.Text)
            {
                errConfirmParola.SetError(txtConfirmParola, "Parolele nu se potrivesc.");
                confirmParolaOk = false;
            }
            else
            {
                errConfirmParola.Clear();
                confirmParolaOk = true;
            }
            activBtnInregistrare();
        }

        private void activBtnInregistrare()
        {
            btnInregistrare.Enabled = numeOk && parolaOk && confirmParolaOk;
        }

        private void btnInregistrare_Click(object sender, EventArgs e)
        {
            using (FileStream file = new FileStream(Application.StartupPath + "\\Data\\users",
                                                    FileMode.Append,
                                                    FileAccess.Write))
            {
                var writer = new StreamWriter(file);
                writer.WriteLine(txtNume.Text + ":" + txtParola.Text);
                writer.Close();
                MessageBox.Show("Utilizatorul a fost înregistrat.", "Succes");
                this.Close();
            }
        }
    }
}
