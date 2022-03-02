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
    public partial class f_tümbiletler : Form
    {
        public f_tümbiletler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=EXTRMER\SQLEXPRESS;Initial Catalog=Otobüsdb;Integrated Security=True");
        void KayıtGetir()
        {
            baglanti.Open();
            string kayit = "SELECT * from tbl_BiletBilgiler";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void toplamücret()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(Fiyat) from tbl_BiletBilgiler ", baglanti);
            label1.Text = "Toplam=" + komut.ExecuteScalar();

            baglanti.Close();
        }
        private void f_tümbiletler_Load(object sender, EventArgs e)
        {
            KayıtGetir();
            toplamücret();
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "SELECT * from tbl_BiletBilgiler where Sefer_Tarihi='" +  dateTimePicker1.Text + "'";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Hepsini Getir":
                    baglanti.Open();
            string kayit = "SELECT * from tbl_BiletBilgiler" ;
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
                    
            dataGridView1.DataSource = dt;
            baglanti.Close();

                    break;
                case  "En Çok Alınan Koltuk":
                     baglanti.Open();
                     string kayit1 = "SELECT Koltuk_No,count(*) FROM tbl_BiletBilgiler GROUP BY Koltuk_No HAVING COUNT(*) > 1";
            SqlCommand komut1 = new SqlCommand(kayit1, baglanti);
            SqlDataAdapter da1 = new SqlDataAdapter(komut1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            baglanti.Close();
            dataGridView1.Columns[1].HeaderText = "Adet";
                    break;
                case "En Çok Seyehat Edilen Sefer":
                    baglanti.Open();
                     string kayit2 = "SELECT Sefer_Adı,count(*) FROM tbl_BiletBilgiler GROUP BY Sefer_Adı HAVING COUNT(1) > 1";
                    
            SqlCommand komut2 = new SqlCommand(kayit2, baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            baglanti.Close();
            dataGridView1.Columns[1].HeaderText = "Adet";
                    break;
                case "En Çok Seyehat Edilen Tarih":
                    baglanti.Open();
                    string kayit3 = "SELECT Sefer_Tarihi,count(*) FROM tbl_BiletBilgiler GROUP BY Sefer_Tarihi HAVING COUNT(*) > 1";
            SqlCommand komut3 = new SqlCommand(kayit3, baglanti);
            SqlDataAdapter da3 = new SqlDataAdapter(komut3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
            baglanti.Close();
            dataGridView1.Columns[1].HeaderText = "Adet";
                    break;
                case "En Çok Seyehat Edilen Saat":
                    baglanti.Open();
                    string kayit4 = "SELECT Sefer_Saati,count(*) FROM tbl_BiletBilgiler GROUP BY Sefer_Saati HAVING COUNT(*) > 1";
            SqlCommand komut4 = new SqlCommand(kayit4, baglanti);
            SqlDataAdapter da4 = new SqlDataAdapter(komut4);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            dataGridView1.DataSource = dt4;
            baglanti.Close();
            dataGridView1.Columns[1].HeaderText = "Adet";
                    break;
                default:
                    break;
            }
        }
        void KayıtSil(int Bilet_ID)
        {
            string sql = "DELETE FROM tbl_BiletBilgiler WHERE Bilet_ID='" +49 + "'";
           SqlCommand komut = new SqlCommand(sql, baglanti);
            
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
             baglanti.Open();
            string kayit = "Delete  from tbl_BiletBilgiler where Bilet_ID='" + 49 + "'";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            
            
        }

    

        private void button2_Click(object sender, EventArgs e)
        {

            f_adminbilgiler abilgi = new f_adminbilgiler();
            abilgi.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "SELECT * from tbl_BiletBilgiler where Bilet_ID='" + textBox1.Text + "'";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
    }
}
