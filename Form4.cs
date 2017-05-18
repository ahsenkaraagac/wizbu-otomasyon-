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
    public partial class kişilistesi : Form
    {
        public kişilistesi()
        {
            InitializeComponent();
        }
        wizbudatabaseEntities db = new wizbudatabaseEntities();
        private void kişilistesi_Load(object sender, EventArgs e)
        {
            kisigorevgetir();

        }

        private void kisigorevgetir()
        {
            var kisiGorev = (from p in db.Gorev_Personel
                             join g in db.Gorevler on p.Gorev equals g.Id
                             join k in db.Personel on p.Personel equals k.Id
                             select new
                             {
                                 k.Adi_Soyadi,
                                 g.Gorev
                             }).ToList();

            dgIsciGorev.DataSource = kisiGorev;
        }

        private void dgIsciGorev_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string kisiadi= dgIsciGorev.CurrentRow.Cells[0].Value.ToString();
            string gorevadi = dgIsciGorev.CurrentRow.Cells[1].Value.ToString();
            var kisi_id = (from x in db.Personel where x.Adi_Soyadi == kisiadi.ToString() select x.Id).FirstOrDefault();
            var gorev_id = (from x in db.Gorevler where x.Gorev == gorevadi.ToString() select x.Id).FirstOrDefault();
            lbGorev.Text = gorev_id.ToString();
            lbKisi.Text = kisi_id.ToString();

        }

        private void btGorevDuzenle_Click(object sender, EventArgs e)
        {
            if (btKayit.Visible == false)
            {
                btKayit.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                tbAciklama.Visible = true;
                tbGorev.Visible = true;
                tbSure.Visible = true;

                int id = Convert.ToInt32(lbGorev.Text);
                Gorevler gorev = (from x in db.Gorevler where x.Id == id select x).FirstOrDefault();
                tbAciklama.Text = gorev.Aciklama;
                tbGorev.Text = gorev.Gorev;
                tbSure.Text = gorev.Sure.ToString();
            }
            else
            {
                MessageBox.Show("Kayıt ediniz.");
            }
           
        }

        private void btKayit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lbGorev.Text);
            Gorevler gorev = (from x in db.Gorevler where x.Id == id select x).FirstOrDefault();
            gorev.Aciklama=tbAciklama.Text;
            gorev.Gorev=tbGorev.Text;
            gorev.Sure = Convert.ToInt32(tbSure.Text);
            db.SaveChanges();
            kisigorevgetir();
            MessageBox.Show("Kayıt edildi.");
            btKayit.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            tbAciklama.Visible = false;
            tbGorev.Visible = false;
            tbSure.Visible = false;

        }

        private void btKisiSil_Click(object sender, EventArgs e)
        {
            int idkisi = Convert.ToInt32(lbKisi.Text);
            var kisi = (from x in db.Personel where x.Id == idkisi select x).FirstOrDefault();
            var kisigorev = (from x in db.Gorev_Personel where x.Personel == idkisi select x).ToList();
            foreach (var item in kisigorev)
            {
                db.Gorev_Personel.Remove(item);
                db.SaveChanges();
            }           
            db.Personel.Remove(kisi);
            db.SaveChanges();
            kisigorevgetir();
            MessageBox.Show("Kayit Silindi");
            
        
        }

        private void lbKisi_Click(object sender, EventArgs e)
        {

        }

        private void dgIsciGorev_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbGorev_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
