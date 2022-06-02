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
    public partial class Despre : Form
    {
        public Despre()
        {
            InitializeComponent();
        }

        private void copiereClipboard()
        {
            Clipboard.SetText(lblVersiune.Text + "\n" + lblInstalat.Text + "\n" + lblSO.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Despre_Load(object sender, EventArgs e)
        {
            lblVersiune.Text = "1.0";
            lblInstalat.Text = Application.StartupPath;
            lblSO.Text = Environment.OSVersion.ToString();
        }

        private void copiereÎnClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblVersiune.Text + "\n" + lblInstalat.Text + "\n" + lblSO.Text);
        }
    }
}
