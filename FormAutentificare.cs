using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PIUGlab2_4
{
    public partial class FormAutentificare : Form
    {
        List<Users> u = new List<Users>();

        public FormAutentificare()
        {
            InitializeComponent();
        }

        private void reimprospatareUtilizatori()
        {
            String filePath = Application.StartupPath + "\\Data\\users";

            cbNume.Items.Clear();
            u.Clear();

            if (File.Exists(filePath))
            {
                using (StreamReader file = new StreamReader(filePath))
                {
                    while (file.Peek() >= 0)
                    {
                        String line = file.ReadLine();
                        String[] entries = line.Split(':');
                        u.Add(new Users(entries[0], entries[1]));
                    }
                }
            }

            u.Sort((a, b) => a.Name.CompareTo(b.Name));

            foreach (var i in u)
            {
                cbNume.Items.Add(i.Name);
            }
        }

        private void FormAutentificare_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(Application.StartupPath + "\\Data"))
            {
                MessageBox.Show("Directorul \"Data\" nu a fost găsit. Acesta conține fișiere necesare rulării " +
                    "aplicației și trebuie să se afle în același director cu fișierul executabil. Verificați " +
                    "dacă a fost redenumit sau reinstalați aplicația.", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                Application.Exit();
            }

            reimprospatareUtilizatori();
        }

        private void linkInregistrare_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormInregistrare f = new FormInregistrare();
            f.ShowDialog();
            reimprospatareUtilizatori();
        }

        private void btnAutentificare_Click(object sender, EventArgs e)
        {
            foreach (var i in u)
            {
                if (i.Name == cbNume.Text && i.CheckPassword(tbParola.Text))
                {
                    this.Hide();
                    tbParola.Clear();
                    MainApp f = new MainApp();
                    f.ShowDialog();
                    Application.Exit();
                    return;
                }
            }

            MessageBox.Show("Numele de utilizator sau parola nu sunt corecte.", "Eroare");
            tbParola.Clear();
        }
    }
}
