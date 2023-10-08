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
    public partial class FrmPersonelList : Form
    {
        public FrmPersonelList()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-GSOHK16\SQLEXPRESS;Initial Catalog=AracProje;Integrated Security=True");

        private void veriler()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from personel", baglanti);
            SqlDataReader oku = komut.ExecuteReader();


            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ID"].ToString();
                ekle.SubItems.Add(oku["isim"].ToString());
                ekle.SubItems.Add(oku["soyad"].ToString());
                ekle.SubItems.Add(oku["cinsiyet"].ToString());
                ekle.SubItems.Add(oku["yas"].ToString());
                ekle.SubItems.Add(oku["tc"].ToString());
                ekle.SubItems.Add(oku["tel"].ToString());
                ekle.SubItems.Add(oku["email"].ToString());
                ekle.SubItems.Add(oku["kayit"].ToString());
                ekle.SubItems.Add(oku["maas"].ToString());
               

                listView1.Items.Add(ekle);

            }
            baglanti.Close();

        }
        private void FrmPersonelList_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            veriler();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }


        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtisim.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtsoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            combocin.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtyas.Text = listView1.SelectedItems[0].SubItems[4].Text;
            maskedtc.Text = listView1.SelectedItems[0].SubItems[5].Text;
            maskedtel.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtmail.Text = listView1.SelectedItems[0].SubItems[7].Text;
            datetime.Text = listView1.SelectedItems[0].SubItems[8].Text;
            txtmaas.Text = listView1.SelectedItems[0].SubItems[9].Text;
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from personel where ID=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler();

            MessageBox.Show("Kayıt Silindi");
        }

        private void btntemiz_Click(object sender, EventArgs e)
        {
            txtisim.Clear();
            txtsoyad.Clear();
            combocin.Text = " ";
            txtyas.Clear();
            maskedtc.Clear();
            maskedtel.Clear();
            txtmail.Clear();
            datetime.Value = DateTime.Now;
            txtmaas.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update personel set isim=@isim,soyad=@soyad,cinsiyet=@cinsiyet,yas=@yas,tc=@tc,tel=@tel,email=@email,kayit=@kayit,maas=@maas WHERE ID=@ID", baglanti);
            komut.Parameters.AddWithValue("@isim", txtisim.Text);
            komut.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            komut.Parameters.AddWithValue("@cinsiyet", combocin.Text);
            komut.Parameters.AddWithValue("@yas", txtyas.Text);
            komut.Parameters.AddWithValue("@tc", maskedtc.Text);
            komut.Parameters.AddWithValue("@tel", maskedtel.Text);
            komut.Parameters.AddWithValue("@email", txtmail.Text);
            komut.Parameters.AddWithValue("@kayit", datetime.Value);
            komut.Parameters.AddWithValue("@maas", txtmaas.Text);
            komut.Parameters.AddWithValue("@ID", id);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();


            MessageBox.Show("Kayıt Güncellendi");


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label12.Text = DateTime.Now.ToLongDateString();
            label11.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
