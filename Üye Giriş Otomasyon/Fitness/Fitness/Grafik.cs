using Newtonsoft.Json.Linq;
using ScottPlot.PlotStyles;
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
    public partial class Index : Form
    {
        private string dbName = "macfit.db";
        public Index()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LoadNamesToComboBox()
        {
            string query = "SELECT UIsımSoyısım FROM User";

            using (SQLiteConnection conn = new SQLiteConnection(@"Data Source= " + dbName))
            {
                try
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader["UIsımSoyısım"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }


        private void Grafik_Load(object sender, EventArgs e)
        {
            LoadNamesToComboBox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string selectedName = comboBox1.SelectedItem.ToString();

            
            string query = "SELECT UBoy, UKilo FROM User WHERE UIsımSoyısım = @selectedName";

            using (SQLiteConnection conn = new SQLiteConnection(@"Data Source= " + dbName))
            {
                try
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        
                        cmd.Parameters.AddWithValue("@selectedName", selectedName);

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) 
                            {
                                
                                BoyTb.Text = reader["UBoy"].ToString();
                                KiloTb.Text = reader["UKilo"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Kayıt bulunamadı.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double boy = int.Parse(BoyTb.Text);
            double kilo = int.Parse(KiloTb.Text);
            double sonuc;
            double olmasıGerekenSonuc;

            sonuc = 10000 * (kilo / (boy * boy));
            HesapTb.Text = "% " + Math.Round(sonuc, 1);

            double idealKilo = (22 * (boy * boy)) / 10000;
            double idealSonuc = Math.Round(sonuc, 1);

            olmasıGerekenSonuc = 10000 * (idealSonuc / (boy * boy));



            
            chart1.Series.Clear();
            chart1.Series.Add("Kitle Indeksi");
            chart1.Series["Kitle Indeksi"].ChartType = SeriesChartType.Column;
            chart1.Series["Kitle Indeksi"].Points.AddXY(Math.Round(sonuc, 1).ToString(), sonuc);
            chart1.Series["Kitle Indeksi"].Color = System.Drawing.Color.Blue; 


            


            chart1.ChartAreas[0].AxisX.Title = "Vücut Kitle İndeksi (VKİ)";
            chart1.ChartAreas[0].AxisY.Title = "Değer";
            chart1.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 8, FontStyle.Bold); 
            chart1.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 8, FontStyle.Bold);

            chart1.Legends[0].Font = new Font("Arial", 8, FontStyle.Bold);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
