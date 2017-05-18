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
    public partial class kayıt : Form
    {
        public kayıt()
        {
            InitializeComponent();
        }
        wizbudatabaseEntities db = new wizbudatabaseEntities();
        private void kayıt_Load(object sender, EventArgs e)
        {
            var adiSoyadi = (from x in db.Personel select x.Adi_Soyadi).ToList();
            cbAdiSoyadi.DataSource = adiSoyadi;
            
        }

        private void btKayit_Click(object sender, EventArgs e)
        {
            string gorev = tbGorev.Text;
            string aciklama = tbAciklama.Text;
            string kisi = cbAdiSoyadi.Text;
            int sure = Convert.ToInt32(tbSure.Text);           
            Personel id = (from x in db.Personel where x.Adi_Soyadi == kisi select x).FirstOrDefault();

            if (id.Adi_Soyadi == kisi)
            {
                Gorevler gorevBilgisi = new Gorevler();
                gorevBilgisi.Aciklama = aciklama;
                gorevBilgisi.Gorev = gorev;
                gorevBilgisi.Sure = sure;
                db.Gorevler.Add(gorevBilgisi);
                db.SaveChanges();
                Gorevler gorevIdBul = (from x in db.Gorevler where x.Gorev == gorev && x.Sure == sure && x.Aciklama == aciklama select x).FirstOrDefault();
                Gorev_Personel gorevPersonel = new Gorev_Personel();
                gorevPersonel.BaslangicTarihi = DateTime.Now;
                gorevPersonel.BitisTarihi = DateTime.Now.AddDays(sure);
                gorevPersonel.Personel = Convert.ToInt32(id.Id);
                gorevPersonel.Gorev = Convert.ToInt32(gorevIdBul.Id.ToString());
                db.Gorev_Personel.Add(gorevPersonel);
                db.SaveChanges();
                MessageBox.Show("Görev kisiye başarıyla eklendi");
            }




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbAdiSoyadi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbAciklama_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
