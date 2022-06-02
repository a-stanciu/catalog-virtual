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
                    materii.Sort((a, b) => a.Nume.CompareTo(b.Nume));
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
            try
            {
                System.Diagnostics.Process.Start(Application.StartupPath + "\\Data\\PIUGHelp.html");
            }
            catch(Win32Exception)
            {
                MessageBox.Show("Fișierul \"PIUGHelp.html\" nu a fost găsit în directorul \"Data\". " +
                    "Verificați dacă acesta a fost redenumit sau reinstalați programul.", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scriereFisier(fisierPrincipal);
            MessageBox.Show("Datele au fost salvate.", "Succes");
        }

        private void ărileEfectuateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            citireFisier(fisierPrincipal);
        }

        private void importareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Fișiere bin (*.bin)|*.bin|Toate fișierele (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    citireFisier(filePath);
                }
            }
        }

        private void exportareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "Fișiere bin (*.bin)|*.bin|Toate fișierele (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog.FileName;

                    scriereFisier(filePath);
                }
            }
        }

        private void despreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Despre f = new Despre();
            f.ShowDialog();
        }

        private void căutareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CautareMaterie f = new CautareMaterie(materii);
            f.ShowDialog();
        }
    }
}
