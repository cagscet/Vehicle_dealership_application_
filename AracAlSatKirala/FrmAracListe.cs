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
using System.Data.SqlClient;


namespace AracAlSatKirala
{
    public partial class FrmAracListe : Form
    {
        public FrmAracListe()
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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void FrmAracListe_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            veriler();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        //-22222222
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

        //--333333333
        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from AracEkleme where id=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler();

            MessageBox.Show("Kayıt Silindi");
        }

        //-444
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
            comboyakit.Text= " ";
            txtdeger.Clear();
            txtkira.Clear();    
            

        }

        private void txtmotor_TextChanged(object sender, EventArgs e)
        {

        }

        //5555555
        private void btnguncel_Click(object sender, EventArgs e)
        {
            //baglanti.Open();
            SqlCommand komut = new SqlCommand("update AracEkleme set marka=@marka , model=@model , yıl=@yıl , renk=@renk, km=@km, vites=@vites,kasatipi=@kasatipi,yakit=@yakit,motorgucu=@motorgucu,kayittarih=@kayittarih,aracındeger=@aracındeger,arackira=@arackira WHERE id=@id ",baglanti);
            komut.Parameters.AddWithValue("@marka", Txtmarka.Text);
            komut.Parameters.AddWithValue("@model", txtmodel.Text);
            komut.Parameters.AddWithValue("@yıl", txtyil.Text );
            komut.Parameters.AddWithValue("@renk", txtrenk.Text);
            komut.Parameters.AddWithValue("@km", txtkm.Text);
            komut.Parameters.AddWithValue("@vites", combovites.Text);
            komut.Parameters.AddWithValue("@kasatipi",combokasa.Text );
            komut.Parameters.AddWithValue("@yakit", comboyakit.Text);
            komut.Parameters.AddWithValue("@motorgucu", txtmotor.Text);
            komut.Parameters.AddWithValue("@kayittarih", datetarih.Value);
            komut.Parameters.AddWithValue("@aracındeger", txtdeger.Text);
            komut.Parameters.AddWithValue("@arackira", txtkira.Text);
            komut.Parameters.AddWithValue("@id", id);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();


            MessageBox.Show("Kayıt Güncellendi");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label14.Text = DateTime.Now.ToLongDateString();
            label13.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
