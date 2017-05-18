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
    public partial class Eksikler : Form
    {
        public Eksikler()
        {
            InitializeComponent();
        }
        wizbudatabaseEntities db = new wizbudatabaseEntities();
        private void Eksikler_Load(object sender, EventArgs e)
        {
            var eksikgorevler = (from p in db.Gorev_Personel
                            where p.Durum=="Eksik"
                            join g in db.Gorevler on p.Gorev equals g.Id
                            join k in db.Personel on p.Personel equals k.Id
                            select new
                            {
                                g.Gorev,
                                k.Adi_Soyadi,
                                p.Aciklama

                            }).ToList();

            dgveksikler.DataSource = eksikgorevler;
        }

        private void dgveksikler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
