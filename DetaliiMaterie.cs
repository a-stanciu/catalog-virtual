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
                        lvNote.Items.Add(n.Nota.ToString());
                        lvNote.Items[lvNote.Items.Count - 1].SubItems.Add(n.Data.ToString());
                    }
                    break;
                }
            }
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

            foreach (var i in mat.StudentiInscrisi)
            {
                if (i.Nume == lbStudenti.Text)
                {
                    using (var f = new ConfirmareStergere(i.Nume, "student"))
                    {
                        if (f.ShowDialog() == DialogResult.OK)
                        {
                            mat.stergereStudent(i);
                            break;
                        }
                    }
                }
            }

            reimprospatareStudenti();
        }

        private void btnAdaugMat_Click(object sender, EventArgs e)
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
                    mat.adaugareNota(lbStudenti.Text, f.Nota, f.Data);

                    reimprospatareNote();
                }
            }
        }

        private void btnStergMat_Click(object sender, EventArgs e)
        {
            //mat.stergereNota(lbStudenti.Text, new DateTime(lvNote.SelectedItems[0].Text));

            reimprospatareNote();
        }

        private void lbStudenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            reimprospatareNote();
        }
    }
}
