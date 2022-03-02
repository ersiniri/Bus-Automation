namespace SistemAnaliziveTasarımı
{
    partial class f_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_admin));
            this.label3 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_anasayfa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_asifre = new System.Windows.Forms.TextBox();
            this.txt_akadi = new System.Windows.Forms.TextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(287, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 84;
            this.label3.Text = "ADMİN GİRİŞİ";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "admin.png");
            this.ımageList1.Images.SetKeyName(1, "bul.png");
            this.ımageList1.Images.SetKeyName(2, "camera.png");
            this.ımageList1.Images.SetKeyName(3, "güncelle.png");
            this.ımageList1.Images.SetKeyName(4, "home.png");
            this.ımageList1.Images.SetKeyName(5, "kayıt ol.png");
            this.ımageList1.Images.SetKeyName(6, "koltuk.png");
            this.ımageList1.Images.SetKeyName(7, "kullanıcı.png");
            this.ımageList1.Images.SetKeyName(8, "login.png");
            this.ımageList1.Images.SetKeyName(9, "otobüs.png");
            this.ımageList1.Images.SetKeyName(10, "satınal.png");
            this.ımageList1.Images.SetKeyName(11, "Sil.png");
            this.ımageList1.Images.SetKeyName(12, "yenikayıt.png");
            this.ımageList1.Images.SetKeyName(13, "kapat.png");
            this.ımageList1.Images.SetKeyName(14, "geri.png");
            // 
            // btn_anasayfa
            // 
            this.btn_anasayfa.BackColor = System.Drawing.Color.Maroon;
            this.btn_anasayfa.FlatAppearance.BorderSize = 0;
            this.btn_anasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anasayfa.Font = new System.Drawing.Font("Mesquite Std", 8.25F);
            this.btn_anasayfa.ImageKey = "home.png";
            this.btn_anasayfa.ImageList = this.ımageList1;
            this.btn_anasayfa.Location = new System.Drawing.Point(0, 0);
            this.btn_anasayfa.Name = "btn_anasayfa";
            this.btn_anasayfa.Size = new System.Drawing.Size(80, 70);
            this.btn_anasayfa.TabIndex = 83;
            this.btn_anasayfa.UseVisualStyleBackColor = false;
            this.btn_anasayfa.Click += new System.EventHandler(this.btn_anasayfa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemAnaliziveTasarımı.Properties.Resources.otobüs;
            this.pictureBox1.Location = new System.Drawing.Point(24, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(294, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 81;
            this.label2.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(294, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 80;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // txt_asifre
            // 
            this.txt_asifre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_asifre.Location = new System.Drawing.Point(411, 236);
            this.txt_asifre.Name = "txt_asifre";
            this.txt_asifre.Size = new System.Drawing.Size(186, 27);
            this.txt_asifre.TabIndex = 78;
            // 
            // txt_akadi
            // 
            this.txt_akadi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_akadi.Location = new System.Drawing.Point(411, 165);
            this.txt_akadi.Name = "txt_akadi";
            this.txt_akadi.Size = new System.Drawing.Size(186, 27);
            this.txt_akadi.TabIndex = 79;
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.White;
            this.btn_giris.FlatAppearance.BorderSize = 0;
            this.btn_giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_giris.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_giris.ImageKey = "login.png";
            this.btn_giris.ImageList = this.ımageList1;
            this.btn_giris.Location = new System.Drawing.Point(363, 318);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(173, 62);
            this.btn_giris.TabIndex = 77;
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageKey = "kapat.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(596, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 70);
            this.button1.TabIndex = 85;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // f_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(676, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_anasayfa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_asifre);
            this.Controls.Add(this.txt_akadi);
            this.Controls.Add(this.btn_giris);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "f_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.f_admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btn_anasayfa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_asifre;
        private System.Windows.Forms.TextBox txt_akadi;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Button button1;

    }
}