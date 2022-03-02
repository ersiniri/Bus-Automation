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
    public partial class f_yardım : Form
    {
        public f_yardım()
        {
            InitializeComponent();
        }
        public static int sırano = 1;
        private void f_yardım_Load(object sender, EventArgs e)
        {
            pictureBox1.Image =Image.FromFile(Application.StartupPath+"\\resimler\\"+1+".png");
            label1.Text = "Resim 1 ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sırano==6)
            {
                sırano = 0;
            }
            sırano += 1;
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\resimler\\" + sırano + ".png");
            label1.Text = "Resim" + sırano;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sırano == 1)
            {
                sırano = 7;
            }
            sırano -= 1;
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\resimler\\" + sırano + ".png");
            label1.Text = "Resim" + sırano;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f_giriş giriş = new f_giriş();
            giriş.Show();
            this.Hide();
        }
    }
}
