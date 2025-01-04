using System.Data;
using System.Data.SQLite;

namespace Fitness
{
    public partial class GüncelleSil : Form
    {
        public string dbName = "macfit.db";
        public GüncelleSil()
        {
            InitializeComponent();
            getAllUsers();
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


        int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                İsimSoyisimTb.Text = dataGridView1.SelectedRows[0].Cells["İsim Soyisim"].Value.ToString();
                TelefonTb.Text = dataGridView1.SelectedRows[0].Cells["Telefon"].Value.ToString();
                CinsiyetCb.Text = dataGridView1.SelectedRows[0].Cells["Cinsiyet"].Value.ToString();
                YasTb.Text = dataGridView1.SelectedRows[0].Cells["Yas"].Value.ToString();
                SeansCb.Text = dataGridView1.SelectedRows[0].Cells["Seans"].Value.ToString();
                AyTb.Text = dataGridView1.SelectedRows[0].Cells["Ay"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            İsimSoyisimTb.Text = "";
            TelefonTb.Text = "";
            YasTb.Text = "";
            SeansCb.Text = "";
            CinsiyetCb.Text = "";
            AyTb.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            this.Hide();
            anasayfa.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (id == 0)
            {
                MessageBox.Show("Lütfen bir üye seçiniz");
            }
            else
            {
                try
                {
                    using (SQLiteConnection connection = new SQLiteConnection(@"Data Source = " + dbName))
                    {
                        connection.Open();
                        SQLiteCommand command = new SQLiteCommand(connection);
                        command.CommandText = "DELETE FROM User WHERE id=" + id + ";";
                        command.ExecuteNonQuery();
                        MessageBox.Show("Uye basarili bir sekilde silindi");
                        connection.Close();
                        getAllUsers();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (id == 0 || İsimSoyisimTb.Text == "" || TelefonTb.Text == "" || CinsiyetCb.Text == "" || YasTb.Text == "" || SeansCb.Text == "")
            {
                MessageBox.Show("Eksik bilgi");
            }
            else
            {
                try
                {
                    using (SQLiteConnection connection = new SQLiteConnection(@"Data Source = " + dbName))
                    {
                        connection.Open();
                        SQLiteCommand command = new SQLiteCommand(connection);
                        command.CommandText = "UPDATE User SET UIsımSoyısım='" + İsimSoyisimTb.Text + "'" +
                            ",UTelefon='" + TelefonTb.Text + "'" +
                            ",UCinsiyet='" + CinsiyetCb.Text + "'" +
                            ",USeans='" + SeansCb.Text + "'" +
                            ",UYas='" + YasTb.Text + "' " +
                            "WHERE id=" + id + ";";
                        command.ExecuteNonQuery();
                        MessageBox.Show("Uye basarili bir sekilde güncellendi");
                        connection.Close();
                        getAllUsers();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void İsimSoyisimTb_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(İsimSoyisimTb.Text, "^[a-zA-ZçğıöşüÇĞİÖŞÜ ]*$"))
            {
                MessageBox.Show("Yalnızca harf ve boşluk girilebilir!");
                İsimSoyisimTb.Text = "";
            }
        }
    }
}

