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
    public partial class frmbilgiA : Form
    {
        public frmbilgiA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //fma=form anasayfa
            frmanasayfa fma = new frmanasayfa();
            fma.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //fb2=form bilgi 2
            frmbilgi2 fb2 = new frmbilgi2();
            fb2.Show();
            this.Hide();
        }
    }
}
