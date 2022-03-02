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
    public partial class f_kullanici : Form
    {
        public f_kullanici()
        {
            InitializeComponent();
        }
        static public long id;
        SqlConnection baglanti = new SqlConnection(@"Data Source=EXTRMER\SQLEXPRESS;Initial Catalog=Otobüsdb;Integrated Security=True");
        private void btn_giris_Click(object sender, EventArgs e)
        {
            bool kullanıcıvarmi = false;
            baglanti.Open();
            {
                SqlCommand komut = new SqlCommand("select * from tbl_Kullanıcıbilgiler where Kullanıcı_TC='" + txt_kadi.Text + "' and Kullanıcı_Şifre='" + txt_ksifre.Text + "'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    
                   
                    
                        kullanıcıvarmi = true;
                        id = Convert.ToInt64(oku["Kullanıcı_TC"]);
                    
                }
                if (txt_kadi.Text=="" || txt_ksifre.Text=="" )
                {
                    MessageBox.Show(Properties.Strings.mesajboş, Properties.Strings.mesajuyarı,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    
                }
                else if (kullanıcıvarmi)
                {

                    MessageBox.Show(Properties.Strings.mesajgiriş, Properties.Strings.mesajbilgi, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    f_kbilgiler fkbilgiler = new f_kbilgiler();
                    fkbilgiler.Show();
                    this.Hide();
                }
                else 
                {
                    MessageBox.Show(Properties.Strings.mesajhatalıgiriş, Properties.Strings.mesajuyarı, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                baglanti.Close();
                komut.Dispose();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            f_kullanicikayıt kkayıt = new f_kullanicikayıt();
            kkayıt.Show();
            this.Hide();
        }

        private void f_kullanici_Load(object sender, EventArgs e)
        {
            label1.Text=Properties.Strings.lbl_kullanıcıtc;
                label2.Text=Properties.Strings.lbl_şifre;
                    label3.Text=Properties.Strings.lbl_kullanıcıgirişi;
                    label4.Text = Properties.Strings.lbl_kayıtol;
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            f_giriş giriş = new f_giriş();
            giriş.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
