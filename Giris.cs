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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        wizbudatabaseEntities db = new wizbudatabaseEntities();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = tbKullaniciAdi.Text;
            string kullaniciSifresi = tbKullaniciSifresi.Text;
            Personel kayit = (from x in db.Personel where x.Kullaniciadi == kullaniciAdi.ToString() && x.Sifre == kullaniciSifresi select x).FirstOrDefault();
            try
            {
                if (kayit.Kullaniciadi == kullaniciAdi.ToString() && kayit.Sifre == kullaniciSifresi)
                {
                    isci isciform = new isci();
                    isciform.Show();
                    isciform.lbKullaniciId.Text = kayit.Id.ToString();
                    Aciklama acik = new Aciklama();
                    acik.lbkisiid.Text = kayit.Id.ToString();

                }
                else if (kullaniciAdi == "patron" && kullaniciSifresi == "123456")
                {
                    kişilistesi kisiler = new kişilistesi();
                    kisiler.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kullanici Adi veya Şifre Hatalı");      
            }
           

        }

        private void label2_Click(object sender, EventArgs e)
        {
            kayıt form3 = new kayıt();
            form3.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            kişilistesi form4 = new kişilistesi();
            form4.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void tbKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Projeler biten = new Projeler();
            biten.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Eksikler eksikgorev = new Eksikler();
            eksikgorev.Show();
        }
    }
}
