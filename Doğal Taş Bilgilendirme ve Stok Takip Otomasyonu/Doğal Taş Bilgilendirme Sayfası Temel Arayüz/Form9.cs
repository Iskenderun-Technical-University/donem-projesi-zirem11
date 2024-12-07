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
    public partial class frmbilgi4 : Form
    {
        public frmbilgi4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmbilgi3 fb3 = new frmbilgi3();
            fb3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmbilgi5 fb5 = new frmbilgi5();
            fb5.Show();
            this.Hide();
        }
    }
}
