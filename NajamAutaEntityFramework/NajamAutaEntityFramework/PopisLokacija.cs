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
    public partial class PopisLokacija : Form
    {
        public PopisLokacija()
        {
            InitializeComponent();
        }

        public void PrikaziLokacije()
        {
            BindingList<Lokacije> lista = null;
            using (var db = new NajamAutaEntities())
            {
                lista = new BindingList<Lokacije>(db.Lokacije.ToList());
            }
            lokacijeBindingSource.DataSource = lista;
        }

        public void PrikaziVozila(Lokacije lokacija)
        {
            BindingList<Vozila> lista = null;
            using (var db = new NajamAutaEntities())
            {
                db.Lokacije.Attach(lokacija);
                lista = new BindingList<Vozila>(lokacija.Vozila.ToList<Vozila>());
            }
            vozilaBindingSource.DataSource = lista;
        }

        private void PopisLokacija_Load(object sender, EventArgs e)
        {
            PrikaziLokacije();
            PrikaziVozila(lokacijeBindingSource.Current as Lokacije);
        }

        private void dgvLokacije_SelectionChanged(object sender, EventArgs e)
        {
            PrikaziVozila(lokacijeBindingSource.Current as Lokacije);
        }

        private void btnNoviAuto_Click(object sender, EventArgs e)
        {
            UnosAuta forma = new UnosAuta(lokacijeBindingSource.Current as Lokacije);
            forma.ShowDialog();
            PrikaziVozila(lokacijeBindingSource.Current as Lokacije);
        }

        private void btnNovaLokacija_Click(object sender, EventArgs e)
        {
            UnosLokacije forma = new UnosLokacije();
            forma.ShowDialog();
        }
    }
}
