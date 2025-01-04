using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Fitness
{
    public partial class Anasayfa : Form
    {
        private string dbName = "macfit.db";
        public Anasayfa()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            UyeEkle uyeEkle = new UyeEkle();
            uyeEkle.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GüncelleSil guncelle = new GüncelleSil();
            guncelle.Show();
            this.Hide();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            UyeleriGoruntule uyeleriGoruntule = new UyeleriGoruntule();
            uyeleriGoruntule.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Index grafik = new Index();
            grafik.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
