using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace AracAlSatKirala
{
    public partial class FrmMusteriListe : Form
    {
        public FrmMusteriListe()
        {
            InitializeComponent();
        }

        //SqlConnection baglanti = new SqlConnection(@"//Data Source=DESKTOP-GSOHK16\\SQLEXPRESS;Initial Catalog=AracProje;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-GSOHK16\SQLEXPRESS;Initial Catalog=AracProje;Integrated Security=True");

        //---------1---------------------
        private void veriler() 
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkleme", baglanti);
            SqlDataReader oku = komut.ExecuteReader();


            while (oku.Read()) 
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["isim"].ToString());
                ekle.SubItems.Add(oku["soyad"].ToString());
                ekle.SubItems.Add(oku["yas"].ToString());
                ekle.SubItems.Add(oku["cinsiyet"].ToString());
                ekle.SubItems.Add(oku["tc"].ToString());
                ekle.SubItems.Add(oku["email"].ToString());
                ekle.SubItems.Add(oku["adres"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["kayittarih"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();

        }



        private void FrmMusteriListe_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label10.Text = DateTime.Now.ToLongDateString();
            label11.Text = DateTime.Now.ToLongTimeString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void btnarama_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            veriler();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //baglanti.Open();
            //SqlCommand komut = new SqlCommand("update MusteriEkleme set isim='" + TxtIsım.Text + "',soyad='" + TxtSoyad.Text + "',yas='" + TxtYas.Text + "',cinsiyet='" + ComboCin.Text + "',tc='" + MaskedTC.Text + "',email='" + TxtEmail.Text + "',adres='" + TxtAdres.Text + "',telefon'" + MaskedTel.Text + "',kayittarih='" + dateTimePicker1.Text"'where id =" + id + " ", baglanti);
            SqlCommand komut = new SqlCommand("UPDATE MusteriEkleme SET isim=@isim, soyad=@soyad, yas=@yas, cinsiyet=@cinsiyet, tc=@tc, email=@email, adres=@adres, telefon=@telefon, kayittarih=@kayittarih WHERE id=@id", baglanti);
            komut.Parameters.AddWithValue("@isim", TxtIsım.Text);
            komut.Parameters.AddWithValue("@soyad", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@yas", TxtYas.Text);
            komut.Parameters.AddWithValue("@cinsiyet", ComboCin.Text);
            komut.Parameters.AddWithValue("@tc", MaskedTC.Text);
            komut.Parameters.AddWithValue("@email", TxtEmail.Text);
            komut.Parameters.AddWithValue("@adres", TxtAdres.Text);
            komut.Parameters.AddWithValue("@telefon", MaskedTel.Text);
            komut.Parameters.AddWithValue("@kayittarih", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@id", id);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();


            MessageBox.Show("Kayıt Güncellendi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from MusteriEkleme where id=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close() ;
            veriler();

            MessageBox.Show("Kayıt Silindi");
        }

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtIsım.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            TxtYas.Text = listView1.SelectedItems[0].SubItems[3].Text;
            ComboCin.Text = listView1.SelectedItems[0].SubItems[4].Text;
            MaskedTC.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtEmail.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtAdres.Text = listView1.SelectedItems[0].SubItems[7].Text;
            MaskedTel.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[9].Text;

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
//Data Source=DESKTOP-GSOHK16\SQLEXPRESS;Initial Catalog=AracProje;Integrated Security=True