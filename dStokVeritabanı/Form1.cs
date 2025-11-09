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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void kategorigoster()
        {
            baglanti.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from kategoriler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            baglanti.Close();
        }

        SqlConnection baglanti = new SqlConnection("Data Source= localhost\\SQLEXPRESS; Initial Catalog=Stok_Takip; User ID=sa; Password=Asim18");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand ekle = new SqlCommand("insert into kategoriler(kategori_adi) values(@katAd)", baglanti);
            ekle.Parameters.AddWithValue("@katAd", textBox1.Text);
            ekle.ExecuteNonQuery();
            textBox1.Clear();
            baglanti.Close();

            kategorigoster();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kategorigoster();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from kategoriler where kategori_id=@katId;", baglanti);
            sil.Parameters.AddWithValue("katId", dataGridView1.CurrentRow.Cells[0].Value);
            sil.ExecuteNonQuery();

            baglanti.Close();

            kategorigoster();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("update kategoriler set kategori_Adi=@katAdi where kategori_id=@katId;", baglanti);
            guncelle.Parameters.AddWithValue("@katAdi", textBox1.Text);
            guncelle.Parameters.AddWithValue("@katId", dataGridView1.CurrentRow.Cells[0].Value);
            guncelle.ExecuteNonQuery();

            baglanti.Close();

            kategorigoster();

            textBox1.Clear();
        }
    }
}