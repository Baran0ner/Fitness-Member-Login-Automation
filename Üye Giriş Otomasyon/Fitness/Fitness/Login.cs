 using System.Data.SQLite;

namespace Fitness
{
    public partial class Login : Form
    {
        public string dbName = "macfit.db";
        public Login()
        {
            InitializeComponent();
        }

        public void manageDatabase()
        {
            if (!File.Exists(dbName))
            {
                SQLiteConnection.CreateFile(dbName);
                using (SQLiteConnection conn = new SQLiteConnection(@"Data Source = " + dbName))
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand(conn);
                    cmd.CommandText = "CREATE TABLE User(id INTEGER NOT NULL UNIQUE " +
                        ", UIsýmSoyýsým TEXT NOT NULL" +
                        ", UTelefon TEXT NOT NULL " +
                        ", UCinsiyet TEXT NOT NULL " +
                        ", USeans TEXT NOT NULL " +
                        ", UYas INTEGER NOT NULL " +
                        ", UBoy INTEGER NOT NULL " +
                        ", UKilo INTEGER NOT NULL " +
                        ", UBaslangicTarihi TEXT NOT NULL " +
                        ", UBitisTarihi TEXT NOT NULL " +
                        ", UAylýkUyelik INTEGER NOT NULL " +
                        ", PRIMARY KEY (id AUTOINCREMENT));";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            manageDatabase();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (KullaniciTb.Text == "" || SifreTb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else if (KullaniciTb.Text == "Admin" && SifreTb.Text == "1234")
            {
                Anasayfa anasayfa = new Anasayfa();
                anasayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı  ya da şifre");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            KullaniciTb.Text = "";
            SifreTb.Text = "";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (KullaniciTb.Text == "" || SifreTb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else if (KullaniciTb.Text == "Admin" && SifreTb.Text == "1234")
            {
                Anasayfa anasayfa = new Anasayfa();
                anasayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalý kullanýcý ya da þifre");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
