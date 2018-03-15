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
    public partial class UnosLokacije : Form
    {
        public UnosLokacije()
        {
            InitializeComponent();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new NajamAutaEntities())
            {
                Lokacije l = new Lokacije()
                {
                    Zupanija = zupanijaTextBox.Text,
                    Grad = gradTextBox.Text,
                    Adresa = adresaTextBox.Text
                };
                db.Lokacije.Add(l);
                db.SaveChanges();
            }
            Close();
        }
    }
}
