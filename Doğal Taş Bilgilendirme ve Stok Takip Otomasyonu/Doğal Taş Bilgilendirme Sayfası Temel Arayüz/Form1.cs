using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doğal_Taş_Bilgilendirme_Sayfası_Temel_Arayüz
{
    public partial class frmanasayfa : Form
    {
        public frmanasayfa()
        {
            InitializeComponent();
        }

        private void btnpersonelgiris_Click(object sender, EventArgs e)
        {
            //fpg=form personel giriş
            frmpersonelgiris fpg = new frmpersonelgiris();
            fpg.Show();
            this.Hide();
        }

        private void btnhakkimizda_Click(object sender, EventArgs e)
        {
            //fh=form hakkımızda
            frmhakimizda fh = new frmhakimizda();
            fh.Show();
            this.Hide();
        }

        private void btnbilgilendirme_Click(object sender, EventArgs e)
        {
            //fb=form bilgilendirme
            frmbilgilendirme fb = new frmbilgilendirme();
            fb.Show();
            this.Hide();
        }
    }
}
