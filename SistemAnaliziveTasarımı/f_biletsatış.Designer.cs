namespace SistemAnaliziveTasarımı
{
    partial class f_biletsatış
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_biletsatış));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_cinsiyet = new System.Windows.Forms.ComboBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.lbltel = new System.Windows.Forms.Label();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.lbltc = new System.Windows.Forms.Label();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.lblcinsiyet = new System.Windows.Forms.Label();
            this.lblsoyisim = new System.Windows.Forms.Label();
            this.lblisim = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblfiyat = new System.Windows.Forms.Label();
            this.lblkoltukno = new System.Windows.Forms.Label();
            this.lblsefertarih = new System.Windows.Forms.Label();
            this.lblsefersaat = new System.Windows.Forms.Label();
            this.lblseferadı = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_koltuk = new System.Windows.Forms.TextBox();
            this.cb_tarih = new System.Windows.Forms.ComboBox();
            this.cb_sefersaati = new System.Windows.Forms.ComboBox();
            this.cb_gidiş = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.lblsatış = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cb_cinsiyet);
            this.groupBox2.Controls.Add(this.txt_tel);
            this.groupBox2.Controls.Add(this.lbltel);
            this.groupBox2.Controls.Add(this.txt_tc);
            this.groupBox2.Controls.Add(this.lbltc);
            this.groupBox2.Controls.Add(this.txt_soyisim);
            this.groupBox2.Controls.Add(this.txt_isim);
            this.groupBox2.Controls.Add(this.lblcinsiyet);
            this.groupBox2.Controls.Add(this.lblsoyisim);
            this.groupBox2.Controls.Add(this.lblisim);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(321, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 218);
            this.groupBox2.TabIndex = 114;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kişisel Bilgiler";
            // 
            // cb_cinsiyet
            // 
            this.cb_cinsiyet.BackColor = System.Drawing.Color.White;
            this.cb_cinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cinsiyet.FormattingEnabled = true;
            this.cb_cinsiyet.Items.AddRange(new object[] {
            "",
            "Bay",
            "Bayan"});
            this.cb_cinsiyet.Location = new System.Drawing.Point(152, 157);
            this.cb_cinsiyet.Name = "cb_cinsiyet";
            this.cb_cinsiyet.Size = new System.Drawing.Size(121, 29);
            this.cb_cinsiyet.TabIndex = 19;
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(152, 127);
            this.txt_tel.MaxLength = 11;
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(121, 27);
            this.txt_tel.TabIndex = 18;
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Location = new System.Drawing.Point(6, 130);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(74, 21);
            this.lbltel.TabIndex = 16;
            this.lbltel.Text = "Telefon :";
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(152, 25);
            this.txt_tc.MaxLength = 11;
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(121, 27);
            this.txt_tc.TabIndex = 15;
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltc.Location = new System.Drawing.Point(6, 28);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(88, 21);
            this.lbltc.TabIndex = 14;
            this.lbltc.Text = "T.C. Kimlik:\r\n";
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.Location = new System.Drawing.Point(152, 91);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(121, 27);
            this.txt_soyisim.TabIndex = 13;
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(152, 58);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(121, 27);
            this.txt_isim.TabIndex = 10;
            // 
            // lblcinsiyet
            // 
            this.lblcinsiyet.AutoSize = true;
            this.lblcinsiyet.Location = new System.Drawing.Point(6, 160);
            this.lblcinsiyet.Name = "lblcinsiyet";
            this.lblcinsiyet.Size = new System.Drawing.Size(74, 21);
            this.lblcinsiyet.TabIndex = 0;
            this.lblcinsiyet.Text = "Cinsiyet:";
            // 
            // lblsoyisim
            // 
            this.lblsoyisim.AutoSize = true;
            this.lblsoyisim.Location = new System.Drawing.Point(6, 94);
            this.lblsoyisim.Name = "lblsoyisim";
            this.lblsoyisim.Size = new System.Drawing.Size(67, 21);
            this.lblsoyisim.TabIndex = 0;
            this.lblsoyisim.Text = "Soyisim:";
            // 
            // lblisim
            // 
            this.lblisim.AutoSize = true;
            this.lblisim.Location = new System.Drawing.Point(6, 61);
            this.lblisim.Name = "lblisim";
            this.lblisim.Size = new System.Drawing.Size(43, 21);
            this.lblisim.TabIndex = 0;
            this.lblisim.Text = "İsim:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(12, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 502);
            this.panel1.TabIndex = 112;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ImageKey = "kapı.png";
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(152, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 49);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "kapı.png");
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblfiyat);
            this.groupBox1.Controls.Add(this.lblkoltukno);
            this.groupBox1.Controls.Add(this.lblsefertarih);
            this.groupBox1.Controls.Add(this.lblsefersaat);
            this.groupBox1.Controls.Add(this.lblseferadı);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txt_koltuk);
            this.groupBox1.Controls.Add(this.cb_tarih);
            this.groupBox1.Controls.Add(this.cb_sefersaati);
            this.groupBox1.Controls.Add(this.cb_gidiş);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(661, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 218);
            this.groupBox1.TabIndex = 113;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sefer İşlemleri ";
            // 
            // lblfiyat
            // 
            this.lblfiyat.AutoSize = true;
            this.lblfiyat.Location = new System.Drawing.Point(5, 167);
            this.lblfiyat.Name = "lblfiyat";
            this.lblfiyat.Size = new System.Drawing.Size(55, 21);
            this.lblfiyat.TabIndex = 24;
            this.lblfiyat.Text = "Fiyat :";
            // 
            // lblkoltukno
            // 
            this.lblkoltukno.AutoSize = true;
            this.lblkoltukno.Location = new System.Drawing.Point(5, 134);
            this.lblkoltukno.Name = "lblkoltukno";
            this.lblkoltukno.Size = new System.Drawing.Size(91, 21);
            this.lblkoltukno.TabIndex = 25;
            this.lblkoltukno.Text = "Koltuk No :";
            // 
            // lblsefertarih
            // 
            this.lblsefertarih.AutoSize = true;
            this.lblsefertarih.Location = new System.Drawing.Point(6, 64);
            this.lblsefertarih.Name = "lblsefertarih";
            this.lblsefertarih.Size = new System.Drawing.Size(118, 21);
            this.lblsefertarih.TabIndex = 23;
            this.lblsefertarih.Text = "Sefer Tarihleri :";
            // 
            // lblsefersaat
            // 
            this.lblsefersaat.AutoSize = true;
            this.lblsefersaat.Location = new System.Drawing.Point(6, 99);
            this.lblsefersaat.Name = "lblsefersaat";
            this.lblsefersaat.Size = new System.Drawing.Size(118, 21);
            this.lblsefersaat.TabIndex = 22;
            this.lblsefersaat.Text = "Sefer Saatleri :";
            // 
            // lblseferadı
            // 
            this.lblseferadı.AutoSize = true;
            this.lblseferadı.Location = new System.Drawing.Point(6, 26);
            this.lblseferadı.Name = "lblseferadı";
            this.lblseferadı.Size = new System.Drawing.Size(87, 21);
            this.lblseferadı.TabIndex = 21;
            this.lblseferadı.Text = "Sefer Adı :";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(148, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 27);
            this.textBox1.TabIndex = 20;
            // 
            // txt_koltuk
            // 
            this.txt_koltuk.Enabled = false;
            this.txt_koltuk.Location = new System.Drawing.Point(148, 131);
            this.txt_koltuk.Name = "txt_koltuk";
            this.txt_koltuk.Size = new System.Drawing.Size(121, 27);
            this.txt_koltuk.TabIndex = 18;
            // 
            // cb_tarih
            // 
            this.cb_tarih.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tarih.FormattingEnabled = true;
            this.cb_tarih.Location = new System.Drawing.Point(148, 61);
            this.cb_tarih.Name = "cb_tarih";
            this.cb_tarih.Size = new System.Drawing.Size(121, 29);
            this.cb_tarih.TabIndex = 5;
            this.cb_tarih.SelectedIndexChanged += new System.EventHandler(this.cb_tarih_SelectedIndexChanged);
            // 
            // cb_sefersaati
            // 
            this.cb_sefersaati.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sefersaati.FormattingEnabled = true;
            this.cb_sefersaati.Location = new System.Drawing.Point(148, 96);
            this.cb_sefersaati.Name = "cb_sefersaati";
            this.cb_sefersaati.Size = new System.Drawing.Size(121, 29);
            this.cb_sefersaati.TabIndex = 5;
            this.cb_sefersaati.SelectedIndexChanged += new System.EventHandler(this.cb_sefersaati_SelectedIndexChanged);
            // 
            // cb_gidiş
            // 
            this.cb_gidiş.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_gidiş.FormattingEnabled = true;
            this.cb_gidiş.Location = new System.Drawing.Point(148, 23);
            this.cb_gidiş.Name = "cb_gidiş";
            this.cb_gidiş.Size = new System.Drawing.Size(121, 29);
            this.cb_gidiş.TabIndex = 1;
            this.cb_gidiş.SelectedIndexChanged += new System.EventHandler(this.cb_gidiş_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageKey = "satınal.png";
            this.button1.ImageList = this.ımageList2;
            this.button1.Location = new System.Drawing.Point(460, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 85);
            this.button1.TabIndex = 115;
            this.button1.Text = "Satın Al";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "admin.png");
            this.ımageList2.Images.SetKeyName(1, "bul.png");
            this.ımageList2.Images.SetKeyName(2, "camera.png");
            this.ımageList2.Images.SetKeyName(3, "güncelle.png");
            this.ımageList2.Images.SetKeyName(4, "home.png");
            this.ımageList2.Images.SetKeyName(5, "kayıt ol.png");
            this.ımageList2.Images.SetKeyName(6, "koltuk.png");
            this.ımageList2.Images.SetKeyName(7, "kullanıcı.png");
            this.ımageList2.Images.SetKeyName(8, "login.png");
            this.ımageList2.Images.SetKeyName(9, "otobüs.png");
            this.ımageList2.Images.SetKeyName(10, "satınal.png");
            this.ımageList2.Images.SetKeyName(11, "Sil.png");
            this.ımageList2.Images.SetKeyName(12, "yenikayıt.png");
            this.ımageList2.Images.SetKeyName(13, "kapat.png");
            this.ımageList2.Images.SetKeyName(14, "geri.png");
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.ImageKey = "yenikayıt.png";
            this.button2.ImageList = this.ımageList2;
            this.button2.Location = new System.Drawing.Point(661, 425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 85);
            this.button2.TabIndex = 115;
            this.button2.Text = "Yeni Kayıt";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblsatış
            // 
            this.lblsatış.AutoSize = true;
            this.lblsatış.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsatış.ForeColor = System.Drawing.Color.White;
            this.lblsatış.Location = new System.Drawing.Point(578, 89);
            this.lblsatış.Name = "lblsatış";
            this.lblsatış.Size = new System.Drawing.Size(160, 36);
            this.lblsatış.TabIndex = 116;
            this.lblsatış.Text = "BİLET SATIŞ";
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.ImageKey = "kapat.png";
            this.button5.ImageList = this.ımageList2;
            this.button5.Location = new System.Drawing.Point(976, 1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 55);
            this.button5.TabIndex = 120;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // f_biletsatış
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1039, 601);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.lblsatış);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "f_biletsatış";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.f_biletsatış_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_cinsiyet;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Label lblcinsiyet;
        private System.Windows.Forms.Label lblsoyisim;
        private System.Windows.Forms.Label lblisim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_koltuk;
        private System.Windows.Forms.ComboBox cb_tarih;
        private System.Windows.Forms.ComboBox cb_sefersaati;
        private System.Windows.Forms.ComboBox cb_gidiş;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblfiyat;
        private System.Windows.Forms.Label lblkoltukno;
        private System.Windows.Forms.Label lblsefertarih;
        private System.Windows.Forms.Label lblsefersaat;
        private System.Windows.Forms.Label lblseferadı;
        private System.Windows.Forms.Label lblsatış;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ImageList ımageList2;
    }
}