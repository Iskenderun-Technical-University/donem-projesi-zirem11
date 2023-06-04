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
    public partial class frmbilgi7 : Form
    {
        public frmbilgi7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmbilgi6 fb6 = new frmbilgi6();
            fb6.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmbilgi8 fb8 = new frmbilgi8();
            fb8.Show();
            this.Hide();
        }
    }
}
