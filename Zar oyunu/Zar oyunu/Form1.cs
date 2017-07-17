using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int toplambırıncıoyuncu;
        int toplamıkıncıoyuncu;
        int puan;
        int bıtıspuan;
        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            int b;

            a = rastgele.Next(1, 7);//ilk basa hangı sayıdan baslıcagını yazıyoruz ıkıncı sayıyada hangı sayının bır eksıgını almasını
            b = rastgele.Next(1, 7);
            
            lblbıroyuncuzar.Text = a.ToString();
            lblbıroyuncuıkıncızar.Text = b.ToString();

            toplambırıncıoyuncu = toplambırıncıoyuncu + a + b; //burayı eğer toplam = a+b yazarsak her butona basıldıgında toplama yenı deger atar ama bu şekılde yaparsak o zaman toplamın eskı degerıyle a ve beyı toplayıp yenı deger atar.
            label10.Text = toplambırıncıoyuncu.ToString();
            puan = a + b;
            label5.Text = puan.ToString();

            if (a == 1)
            {
                pictureBox1.ImageLocation = "1.jpg";
            }
            if (a == 2)
            {
                pictureBox1.ImageLocation = "2.jpg";
            }
            if (a == 3)
            {
                pictureBox1.ImageLocation = "3.jpg";
            }
            if (a == 4)
            {
                pictureBox1.ImageLocation = "4.jpg";
            }
            if (a == 5)
            {
                pictureBox1.ImageLocation = "5.jpg";
            }
            if (a == 6)
            {
                pictureBox1.ImageLocation = "6.jpg";
            }

            if (b == 1)
            {
                pictureBox2.ImageLocation = "1.jpg";
            }
            if (b == 2)
            {
                pictureBox2.ImageLocation = "2.jpg";
            }
            if (b == 3)
            {
                pictureBox2.ImageLocation = "3.jpg";
            }
            if (b == 4)
            {
                pictureBox2.ImageLocation = "4.jpg";
            }
            if (b == 5)
            {
                pictureBox2.ImageLocation = "5.jpg";
            }
            if (b == 6)
            {
                pictureBox2.ImageLocation = "6.jpg";
            }
            try
            {
                bıtıspuan = int.Parse(textBox1.Text);
                if (toplambırıncıoyuncu >= bıtıspuan)
                {
                    MessageBox.Show("1.Oyuncu Kazandı Tebrikler...");
                }
               button1.Enabled = false;
               button2.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Lütfen bitiş puanını yazınız");
                toplambırıncıoyuncu = 0;
                label10.Text = toplambırıncıoyuncu.ToString();
                toplamıkıncıoyuncu = 0;
                label11.Text = toplamıkıncıoyuncu.ToString();
                puan = 0;
                label5.Text = puan.ToString();
                label2.Text = puan.ToString();
                lblbıroyuncuzar.Text = "0";
                lblbıroyuncuıkıncızar.Text = "0";
                lblıkıncıoyuncubırıncızar.Text = "0";
                lblıkıncıoyuncuıkıncızar.Text = "0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int c;
            int d;

            c = rastgele.Next(1, 7);
            d = rastgele.Next(1, 7);

            lblıkıncıoyuncubırıncızar.Text = c.ToString();
            lblıkıncıoyuncuıkıncızar.Text = d.ToString();

            toplamıkıncıoyuncu = toplamıkıncıoyuncu + c + d;
            label11.Text = toplamıkıncıoyuncu.ToString();
            puan = c + d;

            label2.Text = puan.ToString();

            if (c == 1)
            {
                pictureBox1.ImageLocation = "1.jpg";
            }
            if (c == 2)
            {
                pictureBox1.ImageLocation = "2.jpg";
            }
            if (c == 3)
            {
                pictureBox1.ImageLocation = "3.jpg";
            }
            if (c == 4)
            {
                pictureBox1.ImageLocation = "4.jpg";
            }
            if (c == 5)
            { 
            pictureBox1.ImageLocation = "5.jpg";
            }
            if (c == 6)
            {
                pictureBox1.ImageLocation = "6.jpg";
            }

            if (d == 1)
            {
                pictureBox2.ImageLocation = "1.jpg";
            }
            if (d == 2)
            {
                pictureBox2.ImageLocation = "2.jpg";
            }
            if (d == 3)
            {
                pictureBox2.ImageLocation = "3.jpg";
            }
            if (d == 4)
            {
                pictureBox2.ImageLocation = "4.jpg";
            }
            if (d == 5)
            {
                pictureBox2.ImageLocation = "5.jpg";
            }
            if (d == 6)
            {
                pictureBox2.ImageLocation = "6.jpg";
            }

            bıtıspuan = int.Parse(textBox1.Text);
            if (toplamıkıncıoyuncu >= bıtıspuan)
            {
                MessageBox.Show("2.Oyuncu kazandı Tebrikler...");
            }

            button2.Enabled = false;
            button1.Enabled = true;
         }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            toplambırıncıoyuncu = 0;
            label10.Text = toplambırıncıoyuncu.ToString();
            toplamıkıncıoyuncu = 0;
            label11.Text = toplamıkıncıoyuncu.ToString();

            puan = 0;
            label5.Text = puan.ToString();
            label2.Text = puan.ToString();
            
            bıtıspuan = 0;

            lblbıroyuncuzar.Text = "0";
            lblbıroyuncuıkıncızar.Text = "0";
            lblıkıncıoyuncubırıncızar.Text = "0";
            lblıkıncıoyuncuıkıncızar.Text = "0";

            button1.Enabled = true;
            button2.Enabled = true;

        }
    }
}
