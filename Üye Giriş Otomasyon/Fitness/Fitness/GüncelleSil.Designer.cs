namespace Fitness
{
    partial class GüncelleSil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GüncelleSil));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            SeansCb = new ComboBox();
            label9 = new Label();
            label7 = new Label();
            CinsiyetCb = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            YasTb = new TextBox();
            label4 = new Label();
            label3 = new Label();
            İsimSoyisimTb = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            TelefonTb = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            label1 = new Label();
            AyTb = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.Green;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button4.ForeColor = Color.White;
            button4.Location = new Point(242, 621);
            button4.Name = "button4";
            button4.Size = new Size(128, 54);
            button4.TabIndex = 40;
            button4.Text = "Sil";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button3.ForeColor = Color.White;
            button3.Location = new Point(25, 621);
            button3.Name = "button3";
            button3.Size = new Size(79, 57);
            button3.TabIndex = 39;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.White;
            button2.Location = new Point(320, 555);
            button2.Name = "button2";
            button2.Size = new Size(128, 54);
            button2.TabIndex = 38;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(168, 555);
            button1.Name = "button1";
            button1.Size = new Size(128, 54);
            button1.TabIndex = 35;
            button1.Text = "Güncelle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // SeansCb
            // 
            SeansCb.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            SeansCb.FormattingEnabled = true;
            SeansCb.Items.AddRange(new object[] { "06:00-15:30", "16:00-22:30" });
            SeansCb.Location = new Point(64, 413);
            SeansCb.Name = "SeansCb";
            SeansCb.Size = new Size(232, 29);
            SeansCb.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(64, 383);
            label9.Name = "label9";
            label9.Size = new Size(78, 27);
            label9.TabIndex = 33;
            label9.Text = "Seans";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(64, 237);
            label7.Name = "label7";
            label7.Size = new Size(101, 27);
            label7.TabIndex = 32;
            label7.Text = "Cinsiyet";
            // 
            // CinsiyetCb
            // 
            CinsiyetCb.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            CinsiyetCb.FormattingEnabled = true;
            CinsiyetCb.Items.AddRange(new object[] { "Kadın", "Erkek" });
            CinsiyetCb.Location = new Point(64, 267);
            CinsiyetCb.Name = "CinsiyetCb";
            CinsiyetCb.Size = new Size(232, 29);
            CinsiyetCb.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.Green;
            label6.Location = new Point(150, 253);
            label6.Name = "label6";
            label6.Size = new Size(0, 23);
            label6.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(64, 312);
            label5.Name = "label5";
            label5.Size = new Size(51, 27);
            label5.TabIndex = 29;
            label5.Text = "Yaş";
            // 
            // YasTb
            // 
            YasTb.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            YasTb.Location = new Point(64, 342);
            YasTb.MaxLength = 3;
            YasTb.Name = "YasTb";
            YasTb.Size = new Size(232, 28);
            YasTb.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(64, 159);
            label4.Name = "label4";
            label4.Size = new Size(205, 27);
            label4.TabIndex = 27;
            label4.Text = "Telefon Numarası";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(64, 87);
            label3.Name = "label3";
            label3.Size = new Size(146, 27);
            label3.TabIndex = 25;
            label3.Text = "İsim Soyisim";
            // 
            // İsimSoyisimTb
            // 
            İsimSoyisimTb.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            İsimSoyisimTb.Location = new Point(64, 117);
            İsimSoyisimTb.MaxLength = 25;
            İsimSoyisimTb.Name = "İsimSoyisimTb";
            İsimSoyisimTb.Size = new Size(232, 28);
            İsimSoyisimTb.TabIndex = 24;
            İsimSoyisimTb.TextChanged += İsimSoyisimTb_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(501, 53);
            label2.Name = "label2";
            label2.Size = new Size(370, 39);
            label2.TabIndex = 23;
            label2.Text = "Güncelleme ve Silme ";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Snow;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(530, 149);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(778, 403);
            dataGridView1.TabIndex = 41;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // TelefonTb
            // 
            TelefonTb.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            TelefonTb.Location = new Point(64, 193);
            TelefonTb.Mask = "(999) 000-0000";
            TelefonTb.Name = "TelefonTb";
            TelefonTb.Size = new Size(227, 28);
            TelefonTb.TabIndex = 42;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(936, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(362, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Silver;
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(AyTb);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.Controls.Add(İsimSoyisimTb);
            guna2Panel1.Controls.Add(TelefonTb);
            guna2Panel1.Controls.Add(label4);
            guna2Panel1.Controls.Add(YasTb);
            guna2Panel1.Controls.Add(button4);
            guna2Panel1.Controls.Add(label5);
            guna2Panel1.Controls.Add(button3);
            guna2Panel1.Controls.Add(label6);
            guna2Panel1.Controls.Add(button2);
            guna2Panel1.Controls.Add(CinsiyetCb);
            guna2Panel1.Controls.Add(button1);
            guna2Panel1.Controls.Add(label7);
            guna2Panel1.Controls.Add(SeansCb);
            guna2Panel1.Controls.Add(label9);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Location = new Point(1, -2);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(465, 692);
            guna2Panel1.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(64, 460);
            label1.Name = "label1";
            label1.Size = new Size(42, 27);
            label1.TabIndex = 44;
            label1.Text = "Ay";
            // 
            // AyTb
            // 
            AyTb.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            AyTb.Location = new Point(64, 490);
            AyTb.MaxLength = 3;
            AyTb.Name = "AyTb";
            AyTb.Size = new Size(232, 28);
            AyTb.TabIndex = 43;
            // 
            // GüncelleSil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1335, 688);
            Controls.Add(guna2Panel1);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Name = "GüncelleSil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GüncelleSil";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private Button button2;
        private TextBox textBox4;
        private Button button1;
        private ComboBox SeansCb;
        private Label label9;
        private Label label7;
        private ComboBox CinsiyetCb;
        private Label label6;
        private Label label5;
        private TextBox YasTb;
        private Label label4;
        private Label label3;
        private TextBox İsimSoyisimTb;
        private Label label2;
        private DataGridView dataGridView1;
        private MaskedTextBox TelefonTb;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label1;
        private TextBox AyTb;
    }
}