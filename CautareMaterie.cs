using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIUGlab2_4
{
    public partial class CautareMaterie : Form
    {
        List<Materie> materii;
        public CautareMaterie(List<Materie> materii)
        {
            InitializeComponent();
            this.materii = materii;
        }

        private void btnAnulare_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCautare_Click(object sender, EventArgs e)
        {
            if (tbMaterie.Text == String.Empty)
            {
                MessageBox.Show("Numele materiei nu poate fi gol.", "Eroare");
            }

            foreach (var i in materii)
            {
                if (i.Nume == tbMaterie.Text)
                {
                    using (DetaliiMaterie f = new DetaliiMaterie(i))
                    {
                        f.ShowDialog();
                        this.Close();
                    }
                    return;
                }
            }

            MessageBox.Show("Materia nu a fost găsită.", "Eroare");
            tbMaterie.Clear();
            tbMaterie.Select();
        }
    }
}
