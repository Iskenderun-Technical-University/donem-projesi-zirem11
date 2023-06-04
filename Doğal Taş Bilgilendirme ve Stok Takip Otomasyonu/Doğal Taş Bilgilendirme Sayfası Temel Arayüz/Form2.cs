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
    public partial class frmpersonelgiris : Form
    {
        public frmpersonelgiris()
        {
            InitializeComponent();
        }

        private void btngirisyap_Click(object sender, EventArgs e)
        {
            if(txtkullaniciad.Text=="zirem11" && txtsifre.Text=="zadmin11")
            {
                //fst=form stok takip
                frmstoktakip fst = new frmstoktakip();
                fst.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Bilgileri hatalı girdiniz.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //fas=form anasayfa
            frmanasayfa fas = new frmanasayfa();
            fas.Show();
            this.Hide();
        }
    }
}
