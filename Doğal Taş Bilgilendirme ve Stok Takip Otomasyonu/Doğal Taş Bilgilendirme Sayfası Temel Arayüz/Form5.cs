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
    public partial class frmbilgilendirme : Form
    {
        public frmbilgilendirme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            frmanasayfa fas = new frmanasayfa();
            fas.Show();
            this.Hide();
        }
    }
}
