using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIUGlab2_4
{
    public partial class AdaugareStudent : Form
    {
        public String Nume { get; set; }
        public AdaugareStudent()
        {
            InitializeComponent();
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            if (tbNume.Text == "")
            {
                MessageBox.Show("Numele materiei trebuie completat.", "Eroare");
                tbNume.Select();
                return;
            }
            else if (!Regex.Match(tbNume.Text, "^[a-zA-Z' -]*$").Success)
            {
                MessageBox.Show("Numele nu este introdus corect.", "Eroare");
                tbNume.Select();
                return;
            }

            this.Nume = tbNume.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAnulare_Click(object sender, EventArgs e)
        {
            this.Nume = null;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
