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
    public partial class UnosAuta : Form
    {
        private Lokacije odabranaLokacija;
        private bool kuka;

        public bool Kuka { get => kuka; set => kuka = value; }

        public UnosAuta(Lokacije lokacija)
        {
            InitializeComponent();
            odabranaLokacija = lokacija;
        }

        private void UnosAuta_Load(object sender, EventArgs e)
        {
            for(int i = 1970; i <= 2018; i++)
            {
                cbGodiste.Items.Add(i);
            }
            rbNe.Checked = true;
            PopuniComboBox();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (rbDa.Checked == true)
            {
                kuka = true;
            }
            else
            {
                kuka = false;
            }
            using (var db = new NajamAutaEntities())
            {
                db.Lokacije.Attach(odabranaLokacija);
                Vozila vozilo = new Vozila
                {
                    Marka = tbMarka.Text,
                    Model = tbModel.Text,
                    Godiste = int.Parse(cbGodiste.SelectedValue.ToString()),
                    Gorivo = cbGorivo.SelectedValue.ToString(),
                    Registracija = tbRegistracija.Text,
                    Kuka = kuka,
                    Lokacija = int.Parse(cbLokacija.ValueMember.ToString())
                };
                db.Vozila.Add(vozilo);
                db.SaveChanges();
            }
            Close();
        }

        private void PopuniComboBox()
        {
            BindingList<Lokacije> lista = null;
            using (var db = new NajamAutaEntities())
            {
                lista = new BindingList<Lokacije>(db.Lokacije.ToList());
            }
            cbLokacija.DataSource = lista;
        }
    }
}
