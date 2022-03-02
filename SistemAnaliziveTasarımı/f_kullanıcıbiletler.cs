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
    public partial class f_kullanıcıbiletler : Form
    {
        public f_kullanıcıbiletler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=EXTRMER\SQLEXPRESS;Initial Catalog=Otobüsdb;Integrated Security=True");
        void kayıtgetir()
    {
            baglanti.Open();
            string kayit = "SELECT * from tbl_BiletBilgiler where Kullanıcı_TC=" + Convert.ToInt64(f_kullanici.id) + "";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
    }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "SELECT * from tbl_BiletBilgiler where Sefer_Tarihi='" + dateTimePicker1.Text + "'and Kullanıcı_TC=" + Convert.ToInt64(f_kullanici.id) + "";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void f_kullanıcıbiletler_Load(object sender, EventArgs e)
        {
            kayıtgetir();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            f_kbilgiler kbilgi = new f_kbilgiler();
            kbilgi.Show();
            this.Hide();
        }
    }
}
