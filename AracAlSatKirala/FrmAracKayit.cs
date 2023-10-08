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
    public partial class FrmAracKayit : Form
    {
        public FrmAracKayit()
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

        private void FrmAracKayit_Load(object sender, EventArgs e)
        {

        }

        private void BtnMusteriEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into AracEkleme (marka,model,yıl,renk,km,vites,kasatipi,yakit,motorgucu,kayittarih,aracındeger,arackira) values  ('" +Txtmarka.Text+ "','" + txtmodel.Text + "','" +txtyil.Text+ "','" +txtrenk.Text+ "','" + txtkm.Text + "','" + combovites.Text+ "','" + combokasa.Text+ "','" + comboyakit.Text + "','" + txtmotor.Text + "','" + datetarih.Value.ToString("yyyy-MM-dd")+ "','"+txtdeger.Text + "','" +txtkira.Text+ "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Araç Kayıdınız Alınmıştır.");




        }

        private void txtyil_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
////Data Source=DESKTOP-GSOHK16\SQLEXPRESS;Initial Catalog=AracProje;Integrated Security=True