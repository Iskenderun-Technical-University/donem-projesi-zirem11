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
    public partial class frmbilgi3 : Form
    {
        public frmbilgi3()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmbilgi2 fb2 = new frmbilgi2();
            fb2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmbilgi4 fb4 = new frmbilgi4();
            fb4.Show();
            this.Hide();
        }
    }
}
