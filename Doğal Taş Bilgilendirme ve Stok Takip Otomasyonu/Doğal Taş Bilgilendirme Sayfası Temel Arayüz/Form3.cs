using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Doğal_Taş_Bilgilendirme_Sayfası_Temel_Arayüz
{
    public partial class frmstoktakip : Form
    {
        public frmstoktakip()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BKILGTG\\MSSQLSERVER03; Initial Catalog=Dogal_Tas_Stok_Takip; Integrated Security = True");

        private void frmstoktakip_Load(object sender, EventArgs e)
        {

        }

       

        private void btnlistele_Click(object sender, EventArgs e)
        {
            this.stok_TablosuTableAdapter.Fill(this.dogal_Tas_Stok_TakipDataSet2.Stok_Tablosu);
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Stok_Tablosu (UrunAd,UrunAdet) values (@p1,@p2)",baglanti);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtadet.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün eklendi");
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtid.Text = " ";
            txtad.Text = " ";
            txtadet.Text = " ";

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete from Stok_Tablosu where Urunid=@t1", baglanti);
            komutsil.Parameters.AddWithValue("@t1", txtid.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün silindi.");
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutgüncelle = new SqlCommand("Update Stok_Tablosu set Urunid=@a1, UrunAd=@a2, UrunAdet=@a3", baglanti);
            komutgüncelle.Parameters.AddWithValue("@a1", txtid.Text);
            komutgüncelle.Parameters.AddWithValue("@a2", txtad.Text);
            komutgüncelle.Parameters.AddWithValue("@a3", txtadet.Text);
            komutgüncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Bilgiler güncellendi.");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilendeger = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilendeger].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilendeger].Cells[1].Value.ToString();
            txtadet.Text = dataGridView1.Rows[secilendeger].Cells[2].Value.ToString();
        }
    }
}
