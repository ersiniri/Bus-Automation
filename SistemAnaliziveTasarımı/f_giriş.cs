using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemAnaliziveTasarımı
{
    public partial class f_giriş : Form
    {
        public f_giriş()
        {
            InitializeComponent();
        }
        f_admin fadmin = new f_admin();
        private void btn_admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            fadmin.Show();
        }
        f_kullanici fkullanici = new f_kullanici();
        private void btn_kullanici_Click(object sender, EventArgs e)
        {
            this.Hide();
            fkullanici.Show();
        }
       
        private void türkçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Properties.Settings.Default.Lang = "tr";
            Properties.Settings.Default.Save();
            Application.Restart();
            
        }

        private void ingilizceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Properties.Settings.Default.Lang = "en";
            Properties.Settings.Default.Save();
            Application.Restart();
        }

        private void f_giriş_Load(object sender, EventArgs e)
        {
            dilToolStripMenuItem.Text = Properties.Strings.menü_dil;
            btn_admin.Text = Properties.Strings.butonyönetici;
            yardımToolStripMenuItem.Text = Properties.Strings.yardım;
            btn_kullanici.Text = Properties.Strings.butonkullanıcı;
            Properties.Settings.Default.Lang = "tr";
            Properties.Settings.Default.Save();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_yardım yardım = new f_yardım();
            yardım.Show();
            this.Hide();
        }



    
    }
}
