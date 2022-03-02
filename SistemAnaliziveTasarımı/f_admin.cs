using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemAnaliziveTasarımı
{
    public partial class f_admin : Form
    {
        public f_admin()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=EXTRMER\SQLEXPRESS;Initial Catalog=Otobüsdb;Integrated Security=True");
            SqlCommand komut;
            SqlDataReader reader;

            {
                komut = new SqlCommand("Select *From tbl_Yonetici where YoneticiAdı='" + txt_akadi.Text + "'and YoneticiSifre='" + txt_asifre.Text + "'", baglanti);
                baglanti.Open();
                reader = komut.ExecuteReader();
                if (txt_akadi.Text==""||txt_asifre.Text=="")
                {
                    MessageBox.Show(Properties.Strings.mesajboş,Properties.Strings.mesajuyarı, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (reader.Read())
                {
                    MessageBox.Show(Properties.Strings.mesajgiriş,Properties.Strings.mesajbilgi, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    f_adminbilgiler fadminbilgiler = new f_adminbilgiler();
                    fadminbilgiler.Show();


                }
                else
                {
                    MessageBox.Show(Properties.Strings.mesajhatalıgiriş,Properties.Strings.mesajuyarı, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                baglanti.Close();
                komut.Dispose();

            }
        }
      
        private void f_admin_Load(object sender, EventArgs e)
        {
            label3.Text = Properties.Strings.lbl_admingirişi;
            label1.Text = Properties.Strings.lbl_kullanıcıadı;
            label2.Text = Properties.Strings.lbl_şifre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            f_giriş giriş = new f_giriş();
            giriş.Show();
            this.Hide();

        }
    }
}
