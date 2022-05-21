using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void FormAutentificare_Load(object sender, EventArgs e)
        {
            XmlReader reader = XmlReader.Create(Application.StartupPath + "\\users.xml");
            while (reader.Read())
            {
                if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "user"))
                {
                    if (reader.HasAttributes)
                    {
                        u.Add(new Users(reader.GetAttribute("name"), reader.GetAttribute("password")));
                    }
                }
            }

            foreach (var i in u)
            {
                cbNume.Items.Add(i.Name);
            }
        }

        private void linkInregistrare_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormInregistrare f = new FormInregistrare();
            f.ShowDialog();
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
