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
    public partial class isci : Form
    {
        public isci()
        {
            InitializeComponent();
        }
        wizbudatabaseEntities db = new wizbudatabaseEntities();
        private void btnKayit_Click(object sender, EventArgs e)
        {
            string aciklama = tbAciklama.Text.ToString();
            int sure = Convert.ToInt32(tbSure.Text);
            string gorev = tbGörev.Text.ToString();
            Gorevler gorevBilgisi = new Gorevler();
            gorevBilgisi.Aciklama = aciklama;
            gorevBilgisi.Gorev = gorev;
            gorevBilgisi.Sure = sure;
            db.Gorevler.Add(gorevBilgisi);
            db.SaveChanges();
            Gorevler gorevIdBul=(from x in db.Gorevler where x.Gorev==gorev && x.Sure==sure && x.Aciklama==aciklama select x).FirstOrDefault();
            Gorev_Personel gorevPersonel = new Gorev_Personel();
            gorevPersonel.BaslangicTarihi = DateTime.Now;
            if (cbZaman.Text == "Ay")
            {
                gorevPersonel.BitisTarihi = DateTime.Now.AddDays(sure*30);
            }
            else if (cbZaman.Text == "Hafta")
            {
                gorevPersonel.BitisTarihi = DateTime.Now.AddDays(sure*7);
            }
            else if (cbZaman.Text == "Gün")
            {
                gorevPersonel.BitisTarihi = DateTime.Now.AddDays(sure);
            }
            else 
            {
                gorevPersonel.BitisTarihi = DateTime.Now.AddHours(sure);
            }
           
            gorevPersonel.Personel = Convert.ToInt32(lbKullaniciId.Text);
            gorevPersonel.Gorev = Convert.ToInt32(gorevIdBul.Id.ToString());
            db.Gorev_Personel.Add(gorevPersonel);
            db.SaveChanges();
            MessageBox.Show("Gorev başarıyla girildi.");

            datagridviewdoldur(Convert.ToInt32(lbKullaniciId.Text));
        }

        private void datagridviewdoldur(int id)
        {
            
            var gorevler = (from p in db.Gorev_Personel
                            where p.Personel == id
                            join g in db.Gorevler on p.Gorev equals g.Id
                            select new
                            {
                                g.Gorev,
                                g.Aciklama,
                                p.BaslangicTarihi,
                                p.BitisTarihi

                            }).ToList();
            dgGorevTablosu.DataSource = gorevler;
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void isci_Loaded(object sender, EventArgs e)
        {
            
        }

        private void isci_MouseHover(object sender, EventArgs e)
        {
            datagridviewdoldur(Convert.ToInt32(lbKullaniciId.Text));
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Aciklama acik = new Aciklama();
            acik.Show();
            acik.lbkisiid.Text = lbKullaniciId.Text;
        }

        private void cbZaman_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void tbGörev_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSure_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
