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
    public partial class UyeleriGoruntule : Form
    {
        public string dbName = "macfit.db";
        public UyeleriGoruntule()
        {
            InitializeComponent();
        }
        public void getAllUsers()
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();
                using (SQLiteConnection con = new SQLiteConnection(@"Data Source = " + dbName))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand(con);
                    cmd.CommandText = "SELECT * FROM User";
                    SQLiteDataReader dataReader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID");
                    dt.Columns.Add("İsim Soyisim");
                    dt.Columns.Add("Telefon");
                    dt.Columns.Add("Cinsiyet");
                    dt.Columns.Add("Yas");
                    dt.Columns.Add("Seans");
                    dt.Columns.Add("Boy");
                    dt.Columns.Add("Kilo");
                    dt.Columns.Add("BaslangicTarihi");
                    dt.Columns.Add("BitisTarihi");
                    dt.Columns.Add("Ay");


                    while (dataReader.Read())
                    {
                        DataRow row = dt.NewRow();
                        row["ID"] = dataReader["id"].ToString();
                        row["İsim Soyisim"] = dataReader["UIsımSoyısım"].ToString();
                        row["Telefon"] = dataReader["UTelefon"].ToString();
                        row["Cinsiyet"] = dataReader["UCinsiyet"].ToString();
                        row["Yas"] = dataReader["Uyas"].ToString();
                        row["Seans"] = dataReader["USeans"].ToString();
                        row["Boy"] = dataReader["UBoy"].ToString();
                        row["Kilo"] = dataReader["UKilo"].ToString();
                        row["BaslangicTarihi"] = dataReader["UBaslangicTarihi"].ToString();
                        row["BitisTarihi"] = dataReader["UBitisTarihi"].ToString();
                        row["Ay"] = dataReader["UAylıkUyelik"].ToString();
                        dt.Rows.Add(row);
                    }


                    dataGridView1.DataSource = dt;
                    dataReader.Close();
                    con.Close();
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void UyeleriGoruntule_Load(object sender, EventArgs e)
        {
            getAllUsers();
            DisplayGenderPieChart();
        }
        public void DisplayGenderPieChart()
        {
            
            int femaleCount = 0;
            int maleCount = 0;

            using (SQLiteConnection conn = new SQLiteConnection(@"Data Source = " + dbName))
            {
                conn.Open();
                string query = "SELECT UCinsiyet, COUNT(*) AS Count FROM User GROUP BY UCinsiyet";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string gender = reader["UCinsiyet"].ToString();
                        int count = Convert.ToInt32(reader["Count"]);

                        if (gender.Equals("Kadın", StringComparison.OrdinalIgnoreCase))
                            femaleCount = count;
                        else if (gender.Equals("Erkek", StringComparison.OrdinalIgnoreCase))
                            maleCount = count;
                    }
                }
            }

            
            genderChart.Series.Clear(); 

            Series series = new Series("Cinsiyet Dağılımı");
            series.ChartType = SeriesChartType.Pie;
            series.ChartArea = "ChartArea1";
            genderChart.ChartAreas.Clear();
            ChartArea chartArea = new ChartArea("ChartArea1");
            chartArea.Area3DStyle.Enable3D = true; 
            chartArea.Area3DStyle.Inclination = 30; 
            genderChart.ChartAreas.Add(chartArea);



            series.BorderWidth = 2;
            series.Font = new Font("Arial", 10, FontStyle.Bold); 

            
            series.Points.AddXY("Erkek", maleCount);
            series.Points.AddXY("Kadın", femaleCount);
            genderChart.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            genderChart.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);



            
            genderChart.Series.Add(series);

            
            genderChart.Titles.Clear();
            genderChart.Titles.Add("Cinsiyet Dağılımı");
            series.IsValueShownAsLabel = true; 
            

        }


        private void button3_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (İsimSoyisimTb.Text != "")
            {
                try
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.Columns.Clear();
                    using (SQLiteConnection con = new SQLiteConnection(@"Data Source = " + dbName))
                    {
                        con.Open();
                        SQLiteCommand cmd = new SQLiteCommand(con);
                        cmd.CommandText = "SELECT * FROM User WHERE UIsımSoyısım LIKE '" + İsimSoyisimTb.Text + "%'";
                        SQLiteDataReader dataReader = cmd.ExecuteReader();

                        DataTable dt = new DataTable();
                        dt.Columns.Add("ID");
                        dt.Columns.Add("İsim Soyisim");
                        dt.Columns.Add("Telefon");
                        dt.Columns.Add("Cinsiyet");
                        dt.Columns.Add("Yas");
                        dt.Columns.Add("Seans");
                        dt.Columns.Add("Boy");
                        dt.Columns.Add("Kilo");


                        while (dataReader.Read())
                        {
                            DataRow row = dt.NewRow();
                            row["ID"] = dataReader["id"].ToString();
                            row["İsim Soyisim"] = dataReader["UIsımSoyısım"].ToString();
                            row["Telefon"] = dataReader["UTelefon"].ToString();
                            row["Cinsiyet"] = dataReader["UCinsiyet"].ToString();
                            row["Yas"] = dataReader["Uyas"].ToString();
                            row["Seans"] = dataReader["USeans"].ToString();
                            row["Boy"] = dataReader["UBoy"].ToString();
                            row["Kilo"] = dataReader["UKilo"].ToString();
                            dt.Rows.Add(row);
                        }


                        dataGridView1.DataSource = dt;
                        dataReader.Close();
                        con.Close();
                    }

                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else
            {
                getAllUsers();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            getAllUsers();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void genderChart_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objBmp = new Bitmap(this.dataGridView1.Width , this.dataGridView1.Height );
            dataGridView1.DrawToBitmap(objBmp, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            int paddingTop = 50;
            e.Graphics.DrawImage(objBmp, 20,100);
            string customText = "Üye Listesi";
            e.Graphics.DrawString(customText, new Font("Verdana", 20, FontStyle.Bold), Brushes.Black, new Point(300, 30));
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
