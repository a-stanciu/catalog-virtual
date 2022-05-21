using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PIUGlab2_4
{
    public partial class MainApp : Form
    {
        private List<Materie> materii = new List<Materie>();
        private String fisierPrincipal = Application.StartupPath + "\\Data\\data.bin";
        public MainApp()
        {
            InitializeComponent();

            citireFisier(fisierPrincipal);
        }

        private void reimprospatareLista()
        {
            lvMaterii.Items.Clear();

            foreach (var i in materii)
            {
                lvMaterii.Items.Add(i.Nume);
                lvMaterii.Items[lvMaterii.Items.Count - 1].SubItems.Add(i.NrInscrisi.ToString());
            }
        }

        private void citireFisier(String path)
        {
            if (File.Exists(path))
            {
                Stream openFileStream = File.OpenRead(path);
                BinaryFormatter deserializer = new BinaryFormatter();
                materii = (List<Materie>)deserializer.Deserialize(openFileStream);
                openFileStream.Close();
            }

            reimprospatareLista();
        }

        private void scriereFisier(String path)
        {
            Stream SaveFileStream = File.Create(path);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(SaveFileStream, materii);
            SaveFileStream.Close();
        }

        private void adaugareMaterie()
        {
            using (var f = new AdaugareMaterie())
            {
                var result = f.ShowDialog();
                if (result == DialogResult.OK)
                {
                    foreach (var i in materii)
                    {
                        if (i.Nume == f.Nume)
                        {
                            MessageBox.Show("Materia există deja.", "Eroare");
                            return;
                        }
                    }
                    materii.Add(new Materie(f.Nume));
                    reimprospatareLista();
                }
            }
        }

        private void stergereMaterie()
        {
            if (lvMaterii.SelectedItems.Count == 0)
            {
                MessageBox.Show("Cel puțin o materie trebuie selectată pentru ștergere.", "Eroare");
                return;
            }

            List<Materie> sterse = new List<Materie>();

            foreach (ListViewItem i in lvMaterii.SelectedItems)
            {
                foreach (var j in materii)
                {
                    if (i.Text == j.Nume)
                    {
                        using (var f = new ConfirmareStergere(j.Nume, "materie"))
                        {
                            if (f.ShowDialog() == DialogResult.OK)
                            {
                                sterse.Add(j);
                            }
                        }
                    }
                }
            }

            foreach (var i in sterse)
            {
                materii.Remove(i);
            }

            reimprospatareLista();
        }

        private void vizualizareMaterie()
        {
            foreach (Materie i in materii)
            {
                if (i.Nume == lvMaterii.SelectedItems[0].Text)
                {
                    DetaliiMaterie f = new DetaliiMaterie(i);
                    f.ShowDialog();
                    break;
                }
            }

            reimprospatareLista();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown)
                return;

            using (var f = new ConfirmareIesire())
            {
                switch (f.ShowDialog())
                {
                    case DialogResult.Yes:
                        scriereFisier(fisierPrincipal);
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void adăugareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adaugareMaterie();
        }

        private void ștergereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stergereMaterie();
        }

        private void citireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            citireFisier(fisierPrincipal);
        }

        private void scriereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scriereFisier(fisierPrincipal);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reimprospatareLista();
        }

        private void ieșireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItemAdaugare_Click(object sender, EventArgs e)
        {
            adaugareMaterie();
        }

        private void toolStripMenuItemStergere_Click(object sender, EventArgs e)
        {
            stergereMaterie();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lvMaterii.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selectați o materie.", "Eroare");
            }
            else if (lvMaterii.SelectedItems.Count > 1)
            {
                MessageBox.Show("Selectați o singură materie.", "Eroare");
            }
            else
            {
                vizualizareMaterie();
            }
        }

        private void lvMaterii_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            vizualizareMaterie();
        }

        private void obținețiAjutorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
