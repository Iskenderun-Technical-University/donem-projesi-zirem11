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
    public partial class frmbilgi6 : Form
    {
        public frmbilgi6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmbilgi5 fb5 = new frmbilgi5();
            fb5.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmbilgi7 fb7 = new frmbilgi7();
            fb7.Show();
            this.Hide();
        }
    }
}
