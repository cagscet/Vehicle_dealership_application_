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
    public partial class FrmSatis : Form
    {
        public FrmSatis()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GSOHK16\\SQLEXPRESS;Initial Catalog=AracProje;Integrated Security=True");
        //--------1111


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
                ekle.SubItems.Add(oku["kayittarih"].ToString());
                ekle.SubItems.Add(oku["aracındeger"].ToString());
                ekle.SubItems.Add(oku["arackira"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void veriler2()
        {
            listView2.Items.Clear();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from aracsatis", baglanti);
            SqlDataReader okuma = cmd.ExecuteReader();

            while (okuma.Read()) 
            {
                ListViewItem item = new ListViewItem();
                item.Text = okuma["id"].ToString();
                item.SubItems.Add(okuma["isim"].ToString());
                item.SubItems.Add(okuma["soyad"].ToString());
                item.SubItems.Add(okuma["arac"].ToString());
                item.SubItems.Add(okuma["ucret"].ToString());

                listView2.Items.Add(item);
            }
            baglanti.Close();

        }




        private void button5_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into aracsatis (isim,soyad,arac,ucret) values ('" + txtisim.Text + "','" + txtsoyad.Text + "','" + txtarac.Text + "','" + txtucret.Text+"')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Satış Gerçekleşti,Lütfen Satılan Araçı Listenizden Siliniz");


        }

        private void FrmSatis_Load(object sender, EventArgs e)
        {
            veriler();
            timer1.Start();
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            Txtmarka.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtmodel.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtyil.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtrenk.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtkm.Text = listView1.SelectedItems[0].SubItems[5].Text;
            combovites.Text = listView1.SelectedItems[0].SubItems[6].Text;
            combokasa.Text = listView1.SelectedItems[0].SubItems[7].Text;
            comboyakit.Text = listView1.SelectedItems[0].SubItems[8].Text;
            txtmotor.Text = listView1.SelectedItems[0].SubItems[9].Text;
            datetarih.Text = listView1.SelectedItems[0].SubItems[10].Text;
            txtdeger.Text = listView1.SelectedItems[0].SubItems[11].Text;
            txtkira.Text = listView1.SelectedItems[0].SubItems[12].Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from AracEkleme where id=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler();

            MessageBox.Show("Kayıt Silindi");
        }

        private void btntemiz_Click(object sender, EventArgs e)
        {
            Txtmarka.Clear();
            txtmodel.Clear();
            txtkm.Clear();
            txtrenk.Clear();
            txtmotor.Clear();
            txtyil.Clear();
            combokasa.Text = " ";
            combovites.Text = " ";
            comboyakit.Text = " ";
            txtdeger.Clear();
            txtkira.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            veriler2();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtisim.Clear();
            txtsoyad.Clear();
            txtucret.Clear();
            txtarac.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label18.Text = DateTime.Now.ToLongDateString();
            label17.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
