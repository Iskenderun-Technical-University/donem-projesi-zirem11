
namespace Doğal_Taş_Bilgilendirme_Sayfası_Temel_Arayüz
{
    partial class frmstoktakip
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokTablosuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dogal_Tas_Stok_TakipDataSet2 = new Doğal_Taş_Bilgilendirme_Sayfası_Temel_Arayüz.Dogal_Tas_Stok_TakipDataSet2();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btntemizle = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnlistele = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtadet = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stok_TablosuTableAdapter = new Doğal_Taş_Bilgilendirme_Sayfası_Temel_Arayüz.Dogal_Tas_Stok_TakipDataSet2TableAdapters.Stok_TablosuTableAdapter();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTablosuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogal_Tas_Stok_TakipDataSet2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(13, 326);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(728, 221);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Liste";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunidDataGridViewTextBoxColumn,
            this.urunAdDataGridViewTextBoxColumn,
            this.urunAdetDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stokTablosuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 175);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // urunidDataGridViewTextBoxColumn
            // 
            this.urunidDataGridViewTextBoxColumn.DataPropertyName = "Urunid";
            this.urunidDataGridViewTextBoxColumn.HeaderText = "Urunid";
            this.urunidDataGridViewTextBoxColumn.Name = "urunidDataGridViewTextBoxColumn";
            // 
            // urunAdDataGridViewTextBoxColumn
            // 
            this.urunAdDataGridViewTextBoxColumn.DataPropertyName = "UrunAd";
            this.urunAdDataGridViewTextBoxColumn.HeaderText = "UrunAd";
            this.urunAdDataGridViewTextBoxColumn.Name = "urunAdDataGridViewTextBoxColumn";
            // 
            // urunAdetDataGridViewTextBoxColumn
            // 
            this.urunAdetDataGridViewTextBoxColumn.DataPropertyName = "UrunAdet";
            this.urunAdetDataGridViewTextBoxColumn.HeaderText = "UrunAdet";
            this.urunAdetDataGridViewTextBoxColumn.Name = "urunAdetDataGridViewTextBoxColumn";
            // 
            // stokTablosuBindingSource
            // 
            this.stokTablosuBindingSource.DataMember = "Stok_Tablosu";
            this.stokTablosuBindingSource.DataSource = this.dogal_Tas_Stok_TakipDataSet2;
            // 
            // dogal_Tas_Stok_TakipDataSet2
            // 
            this.dogal_Tas_Stok_TakipDataSet2.DataSetName = "Dogal_Tas_Stok_TakipDataSet2";
            this.dogal_Tas_Stok_TakipDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btntemizle);
            this.groupBox2.Controls.Add(this.btngüncelle);
            this.groupBox2.Controls.Add(this.btnsil);
            this.groupBox2.Controls.Add(this.btnkaydet);
            this.groupBox2.Controls.Add(this.btnlistele);
            this.groupBox2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(369, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 290);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(70, 198);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(171, 34);
            this.btntemizle.TabIndex = 4;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.Location = new System.Drawing.Point(70, 158);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(171, 34);
            this.btngüncelle.TabIndex = 3;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(70, 118);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(171, 34);
            this.btnsil.TabIndex = 2;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(70, 74);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(171, 34);
            this.btnkaydet.TabIndex = 1;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(70, 33);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(171, 34);
            this.btnlistele.TabIndex = 0;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtadet);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 290);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Adedi Kayıt";
            // 
            // txtadet
            // 
            this.txtadet.Location = new System.Drawing.Point(130, 165);
            this.txtadet.Name = "txtadet";
            this.txtadet.Size = new System.Drawing.Size(155, 36);
            this.txtadet.TabIndex = 7;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(130, 116);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(155, 36);
            this.txtad.TabIndex = 6;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(130, 71);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(155, 36);
            this.txtid.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ürün Adet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürün Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Id:";
            // 
            // stok_TablosuTableAdapter
            // 
            this.stok_TablosuTableAdapter.ClearBeforeFill = true;
            // 
            // frmstoktakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(890, 548);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmstoktakip";
            this.Text = "Stok Takip Kısmı";
            this.Load += new System.EventHandler(this.frmstoktakip_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTablosuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogal_Tas_Stok_TakipDataSet2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtadet;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Dogal_Tas_Stok_TakipDataSet2 dogal_Tas_Stok_TakipDataSet2;
        private System.Windows.Forms.BindingSource stokTablosuBindingSource;
        private Dogal_Tas_Stok_TakipDataSet2TableAdapters.Stok_TablosuTableAdapter stok_TablosuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdetDataGridViewTextBoxColumn;
    }
}