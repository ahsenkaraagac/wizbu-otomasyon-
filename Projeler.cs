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
    public partial class Projeler : Form
    {
        public Projeler()
        {
            InitializeComponent();
        }
        wizbudatabaseEntities db = new wizbudatabaseEntities();
        int id;
        private void Projeler_Load(object sender, EventArgs e)
        {
            var gorevler = (from p in db.Gorev_Personel
                            where p.BitisTarihi>DateTime.Now
                            join g in db.Gorevler on p.Gorev equals g.Id
                            join k in db.Personel on p.Personel equals k.Id
                            select new
                            {
                                p.Id,
                                grv=g.Id,  
                                prsnl=k.Id,
                                g.Gorev,
                                k.Adi_Soyadi,
                                p.BitisTarihi

                            }).ToList();
            dgbitengorevler.DataSource = gorevler;
            
        }


        private void cbdurum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbdurum.Text == "Tamamlandı")
            {
                rtbaciklama.Visible = false;
                lblaciklama.Visible = false ;
            }
            else
            {
                rtbaciklama.Visible = true;
                lblaciklama.Visible = true;
            }
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            Gorev_Personel grvpersonel = (from x in db.Gorev_Personel where x.Id == id && x.Aciklama==null select x).FirstOrDefault();
            grvpersonel.Durum = cbdurum.Text.ToString();
            grvpersonel.Aciklama = rtbaciklama.Text.ToString();
            db.SaveChanges();
            MessageBox.Show("Kayıt edildi.");
        }

        private void dgbitengorevler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            id = Convert.ToInt32(dgbitengorevler.CurrentRow.Cells[0].Value.ToString());
       

        }

        private void rtbaciklama_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
