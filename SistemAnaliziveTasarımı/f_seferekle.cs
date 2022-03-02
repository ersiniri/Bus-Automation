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
    public partial class f_seferekle : Form
    {
        public f_seferekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=EXTRMER\\SQLEXPRESS;Initial Catalog=Otobüsdb;Integrated Security=True");
        private void f_seferekle_Load(object sender, EventArgs e)
        {
            illerigetir();
            lblkalkış.Text=Properties.Strings.lbl_gidiş;
                lblvarış.Text=Properties.Strings.lbl_geliş;
                lbltarih.Text=Properties.Strings.lbl_tarih;
                lblsaat.Text=Properties.Strings.lbl_saat;
                lblfiyat.Text=Properties.Strings.lbl_fiyat;
                lblseferadı.Text = Properties.Strings.lbl_seferadı;
        }
        void illerigetir()
        {
            SqlCommand komut1 = new SqlCommand();
            baglanti.Open();
            komut1.Connection = baglanti;
            komut1.CommandText = "SELECT * FROM iller";
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
               comboBox1.Items.Add(oku1["isim"]);
               comboBox2.Items.Add(oku1["isim"]);

            }
            baglanti.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox2.SelectedItem + "-" + comboBox1.SelectedItem ;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedItem + "-" + comboBox2.SelectedItem;
        }

        private void btn_seferekle_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" ||textBox2.Text==""|| comboBox3.Text == "")
            {
                MessageBox.Show(Properties.Strings.mesajboş, Properties.Strings.mesajuyarı, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string message = Properties.Strings.mesajemin;
                string caption = Properties.Strings.mesajbilgi;
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("INSERT INTO Seferler (Sefer_Adı,Sefer_Tarihi,Sefer_Saati,Fiyat) values(@ad,@tarih,@saat,@fiyat)", baglanti);
                    komut.Parameters.AddWithValue("@ad", textBox1.Text);
                    komut.Parameters.AddWithValue("@tarih", dateTimePicker1.Text);
                    komut.Parameters.AddWithValue("@saat", comboBox3.SelectedItem);
                    komut.Parameters.AddWithValue("@fiyat", textBox2.Text);

                    komut.ExecuteNonQuery();
                    komut = new SqlCommand("INSERT INTO Seferbilgiler (Sefer_Adı)values(@ad)", baglanti);
                    komut.Parameters.AddWithValue("@ad", textBox1.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show(Properties.Strings.mesajkayıt, Properties.Strings.mesajuyarı, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    baglanti.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f_adminbilgiler abilgi = new f_adminbilgiler();
            abilgi.Show();
            this.Hide();
        }

        private void tümBiletleriGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_tümseferler seferler = new f_tümseferler();
            seferler.Show();
            this.Hide();
        }
    }
}
