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
    public partial class DetaliiMaterie : Form
    {
        private Materie mat;
        public DetaliiMaterie(Materie m)
        {
            InitializeComponent();
            mat = m;
        }

        private void DetaliiMaterie_Load(object sender, EventArgs e)
        {
            this.Text += mat.Nume;
            reimprospatareStudenti();
        }

        private void reimprospatareStudenti()
        {
            lbStudenti.Items.Clear();

            mat.StudentiInscrisi.Sort((a, b) => a.Nume.CompareTo(b.Nume));

            foreach (var i in mat.StudentiInscrisi)
            {
                lbStudenti.Items.Add(i.Nume);
            }

            tbNrInscrisi.Text = mat.NrInscrisi.ToString();
        }

        private void reimprospatareNote()
        {
            lvNote.Items.Clear();
            foreach (var i in mat.StudentiInscrisi)
            {
                if (i.Nume == lbStudenti.Text)
                {
                    foreach (var n in i.Note)
                    {
                        lvNote.Items.Add(n.Data);
                        lvNote.Items[lvNote.Items.Count - 1].SubItems.Add(n.Nota.ToString());
                    }
                    break;
                }
            }

            var media = mat.calculMedie(lbStudenti.Text);
            tbMedia.Text = (media == -1) ? String.Empty : media.ToString();
        }

        private void btnAdaugStud_Click(object sender, EventArgs e)
        {
            using (var f = new AdaugareStudent())
            {
                var result = f.ShowDialog();
                if (result == DialogResult.OK)
                {
                    mat.adaugareStudent(f.Nume);
                    reimprospatareStudenti();
                }
            }
        }

        private void btnStergStud_Click(object sender, EventArgs e)
        {
            if (lbStudenti.Items.Count == 0)
            {
                MessageBox.Show("Cel puțin un student trebuie selectat.", "Eroare");
                return;
            }

            mat.stergereStudent(lbStudenti.Text);

            reimprospatareStudenti();
        }

        private void lbStudenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            reimprospatareNote();
        }

        private void btnAdaugNot_Click(object sender, EventArgs e)
        {
            if (lbStudenti.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selectați studentul pe care doriți să îl notați.", "Eroare");
                return;
            }

            using (var f = new AdaugareNota())
            {
                var result = f.ShowDialog();
                if (result == DialogResult.OK)
                {
                    mat.adaugareNota(lbStudenti.Text, f.Nota, f.Data.ToShortDateString());

                    reimprospatareNote();
                }
            }
        }

        private void btnStergNot_Click(object sender, EventArgs e)
        {
            if (lvNote.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selectați nota pe care doriți să o ștergeți.", "Eroare");
                return;
            }

            mat.stergereNota(lbStudenti.Text, lvNote.SelectedItems[0].Text);

            reimprospatareNote();
        }
    }
}
