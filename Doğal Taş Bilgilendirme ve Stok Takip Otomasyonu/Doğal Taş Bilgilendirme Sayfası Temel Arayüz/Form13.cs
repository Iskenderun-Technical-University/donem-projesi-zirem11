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
    public partial class frmbilgi8 : Form
    {
        public frmbilgi8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmbilgi7 fb7 = new frmbilgi7();
            fb7.Show();
            this.Hide();
        }
    }
}
