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
    public partial class f_tümseferler : Form
    {
        public f_tümseferler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=EXTRMER\SQLEXPRESS;Initial Catalog=Otobüsdb;Integrated Security=True");
        void KayıtSil(int Seferid)
        {
            string sql = "DELETE FROM Seferler WHERE Seferid=@seferid";
            string sql1 = "DELETE FROM Seferbilgiler where seferid=@seferID";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@seferid", Seferid);
            komut = new SqlCommand(sql1, baglanti);
            komut.Parameters.AddWithValue("@seferID", Seferid);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        void KayıtGetir()
        {
            baglanti.Open();
            string kayit = "SELECT * from Seferler";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void f_tümseferler_Load(object sender, EventArgs e)
        {
            KayıtGetir();
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
                    int Seferid = Convert.ToInt32(drow.Cells[0].Value);
                    KayıtSil(Seferid);
                    MessageBox.Show(Properties.Strings.mesajsil, Properties.Strings.mesajbilgi, MessageBoxButtons.OK);
                    KayıtGetir();
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "SELECT * from Seferler where Sefer_Tarihi='" + dateTimePicker1.Text + "'";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f_seferekle seferekle = new f_seferekle();
            seferekle.Show();
            this.Hide();
        }
    }
}
