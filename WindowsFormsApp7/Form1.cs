using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Sekiller
        {
            private int a;
            public Sekiller(int b)
            {
                this.a = b;
            }
            public int kare()
            {
                return a * a;
            }
            public int kup()
            {
                return a * a * a;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int ab, sayi;
            ab = Convert.ToInt32(textBox1.Text);
            Sekiller yenisayi = new Sekiller(ab);
            if (comboBox1.SelectedIndex == 0)
            {
                sayi = yenisayi.kare();
                listBox1.Items.Add(sayi);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                sayi = yenisayi.kup();
                listBox1.Items.Add(sayi);
            }
        }
        class KareKup
        {
            private int a, b;
            public KareKup(int uzun, int kisa)
            {
                this.a = uzun;
                this.b = kisa;
            }
            public int Cevre()
            {
                return 2 * (a + b);
            }
            public int Alan()
            {
                return a * b;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int alan, cevre, uzun2, kisa2;
            uzun2 = Convert.ToInt32(textBox2.Text);
            kisa2 = Convert.ToInt32(textBox3.Text);
            KareKup yeniS = new KareKup(uzun2, kisa2);
            alan = yeniS.Alan();
            cevre = yeniS.Cevre();
            textBox4.Text = cevre.ToString();
            textBox5.Text = alan.ToString();
        }
        class Ogrenci
        {
            public string Ad;
            public int Yas;
            public string sinif;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Ogrenci asım = new Ogrenci();
            asım.Ad = "Asım";
            asım.Yas = 17;
            asım.sinif = "10/A";
            MessageBox.Show("Öğrencinin Adı :" + asım.Ad);
            MessageBox.Show("Öğrencinin Yaşı :" + asım.Yas);
            MessageBox.Show("Öğrencinin Sınıfı :" + asım.sinif);
        }
    }
}