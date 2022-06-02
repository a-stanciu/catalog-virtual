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
    public partial class AdaugareNota : Form
    {
        public int Nota { get; set; }
        public DateTime Data { get; set; }
        public AdaugareNota()
        {
            InitializeComponent();
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            this.Nota = Decimal.ToInt32(numNota.Value);
            this.Data = dtpData.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAnulare_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
