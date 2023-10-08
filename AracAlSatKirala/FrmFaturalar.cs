using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Reflection.Emit;

namespace AracAlSatKirala
{
    public partial class FrmFaturalar : Form
    {
        public FrmFaturalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GSOHK16\\SQLEXPRESS;Initial Catalog=AracProje;Integrated Security=True");


        private void veriler()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from fatura", baglanti);
            SqlDataReader oku = komut.ExecuteReader();


            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["cesidi"].ToString());
                ekle.SubItems.Add(oku["hizmetveren"].ToString());
                ekle.SubItems.Add(oku["tutar"].ToString());
                ekle.SubItems.Add(oku["tarih"].ToString());
               

                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into fatura (cesidi,hizmetveren,tutar,tarih) values(@cesidi,@hizmetveren,@tutar,@tarih)", baglanti);
            komut.Parameters.AddWithValue("cesidi", combofatura.Text);
            komut.Parameters.AddWithValue("hizmetveren",txthizmet.Text);    
            komut.Parameters.AddWithValue("tutar",txttutar.Text);
            komut.Parameters.AddWithValue("tarih", dateTimePicker1.Value);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Fatura Girişiniz Başarılı");
        }

        private void FrmFaturalar_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            veriler();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label12.Text = DateTime.Now.ToLongDateString();
            label11.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
