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
    public partial class Aciklama : Form
    {
        public Aciklama()
        {
            InitializeComponent();
        }
        wizbudatabaseEntities db = new wizbudatabaseEntities();
        string kisiid;
        string gorevid;
        private void Aciklama_Load(object sender, EventArgs e)
        {

        }

        private void Aciklama_MouseHover(object sender, EventArgs e)
        {
            int kisi = Convert.ToInt32(lbkisiid.Text);
          
            
            var kisiGorev = (from k in db.Personel
                             where k.Id == kisi
                             join p in db.Gorev_Personel on k.Id equals p.Personel
                             join g in db.Gorevler on p.Gorev equals g.Id
                             select new
                             {
                                 
                                 p.Id,
                                 g.Gorev,
                                gorevid= g.Id
                             }).ToList();

            dggorevler.DataSource = kisiGorev;
            dggorevler.Columns[0].Visible = false;
            dggorevler.Columns[2].Visible = false;
            
        }

        private void btkaydet_Click(object sender, EventArgs e)
        {
            int kisi = Convert.ToInt32(lbkisiid.Text);
            Yapilan yapilanis = new Yapilan();
            yapilanis.GorevId = Convert.ToInt32(gorevid);
            yapilanis.PersonelId = Convert.ToInt32(kisi);
            yapilanis.Sure = Convert.ToInt32(tbsure.Text);
            yapilanis.Yapilan1 = tbaciklama.Text;
            yapilanis.Tarih = DateTime.Now;
            db.Yapilan.Add(yapilanis);
            db.SaveChanges();
            MessageBox.Show("Kayit oldu");
        }

        private void dggorevler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            kisiid = dggorevler.CurrentRow.Cells[0].Value.ToString();
            gorevid = dggorevler.CurrentRow.Cells[2].Value.ToString();

        }
    }
}
