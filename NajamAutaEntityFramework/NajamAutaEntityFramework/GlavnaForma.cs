using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NajamAutaEntityFramework
{
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
        }

        private void btnLokacije_Click(object sender, EventArgs e)
        {
            PopisLokacija forma = new PopisLokacija();
            forma.ShowDialog();
        }
    }
}
