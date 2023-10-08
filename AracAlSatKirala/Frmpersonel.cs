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

namespace AracAlSatKirala
{
    public partial class Frmpersonel : Form
    {
        public Frmpersonel()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GSOHK16\\SQLEXPRESS;Initial Catalog=AracProje;Integrated Security=True");
        private void Frmpersonel_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void BtnAracKayit_Click(object sender, EventArgs e)
        {

            /* baglanti.Open();
             SqlCommand komut = new SqlCommand("insert into personel (isim,soyad,cinsiyet,yas,tc,tel,email,kayit) values ('" + txtisim.Text + "','" + txtsoyad.Text + "','" + combocin.Text + "','" + txtyas.Text + "','" + maskedtc.Text + "','" + maskedtel.Text + "','" + txtmail.Text + "','" + datetime.Value.ToString("yyyy-MM-dd") + "')", baglanti);
             komut.ExecuteNonQuery();
             baglanti.Close();
             MessageBox.Show("Araç Kayıdınız Alınmıştır.");        bu şekilde doğru ve kısa */

            SqlCommand komut = new SqlCommand("INSERT INTO personel (isim, soyad, cinsiyet, yas, tc, tel, email, kayit,maas) VALUES (@isim, @soyad, @cinsiyet, @yas, @tc, @tel, @email, @kayit,@maas)", baglanti);

            komut.Parameters.AddWithValue("@isim", txtisim.Text);
            komut.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            komut.Parameters.AddWithValue("@cinsiyet", combocin.Text);
            komut.Parameters.AddWithValue("@yas", txtyas.Text);
            komut.Parameters.AddWithValue("@tc", maskedtc.Text);
            komut.Parameters.AddWithValue("@tel", maskedtel.Text);
            komut.Parameters.AddWithValue("@email", txtmail.Text);
            komut.Parameters.AddWithValue("@kayit", datetime.Value);
            komut.Parameters.AddWithValue("@maas", txtmaas.Text);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Kayıdınız Alınmıştır.");



        }
    }
}
