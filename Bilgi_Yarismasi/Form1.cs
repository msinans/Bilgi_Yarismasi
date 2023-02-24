using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruno++;
            lblSoru.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Türkiye'nin başkenti neresidir?";
                btnA.Text = "Sakarya";
                btnB.Text = "Kayseri";
                btnC.Text = "Ordu";
                btnD.Text = "Ankara";
                label4.Text = "Ankara";
            }

            if (soruno == 2)
            {
                richTextBox1.Text = "T.C. hangi yıl kurulmuştur?";
                btnA.Text = "1920";
                btnB.Text = "1923";
                btnC.Text = "1922";
                btnD.Text = "1921";
                label4.Text = "1923";
            }

            if (soruno == 3)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi tek sayıdır?";
                btnA.Text = "7";
                btnB.Text = "4";
                btnC.Text = "6";
                btnD.Text = "2";
                label4.Text = "7";
                btnSonraki.Text = "Sonuclar";
            }

            if (soruno == 4)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;
                MessageBox.Show("Doğru Sayısı: " + dogru + "\n" + "Yanlış Sayısı: " + yanlis);
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnA.Text;

            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }
        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label5.Text = btnB.Text;

            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label5.Text = btnC.Text;

            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label5.Text = btnD.Text;

            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }
    }
}
