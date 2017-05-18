using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wizbuotomasyon
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        wizbudatabaseEntities db = new wizbudatabaseEntities();
        private void işçilistesigetir_Click(object sender, EventArgs e)
        {

            DateTime tarih = Convert.ToDateTime(dtptarih.Text);
            DateTime oncekigun = tarih.AddDays(-1);
            DateTime sonrakigun = tarih.AddDays(1);

            var kisiGorev = (from p in db.Yapilan
                             where p.Tarih > oncekigun && p.Tarih < sonrakigun
                             join g in db.Gorevler on p.GorevId equals g.Id
                             join k in db.Personel on p.PersonelId equals k.Id
                             select new
                             {
                                 k.Adi_Soyadi,
                                 g.Gorev,
                                 p.Yapilan1,
                                 p.Sure,
                                 p.Tarih

                             }).ToList();
            if (kisiGorev.Count ==0)
            {
                MessageBox.Show(dtptarih.Text + " Tarihinde yapılan iş bulunamamıştır. ");
            }
            else
            {
                gvPatronListe.DataSource = kisiGorev;
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void gvPatronListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
