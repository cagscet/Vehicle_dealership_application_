using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracAlSatKirala
{
    public partial class btnkayt : Form
    {
        public btnkayt()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GSOHK16\\SQLEXPRESS;Initial Catalog=AracProje;Integrated Security=True");

        private void veriler()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from AracEkleme", baglanti);
            SqlDataReader oku = komut.ExecuteReader();


            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["marka"].ToString());
                ekle.SubItems.Add(oku["model"].ToString());
               
                ekle.SubItems.Add(oku["yıl"].ToString());
                ekle.SubItems.Add(oku["renk"].ToString());
                ekle.SubItems.Add(oku["km"].ToString());
                ekle.SubItems.Add(oku["vites"].ToString());
                ekle.SubItems.Add(oku["kasatipi"].ToString());
                ekle.SubItems.Add(oku["yakit"].ToString());
                ekle.SubItems.Add(oku["motorgucu"].ToString());
                //ekle.SubItems.Add(oku["kayittarih"].ToString());
                //ekle.SubItems.Add(oku["aracındeger"].ToString());
                //ekle.SubItems.Add(oku["arackira"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();

        }

        private void veriler2() 
        { 
            listView1.Items.Clear(); 
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from arackira ", baglanti);
            SqlDataReader okuma = cmd.ExecuteReader();

            while (okuma.Read()) 
            {
                ListViewItem ekleme = new ListViewItem();
                ekleme.Text = okuma["id"].ToString();
                ekleme.SubItems.Add(okuma["isim"].ToString());
                ekleme.SubItems.Add(okuma["soyad"].ToString());
                ekleme.SubItems.Add(okuma["arac"].ToString());
                ekleme.SubItems.Add(okuma["ucret"].ToString());
                ekleme.SubItems.Add(okuma["tarih1"].ToString());
                ekleme.SubItems.Add(okuma["tarih2"].ToString());
                ekleme.SubItems.Add(okuma["tutar"].ToString());
                listView2.Items.Add(ekleme);

            }
            baglanti.Close ();
        }


        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            /*int ucret;
            int tutar;

            DateTime KucukTarih = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime buyuktarih = Convert.ToDateTime(dateTimePicker2.Text);

            TimeSpan sonuc = buyuktarih - KucukTarih;

            txtgun.Text = sonuc.TotalDays.ToString();

            tutar = Convert.ToInt32(txtgun.Text) * Convert.ToInt16(txtucret.Text);
            txttutar.Text = tutar.ToString();*/





            //tutar = Convert.ToInt16(label9.Text) * Convert.ToInt16(txtucret.Text);
            //txttutar.Text = tutar.ToString();

        }

        private void Frmarackira_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            veriler();
        }

        private void btntemiz_Click(object sender, EventArgs e)
        {
            txtisim.Clear();
            txtsoy.Clear();
            txttutar.Clear();
            txtarac.Clear();
            txtucret.Clear();
            txtgun.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //int ucret;
            int tutar;

            DateTime KucukTarih = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime buyuktarih = Convert.ToDateTime(dateTimePicker2.Text);

            TimeSpan sonuc = buyuktarih - KucukTarih;

            txtgun.Text = sonuc.TotalDays.ToString();

            tutar = Convert.ToInt32(txtgun.Text) * Convert.ToInt16(txtucret.Text);
            txttutar.Text = tutar.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into arackira (isim,soyad,arac,ucret,tarih1,tarih2,tutar) values ('" + txtisim.Text + "','" + txtsoy.Text + "','" + txtarac.Text + "','" + txtucret.Text + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "','" + txttutar.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Araç Kayıdınız Alınmıştır.");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            veriler2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Form1 fr = new Form1();
           fr.Show();
           this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label13.Text = DateTime.Now.ToLongDateString();
            label9.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
