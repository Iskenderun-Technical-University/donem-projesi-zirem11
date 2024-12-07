
namespace Doğal_Taş_Bilgilendirme_Sayfası_Temel_Arayüz
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btndogaltaslar = new System.Windows.Forms.Button();
            this.btnpersonelgiris = new System.Windows.Forms.Button();
            this.btnbilgilendirme = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnhakkimizda = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Doğal_Taş_Bilgilendirme_Sayfası_Temel_Arayüz.Properties.Resources.dogal_taslar_nasil_kullanilir__jpeg;
            this.pictureBox1.Location = new System.Drawing.Point(560, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 412);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btndogaltaslar
            // 
            this.btndogaltaslar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndogaltaslar.Location = new System.Drawing.Point(197, 265);
            this.btndogaltaslar.Name = "btndogaltaslar";
            this.btndogaltaslar.Size = new System.Drawing.Size(153, 38);
            this.btndogaltaslar.TabIndex = 1;
            this.btndogaltaslar.Text = "Doğal Taşlar";
            this.btndogaltaslar.UseVisualStyleBackColor = true;
            // 
            // btnpersonelgiris
            // 
            this.btnpersonelgiris.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnpersonelgiris.Location = new System.Drawing.Point(197, 221);
            this.btnpersonelgiris.Name = "btnpersonelgiris";
            this.btnpersonelgiris.Size = new System.Drawing.Size(153, 38);
            this.btnpersonelgiris.TabIndex = 2;
            this.btnpersonelgiris.Text = "Personel Girişi";
            this.btnpersonelgiris.UseVisualStyleBackColor = true;
            // 
            // btnbilgilendirme
            // 
            this.btnbilgilendirme.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbilgilendirme.Location = new System.Drawing.Point(197, 357);
            this.btnbilgilendirme.Name = "btnbilgilendirme";
            this.btnbilgilendirme.Size = new System.Drawing.Size(153, 38);
            this.btnbilgilendirme.TabIndex = 3;
            this.btnbilgilendirme.Text = "Bilgilendirme";
            this.btnbilgilendirme.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-4, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 114);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 66);
            this.label1.TabIndex = 5;
            this.label1.Text = "Doğal taşlar hakkında bilmek istediğiniz her şey\r\nbu sayfada sizleri bekliyor !";
            // 
            // btnhakkimizda
            // 
            this.btnhakkimizda.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhakkimizda.Location = new System.Drawing.Point(197, 313);
            this.btnhakkimizda.Name = "btnhakkimizda";
            this.btnhakkimizda.Size = new System.Drawing.Size(153, 38);
            this.btnhakkimizda.TabIndex = 5;
            this.btnhakkimizda.Text = "Hakkımızda";
            this.btnhakkimizda.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(78, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(417, 61);
            this.label2.TabIndex = 6;
            this.label2.Text = "-Doğanın Şifalı Gücü-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(946, 407);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnhakkimizda);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnbilgilendirme);
            this.Controls.Add(this.btnpersonelgiris);
            this.Controls.Add(this.btndogaltaslar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btndogaltaslar;
        private System.Windows.Forms.Button btnpersonelgiris;
        private System.Windows.Forms.Button btnbilgilendirme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnhakkimizda;
        private System.Windows.Forms.Label label2;
    }
}

