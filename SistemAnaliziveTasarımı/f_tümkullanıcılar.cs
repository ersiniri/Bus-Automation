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
    public partial class f_tümkullanıcılar : Form
    {
        public f_tümkullanıcılar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=EXTRMER\SQLEXPRESS;Initial Catalog=Otobüsdb;Integrated Security=True");
        void KayıtGetir()
        {
            baglanti.Open();
            string kayit = "SELECT * from tbl_Kullanıcıbilgiler";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void f_tümkullanıcılar_Load(object sender, EventArgs e)
        {
            KayıtGetir();
        }
        void KayıtSil(int Kullanıcı_ID)
        {
            string sql = "DELETE FROM tbl_Kullanıcıbilgiler WHERE Kullanıcı_ID=@kullanıcıid";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@kullanıcıid", Kullanıcı_ID);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string message = Properties.Strings.mesajemin;
            string caption = Properties.Strings.mesajbilgi;
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
                {
                    int Kullanıcı_ID = Convert.ToInt32(drow.Cells[0].Value);
                    KayıtSil(Kullanıcı_ID);
                    MessageBox.Show(Properties.Strings.mesajsil, Properties.Strings.mesajbilgi, MessageBoxButtons.OK);
                }
            }
            KayıtGetir();
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
            string kayit = "SELECT * from tbl_Kullanıcıbilgiler where Kullanıcı_ID='" + textBox1.Text + "'";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
    }
}
