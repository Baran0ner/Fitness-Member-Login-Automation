using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fitness
{

    public partial class UyeEkle : Form
    {
        public string dbName = "macfit.db";
        public UyeEkle()
        {
            InitializeComponent();
        }

        private void UyeEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (İsimSoyisimTb.Text == "" || TelefonTb.Text == "" || CinsiyetCb.Text == "" || SeansCb.Text == "" || YasTb.Text == "" || KiloTb.Text == "" || BoyTb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    using (SQLiteConnection connection = new SQLiteConnection(@"Data Source = " + dbName))
                    {
                        connection.Open();
                        SQLiteCommand command = new SQLiteCommand(connection);

                        command.CommandText = "INSERT INTO User(UIsımSoyısım,UTelefon,UCinsiyet,USeans,UYas,UBoy,UKilo" +
                            ",UBaslangicTarihi,UBitisTarihi,UAylıkUyelik) VALUES(@UIsımSoyısım,@UTelefon,@UCinsiyet,@USeans" +
                            ",@UYas,@UBoy,@UKilo,@UBaslangicTarihi,@UBitisTarihi,@UAylıkUyelik)";

                        command.Parameters.AddWithValue("@UIsımSoyısım", İsimSoyisimTb.Text);
                        command.Parameters.AddWithValue("@UTelefon", TelefonTb.Text);
                        command.Parameters.AddWithValue("@UCinsiyet", CinsiyetCb.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@USeans", SeansCb.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@UYas", int.Parse(YasTb.Text));
                        command.Parameters.AddWithValue("@UBoy", int.Parse(BoyTb.Text));
                        command.Parameters.AddWithValue("@UKilo", int.Parse(KiloTb.Text));
                        command.Parameters.AddWithValue("@UBaslangicTarihi", tarihMTb.Text);
                        command.Parameters.AddWithValue("@UBitisTarihi", DateTime.ParseExact(BitisMTb.Text, "dd.MM.yyyy", null));
                        command.Parameters.AddWithValue("@UAylıkUyelik", int.Parse(ayMTb.Text));

                        command.ExecuteNonQuery();

                        MessageBox.Show("Uye basarili bir sekilde eklendi");
                        connection.Close();
                        İsimSoyisimTb.Text = "";
                        TelefonTb.Text = "";
                        CinsiyetCb.Text = "";
                        SeansCb.Text = "";
                        YasTb.Text = "";
                        BoyTb.Text = "";
                        KiloTb.Text = "";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            İsimSoyisimTb.Text = "";
            TelefonTb.Text = "";
            CinsiyetCb.Text = "";
            SeansCb.Text = "";
            YasTb.Text = "";
            BoyTb.Text = "";
            KiloTb.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void TelefonTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void İsimSoyisimTb_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(İsimSoyisimTb.Text, "^[a-zA-ZçğıöşüÇĞİÖŞÜ ]*$"))
            {
                MessageBox.Show("Yalnızca harf ve boşluk girilebilir!");
                İsimSoyisimTb.Text = ""; 
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                
                DateTime tarih = DateTime.ParseExact(tarihMTb.Text, "dd.MM.yyyy", null);

                
                int ayEkle = int.Parse(ayMTb.Text);

                
                DateTime yeniTarih = tarih.AddMonths(ayEkle);

                BitisMTb.Text = yeniTarih.ToString("dd.MM.yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Geçersiz giriş: " + ex.Message);
            }
        }
    }
}
