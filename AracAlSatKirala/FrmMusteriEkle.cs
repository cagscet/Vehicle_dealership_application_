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
    public partial class FrmMusteriEkle : Form
    {
        public FrmMusteriEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GSOHK16\\SQLEXPRESS;Initial Catalog=AracProje;Integrated Security=True");


        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();

        }

        private void BtnMusteriEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriEkleme (isim,soyad,yas,cinsiyet,tc,email,adres,telefon,kayittarih) values ('" + TxtIsım.Text + "','" + TxtSoyad.Text + "','" + TxtYas.Text + "','" + ComboCin.Text + "','" + MaskedTC.Text + "','" + TxtEmail.Text + "','" + TxtAdres.Text + "','" + MaskedTel.Text + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Eklendi");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMusteriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
//Data Source=DESKTOP-GSOHK16\SQLEXPRESS;Initial Catalog=AracProje;Integrated Security=True