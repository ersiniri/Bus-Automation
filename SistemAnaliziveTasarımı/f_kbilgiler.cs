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
    public partial class f_kbilgiler : Form
    {
        public f_kbilgiler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=EXTRMER\SQLEXPRESS;Initial Catalog=Otobüsdb;Integrated Security=True");
        private void f_kbilgiler_Load(object sender, EventArgs e)
        {
            lblisim.Text = Properties.Strings.lbl_isim;
            lblsoyisim.Text = Properties.Strings.lbl_soyisim;
            lbltel.Text = Properties.Strings.lbl_tel;
            lblkadı.Text = Properties.Strings.lbl_kullanıcıadı;
            lblşifre.Text = Properties.Strings.lbl_şifre;
            biletSatınAlToolStripMenuItem.Text = Properties.Strings.menü_biletsatınal;
            tümBiletlerimToolStripMenuItem.Text = Properties.Strings.menü_tümbiletlerim;
            listView1.Columns[0].Text = Properties.Strings.lbl_tarih;
            listView1.Columns[1].Text = Properties.Strings.lbl_seferadı;
            listView1.Columns[2].Text = Properties.Strings.lbl_saat;
            listView1.Columns[3].Text = Properties.Strings.lbl_koltukno;
            listView1.Columns[4].Text = Properties.Strings.lbl_fiyat;
        

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_Kullanıcıbilgiler where Kullanıcı_TC=" + Convert.ToInt64(f_kullanici.id) + "", baglanti);

            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                
                txt_ad.Text = oku["Kullanıcı_Adı"].ToString();
                txt_soyad.Text = oku["Kullanıcı_Soyadı"].ToString();
                txt_tel.Text = oku["Kullanıcı_Tel"].ToString();
                txt_kadı.Text = oku["Kullanıcı_Adı"].ToString();
                txt_kşifre.Text = oku["Kullanıcı_Şifre"].ToString();
                pictureBox1.ImageLocation = oku["Resim_url"].ToString();

                     
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from tbl_Biletbilgiler where Kullanıcı_TC=" + Convert.ToInt64(f_kullanici.id) + "", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                       if (DateTime.Parse(oku2["Sefer_Tarihi"].ToString()) >= DateTime.Parse(DateTime.Now.ToShortDateString()))
                    {
                int sira = listView1.Items.Count;

                listView1.Items.Add(oku2["Sefer_Tarihi"].ToString());
                listView1.Items[sira].SubItems.Add(oku2["Sefer_Adı"].ToString());
                listView1.Items[sira].SubItems.Add(oku2["Sefer_Saati"].ToString());
                listView1.Items[sira].SubItems.Add(oku2["Koltuk_No"].ToString());
                listView1.Items[sira].SubItems.Add(oku2["Fiyat"].ToString());
                                 }
            }
            baglanti.Close();
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update tbl_Kullanıcıbilgiler set Kullanıcı_Şifre='" + txt_kşifre.Text + "' where Kullanıcı_TC=" + Convert.ToInt64(f_kullanici.id) + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show(Properties.Strings.mesajkayıt, Properties.Strings.mesajuyarı, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_fotoekle_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;


            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update tbl_Kullanıcıbilgiler set Resim_url='" + pictureBox1.ImageLocation + "' where Kullanıcı_TC=" + Convert.ToInt64(f_kullanici.id) + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show(Properties.Strings.mesajresim,Properties.Strings.mesajbilgi,MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void biletSatınAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_biletsatış bilet = new f_biletsatış();
            bilet.Show();
            this.Hide();
        }

        private void tümBiletlerimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_kullanıcıbiletler kbilet = new f_kullanıcıbiletler();
            kbilet.Show();
            this.Hide();

        }

     
        private void button3_Click(object sender, EventArgs e)
        {
            f_kullanici kullanıcı = new f_kullanici();
            kullanıcı.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f_giriş giriş = new f_giriş();
            giriş.Show();
            this.Hide();
        }
    }
}
