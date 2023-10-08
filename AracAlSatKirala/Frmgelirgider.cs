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
    public partial class Frmgelirgider : Form
    {
        public Frmgelirgider()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-GSOHK16\SQLEXPRESS;Initial Catalog=AracProje;Integrated Security=True");

       






        private void timer1_Tick(object sender, EventArgs e)
        {
            label10.Text = DateTime.Now.ToLongDateString();
            label11.Text = DateTime.Now.ToLongTimeString();
        }

        private void Frmgelirgider_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

      
            private void hesapla_Click(object sender, EventArgs e)
            {
                // SQL sorgusunu oluşturun
                string sqlSorgusu = "SELECT SUM(ucret) AS ToplamUcret FROM aracsatis";

                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(sqlSorgusu, baglanti);

                    // Sorguyu çalıştırın ve sonucu alın
                    SqlDataReader reader = komut.ExecuteReader();

                    if (reader.Read())
                    {
                        // Toplam ucret değerini Label kontrolüne yerleştirin
                        decimal toplamUcret = Convert.ToDecimal(reader["ToplamUcret"]);
                        label20.Text = "Satış Geliri: " + toplamUcret.ToString();
                    }
                }
                catch (Exception ex)
                {
                    // Hata işleme
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            // SQL sorgusunu oluşturun
            string sqlSorgusu = "SELECT SUM(aracındeger) AS ToplamUcret FROM AracEkleme";

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(sqlSorgusu, baglanti);

                // Sorguyu çalıştırın ve sonucu alın
                SqlDataReader reader = komut.ExecuteReader();

                if (reader.Read())
                {
                    // Toplam ucret değerini Label kontrolüne yerleştirin
                    decimal toplamUcret = Convert.ToDecimal(reader["ToplamUcret"]);
                    label2.Text = "Araç Alımı: " + toplamUcret.ToString();
                }
            }
            catch (Exception ex)
            {
                // Hata işleme
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // SQL sorgusunu oluşturun
            string sqlSorgusu = "SELECT SUM(tutar) AS ToplamUcret FROM arackira";

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(sqlSorgusu, baglanti);

                // Sorguyu çalıştırın ve sonucu alın
                SqlDataReader reader = komut.ExecuteReader();

                if (reader.Read())
                {
                    // Toplam ucret değerini Label kontrolüne yerleştirin
                    decimal toplamUcret = Convert.ToDecimal(reader["ToplamUcret"]);
                    label3.Text = "Kira Geliri: " + toplamUcret.ToString();
                }
            }
            catch (Exception ex)
            {
                // Hata işleme
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // SQL sorgusunu oluşturun
            string sqlSorgusu = "SELECT SUM(maas) AS ToplamUcret FROM personel";

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(sqlSorgusu, baglanti);

                // Sorguyu çalıştırın ve sonucu alın
                SqlDataReader reader = komut.ExecuteReader();

                if (reader.Read())
                {
                    // Toplam ucret değerini Label kontrolüne yerleştirin
                    decimal toplamUcret = Convert.ToDecimal(reader["ToplamUcret"]);
                    label4.Text = "Toplam Maaş: " + toplamUcret.ToString();
                }
            }
            catch (Exception ex)
            {
                // Hata işleme
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // SQL sorgusunu oluşturun
            string sqlSorgusu = "SELECT SUM(tutar) AS ToplamUcret FROM fatura";

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(sqlSorgusu, baglanti);

                // Sorguyu çalıştırın ve sonucu alın
                SqlDataReader reader = komut.ExecuteReader();

                if (reader.Read())
                {
                    // Toplam ucret değerini Label kontrolüne yerleştirin
                    decimal toplamUcret = Convert.ToDecimal(reader["ToplamUcret"]);
                    label5.Text = "Fatura Giderleri: " + toplamUcret.ToString();
                }
            }
            catch (Exception ex)
            {
                // Hata işleme
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            



        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }
    }
}
