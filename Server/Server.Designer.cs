using System;

namespace Server
{
    partial class Server
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
            this.tarih = new System.Windows.Forms.Label();
            this.iyilesen_hasta_sayisi = new System.Windows.Forms.Label();
            this.olu_sayisi = new System.Windows.Forms.Label();
            this.entube_hasta_sayisi = new System.Windows.Forms.Label();
            this.gunluk_vaka = new System.Windows.Forms.Label();
            this.y_b_hasta_sayisi = new System.Windows.Forms.Label();
            this.gunluk_test = new System.Windows.Forms.Label();
            this.gunluk_test_veri = new System.Windows.Forms.TextBox();
            this.y_b_hasta_sayisi_veri = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.entube_hasta_sayisi_veri = new System.Windows.Forms.TextBox();
            this.gunluk_vaka_veri = new System.Windows.Forms.TextBox();
            this.olu_sayisi_veri = new System.Windows.Forms.TextBox();
            this.iyilesen_hasta_sayisi_veri = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tarih_veri = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // tarih
            // 
            this.tarih.AutoSize = true;
            this.tarih.Location = new System.Drawing.Point(6, 169);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(31, 13);
            this.tarih.TabIndex = 12;
            this.tarih.Text = "Tarih";
            // 
            // iyilesen_hasta_sayisi
            // 
            this.iyilesen_hasta_sayisi.AutoSize = true;
            this.iyilesen_hasta_sayisi.Location = new System.Drawing.Point(6, 143);
            this.iyilesen_hasta_sayisi.Name = "iyilesen_hasta_sayisi";
            this.iyilesen_hasta_sayisi.Size = new System.Drawing.Size(101, 13);
            this.iyilesen_hasta_sayisi.TabIndex = 13;
            this.iyilesen_hasta_sayisi.Text = "İyieşen Hasta Sayısı";
            // 
            // olu_sayisi
            // 
            this.olu_sayisi.AutoSize = true;
            this.olu_sayisi.Location = new System.Drawing.Point(6, 117);
            this.olu_sayisi.Name = "olu_sayisi";
            this.olu_sayisi.Size = new System.Drawing.Size(53, 13);
            this.olu_sayisi.TabIndex = 14;
            this.olu_sayisi.Text = "Ölü Sayısı";
            // 
            // entube_hasta_sayisi
            // 
            this.entube_hasta_sayisi.AutoSize = true;
            this.entube_hasta_sayisi.Location = new System.Drawing.Point(6, 91);
            this.entube_hasta_sayisi.Name = "entube_hasta_sayisi";
            this.entube_hasta_sayisi.Size = new System.Drawing.Size(102, 13);
            this.entube_hasta_sayisi.TabIndex = 15;
            this.entube_hasta_sayisi.Text = "Entübe Hasta Sayısı";
            // 
            // gunluk_vaka
            // 
            this.gunluk_vaka.AutoSize = true;
            this.gunluk_vaka.Location = new System.Drawing.Point(6, 39);
            this.gunluk_vaka.Name = "gunluk_vaka";
            this.gunluk_vaka.Size = new System.Drawing.Size(69, 13);
            this.gunluk_vaka.TabIndex = 16;
            this.gunluk_vaka.Text = "Günlük Vaka";
            // 
            // y_b_hasta_sayisi
            // 
            this.y_b_hasta_sayisi.AutoSize = true;
            this.y_b_hasta_sayisi.Location = new System.Drawing.Point(6, 65);
            this.y_b_hasta_sayisi.Name = "y_b_hasta_sayisi";
            this.y_b_hasta_sayisi.Size = new System.Drawing.Size(151, 13);
            this.y_b_hasta_sayisi.TabIndex = 17;
            this.y_b_hasta_sayisi.Text = "Yoğun Bakımdaki Hasta Sayısı";
            // 
            // gunluk_test
            // 
            this.gunluk_test.AutoSize = true;
            this.gunluk_test.Location = new System.Drawing.Point(6, 17);
            this.gunluk_test.Name = "gunluk_test";
            this.gunluk_test.Size = new System.Drawing.Size(65, 13);
            this.gunluk_test.TabIndex = 18;
            this.gunluk_test.Text = "Günlük Test";
            // 
            // gunluk_test_veri
            // 
            this.gunluk_test_veri.Location = new System.Drawing.Point(183, 10);
            this.gunluk_test_veri.Name = "gunluk_test_veri";
            this.gunluk_test_veri.Size = new System.Drawing.Size(164, 20);
            this.gunluk_test_veri.TabIndex = 0;
            // 
            // y_b_hasta_sayisi_veri
            // 
            this.y_b_hasta_sayisi_veri.Location = new System.Drawing.Point(183, 62);
            this.y_b_hasta_sayisi_veri.Name = "y_b_hasta_sayisi_veri";
            this.y_b_hasta_sayisi_veri.Size = new System.Drawing.Size(164, 20);
            this.y_b_hasta_sayisi_veri.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(183, 36);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 20);
            this.textBox3.TabIndex = 19;
            // 
            // entube_hasta_sayisi_veri
            // 
            this.entube_hasta_sayisi_veri.Location = new System.Drawing.Point(183, 88);
            this.entube_hasta_sayisi_veri.Name = "entube_hasta_sayisi_veri";
            this.entube_hasta_sayisi_veri.Size = new System.Drawing.Size(164, 20);
            this.entube_hasta_sayisi_veri.TabIndex = 3;
            // 
            // gunluk_vaka_veri
            // 
            this.gunluk_vaka_veri.Location = new System.Drawing.Point(183, 36);
            this.gunluk_vaka_veri.Name = "gunluk_vaka_veri";
            this.gunluk_vaka_veri.Size = new System.Drawing.Size(164, 20);
            this.gunluk_vaka_veri.TabIndex = 1;
            // 
            // olu_sayisi_veri
            // 
            this.olu_sayisi_veri.Location = new System.Drawing.Point(183, 114);
            this.olu_sayisi_veri.Name = "olu_sayisi_veri";
            this.olu_sayisi_veri.Size = new System.Drawing.Size(164, 20);
            this.olu_sayisi_veri.TabIndex = 4;
            // 
            // iyilesen_hasta_sayisi_veri
            // 
            this.iyilesen_hasta_sayisi_veri.Location = new System.Drawing.Point(183, 140);
            this.iyilesen_hasta_sayisi_veri.Name = "iyilesen_hasta_sayisi_veri";
            this.iyilesen_hasta_sayisi_veri.Size = new System.Drawing.Size(164, 20);
            this.iyilesen_hasta_sayisi_veri.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Verileri Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tarih_veri
            // 
            this.tarih_veri.Location = new System.Drawing.Point(183, 169);
            this.tarih_veri.Name = "tarih_veri";
            this.tarih_veri.Size = new System.Drawing.Size(164, 20);
            this.tarih_veri.TabIndex = 6;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 257);
            this.Controls.Add(this.tarih_veri);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gunluk_vaka_veri);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.iyilesen_hasta_sayisi_veri);
            this.Controls.Add(this.olu_sayisi_veri);
            this.Controls.Add(this.entube_hasta_sayisi_veri);
            this.Controls.Add(this.y_b_hasta_sayisi_veri);
            this.Controls.Add(this.gunluk_test_veri);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.iyilesen_hasta_sayisi);
            this.Controls.Add(this.olu_sayisi);
            this.Controls.Add(this.entube_hasta_sayisi);
            this.Controls.Add(this.gunluk_vaka);
            this.Controls.Add(this.y_b_hasta_sayisi);
            this.Controls.Add(this.gunluk_test);
            this.Name = "Server";
            this.Text = "Covid-19 Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.Label tarih;
        private System.Windows.Forms.Label iyilesen_hasta_sayisi;
        private System.Windows.Forms.Label olu_sayisi;
        private System.Windows.Forms.Label entube_hasta_sayisi;
        private System.Windows.Forms.Label gunluk_vaka;
        private System.Windows.Forms.Label y_b_hasta_sayisi;
        private System.Windows.Forms.Label gunluk_test;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox gunluk_test_veri;
        public System.Windows.Forms.TextBox y_b_hasta_sayisi_veri;
        public System.Windows.Forms.TextBox entube_hasta_sayisi_veri;
        public System.Windows.Forms.TextBox gunluk_vaka_veri;
        public System.Windows.Forms.TextBox olu_sayisi_veri;
        public System.Windows.Forms.TextBox iyilesen_hasta_sayisi_veri;
        private System.Windows.Forms.DateTimePicker tarih_veri;
    }
}

