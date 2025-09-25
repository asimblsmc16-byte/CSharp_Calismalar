using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Data Source = LAB7-01; Initial Catalog = Rehber; User ID = sa; Password = 123456;Encrypt = False;");

            baglan.Open();

            SqlCommand ekle = new SqlCommand("insert into kisiler (Ad,Soyad,Telefon,Adres,Eposta) values(@ad,@soyad,@telefon,@adres,@eposta)",baglan);

            ekle.Parameters.AddWithValue("@ad",txtad.Text);
            ekle.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            ekle.Parameters.AddWithValue("@telefon", txttel.Text);
            ekle.Parameters.AddWithValue("@adres", txtadres.Text);
            ekle.Parameters.AddWithValue("@eposta", txteposta.Text);

            ekle.ExecuteNonQuery();

            txtad.Clear();
            txtsoyad.Clear();
            txttel.Clear();
            txtadres.Clear();
            txteposta.Clear();
        }
    }
}
