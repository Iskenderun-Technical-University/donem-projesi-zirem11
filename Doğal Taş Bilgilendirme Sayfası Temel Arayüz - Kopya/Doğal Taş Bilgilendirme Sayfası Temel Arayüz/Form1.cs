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
    }
}
