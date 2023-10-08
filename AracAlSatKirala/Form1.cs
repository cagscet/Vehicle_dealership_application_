using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracAlSatKirala
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label10.Text = DateTime.Now.ToLongDateString();
            label11.Text = DateTime.Now.ToLongTimeString();
        }

        private void BtnMusteriEkle_Click(object sender, EventArgs e)
        {
            FrmMusteriEkle fr = new FrmMusteriEkle();
            fr.Show();
            this.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMusteriListe fr = new FrmMusteriListe();
            fr.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çağlar Çetin İSTANBUL 09/2023 ,İletişim Mail : ccetin588@gmail.com");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmAracKayit fr = new FrmAracKayit();
            fr.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmAracListe fr = new FrmAracListe();
            fr.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frmpersonel fr = new Frmpersonel();
            fr.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmPersonelList fr = new FrmPersonelList();
            fr.Show();
            this.Hide();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmFaturalar fr = new FrmFaturalar();
            fr.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Frmbakım fr = new Frmbakım();
            fr.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmSatis fr = new FrmSatis();
            fr.Show();
            this.Hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            btnkayt fr = new btnkayt();
            fr.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Frmgelirgider fr = new Frmgelirgider();
            fr.Show();
            this.Hide();

        }
    }
}
