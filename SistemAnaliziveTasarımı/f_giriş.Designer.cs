namespace SistemAnaliziveTasarımı
{
    partial class f_giriş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_giriş));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.türkçeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingilizceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_kullanici = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dilToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(560, 30);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dilToolStripMenuItem
            // 
            this.dilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.türkçeToolStripMenuItem,
            this.ingilizceToolStripMenuItem});
            this.dilToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dilToolStripMenuItem.Name = "dilToolStripMenuItem";
            this.dilToolStripMenuItem.Size = new System.Drawing.Size(42, 26);
            this.dilToolStripMenuItem.Text = "Dil";
            // 
            // türkçeToolStripMenuItem
            // 
            this.türkçeToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.türkçeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.türkçeToolStripMenuItem.Name = "türkçeToolStripMenuItem";
            this.türkçeToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.türkçeToolStripMenuItem.Text = "Türkçe";
            this.türkçeToolStripMenuItem.Click += new System.EventHandler(this.türkçeToolStripMenuItem_Click);
            // 
            // ingilizceToolStripMenuItem
            // 
            this.ingilizceToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.ingilizceToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ingilizceToolStripMenuItem.Name = "ingilizceToolStripMenuItem";
            this.ingilizceToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.ingilizceToolStripMenuItem.Text = "İngilizce";
            this.ingilizceToolStripMenuItem.Click += new System.EventHandler(this.ingilizceToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemAnaliziveTasarımı.Properties.Resources.otobüs;
            this.pictureBox1.Location = new System.Drawing.Point(270, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btn_kullanici
            // 
            this.btn_kullanici.BackColor = System.Drawing.Color.White;
            this.btn_kullanici.FlatAppearance.BorderSize = 0;
            this.btn_kullanici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kullanici.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kullanici.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_kullanici.ImageKey = "kullanıcı.png";
            this.btn_kullanici.ImageList = this.ımageList1;
            this.btn_kullanici.Location = new System.Drawing.Point(40, 263);
            this.btn_kullanici.Name = "btn_kullanici";
            this.btn_kullanici.Size = new System.Drawing.Size(172, 81);
            this.btn_kullanici.TabIndex = 4;
            this.btn_kullanici.Text = "Kullanıcı Girişi";
            this.btn_kullanici.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_kullanici.UseVisualStyleBackColor = false;
            this.btn_kullanici.Click += new System.EventHandler(this.btn_kullanici_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.BackColor = System.Drawing.Color.White;
            this.btn_admin.FlatAppearance.BorderSize = 0;
            this.btn_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_admin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_admin.ImageKey = "admin.png";
            this.btn_admin.ImageList = this.ımageList1;
            this.btn_admin.Location = new System.Drawing.Point(40, 132);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(172, 81);
            this.btn_admin.TabIndex = 3;
            this.btn_admin.Text = "Yönetici Girişi";
            this.btn_admin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_admin.UseVisualStyleBackColor = false;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
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
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageKey = "kapat.png";
            this.button1.ImageList = this.ımageList2;
            this.button1.Location = new System.Drawing.Point(499, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 55);
            this.button1.TabIndex = 94;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.yardımToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(85, 26);
            this.yardımToolStripMenuItem.Text = "Yardım";
            this.yardımToolStripMenuItem.Click += new System.EventHandler(this.yardımToolStripMenuItem_Click);
            // 
            // f_giriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(560, 375);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_kullanici);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "f_giriş";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.f_giriş_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btn_kullanici;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem türkçeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingilizceToolStripMenuItem;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
    }
}

