namespace Fitness
{
    partial class UyeEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeEkle));
            label2 = new Label();
            İsimSoyisimTb = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            YasTb = new TextBox();
            label6 = new Label();
            CinsiyetCb = new ComboBox();
            label7 = new Label();
            SeansCb = new ComboBox();
            label9 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            BoyTb = new TextBox();
            KiloTb = new TextBox();
            label10 = new Label();
            label11 = new Label();
            TelefonTb = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            tarihMTb = new MaskedTextBox();
            ayMTb = new MaskedTextBox();
            label1 = new Label();
            label8 = new Label();
            BitisMTb = new MaskedTextBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(464, 39);
            label2.Name = "label2";
            label2.Size = new Size(240, 40);
            label2.TabIndex = 3;
            label2.Text = "Yeni Üye Ekle";
            // 
            // İsimSoyisimTb
            // 
            İsimSoyisimTb.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            İsimSoyisimTb.Location = new Point(92, 205);
            İsimSoyisimTb.MaxLength = 25;
            İsimSoyisimTb.Name = "İsimSoyisimTb";
            İsimSoyisimTb.Size = new Size(232, 41);
            İsimSoyisimTb.TabIndex = 4;
            İsimSoyisimTb.TextChanged += İsimSoyisimTb_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(92, 158);
            label3.Name = "label3";
            label3.Size = new Size(188, 37);
            label3.TabIndex = 5;
            label3.Text = "İsim Soyisim";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Green;
            label4.Location = new Point(391, 158);
            label4.Name = "label4";
            label4.Size = new Size(266, 37);
            label4.TabIndex = 7;
            label4.Text = "Telefon Numarası";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.Green;
            label5.Location = new Point(92, 277);
            label5.Name = "label5";
            label5.Size = new Size(69, 37);
            label5.TabIndex = 9;
            label5.Text = "Yaş";
            // 
            // YasTb
            // 
            YasTb.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            YasTb.Location = new Point(92, 324);
            YasTb.MaxLength = 3;
            YasTb.Name = "YasTb";
            YasTb.Size = new Size(232, 41);
            YasTb.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.Green;
            label6.Location = new Point(390, 277);
            label6.Name = "label6";
            label6.Size = new Size(0, 23);
            label6.TabIndex = 11;
            // 
            // CinsiyetCb
            // 
            CinsiyetCb.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            CinsiyetCb.FormattingEnabled = true;
            CinsiyetCb.Items.AddRange(new object[] { "Kadın", "Erkek" });
            CinsiyetCb.Location = new Point(390, 324);
            CinsiyetCb.Name = "CinsiyetCb";
            CinsiyetCb.Size = new Size(232, 41);
            CinsiyetCb.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.Green;
            label7.Location = new Point(390, 286);
            label7.Name = "label7";
            label7.Size = new Size(130, 37);
            label7.TabIndex = 13;
            label7.Text = "Cinsiyet";
            // 
            // SeansCb
            // 
            SeansCb.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            SeansCb.FormattingEnabled = true;
            SeansCb.Items.AddRange(new object[] { "06:00-15:30", "16:00-22:30" });
            SeansCb.Location = new Point(92, 443);
            SeansCb.Name = "SeansCb";
            SeansCb.Size = new Size(232, 41);
            SeansCb.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.ForeColor = Color.Green;
            label9.Location = new Point(92, 400);
            label9.Name = "label9";
            label9.Size = new Size(103, 37);
            label9.TabIndex = 14;
            label9.Text = "Seans";
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(763, 556);
            button1.Name = "button1";
            button1.Size = new Size(128, 59);
            button1.TabIndex = 16;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.White;
            button2.Location = new Point(920, 556);
            button2.Name = "button2";
            button2.Size = new Size(128, 59);
            button2.TabIndex = 19;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            button3.Location = new Point(38, 591);
            button3.Name = "button3";
            button3.Size = new Size(93, 63);
            button3.TabIndex = 20;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // BoyTb
            // 
            BoyTb.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BoyTb.Location = new Point(724, 205);
            BoyTb.MaxLength = 3;
            BoyTb.Name = "BoyTb";
            BoyTb.Size = new Size(232, 41);
            BoyTb.TabIndex = 22;
            // 
            // KiloTb
            // 
            KiloTb.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            KiloTb.Location = new Point(724, 324);
            KiloTb.MaxLength = 3;
            KiloTb.Name = "KiloTb";
            KiloTb.Size = new Size(232, 41);
            KiloTb.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.ForeColor = Color.Green;
            label10.Location = new Point(724, 156);
            label10.Name = "label10";
            label10.Size = new Size(70, 37);
            label10.TabIndex = 24;
            label10.Text = "Boy";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.ForeColor = Color.Green;
            label11.Location = new Point(724, 277);
            label11.Name = "label11";
            label11.Size = new Size(69, 37);
            label11.TabIndex = 25;
            label11.Text = "Kilo";
            // 
            // TelefonTb
            // 
            TelefonTb.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            TelefonTb.Location = new Point(395, 205);
            TelefonTb.Mask = "(999) 000-0000";
            TelefonTb.Name = "TelefonTb";
            TelefonTb.Size = new Size(227, 41);
            TelefonTb.TabIndex = 26;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(860, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(362, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // tarihMTb
            // 
            tarihMTb.BorderStyle = BorderStyle.FixedSingle;
            tarihMTb.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tarihMTb.Location = new Point(391, 440);
            tarihMTb.Mask = "00/00/0000";
            tarihMTb.Name = "tarihMTb";
            tarihMTb.Size = new Size(231, 43);
            tarihMTb.TabIndex = 45;
            tarihMTb.ValidatingType = typeof(DateTime);
            // 
            // ayMTb
            // 
            ayMTb.BorderStyle = BorderStyle.FixedSingle;
            ayMTb.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ayMTb.Location = new Point(724, 440);
            ayMTb.Name = "ayMTb";
            ayMTb.Size = new Size(232, 43);
            ayMTb.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(395, 400);
            label1.Name = "label1";
            label1.Size = new Size(85, 37);
            label1.TabIndex = 47;
            label1.Text = "Tarih";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.Green;
            label8.Location = new Point(724, 400);
            label8.Name = "label8";
            label8.Size = new Size(56, 37);
            label8.TabIndex = 48;
            label8.Text = "Ay";
            // 
            // BitisMTb
            // 
            BitisMTb.BorderStyle = BorderStyle.FixedSingle;
            BitisMTb.Enabled = false;
            BitisMTb.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BitisMTb.Location = new Point(298, 563);
            BitisMTb.Mask = "00/00/0000";
            BitisMTb.Name = "BitisMTb";
            BitisMTb.Size = new Size(232, 43);
            BitisMTb.TabIndex = 49;
            BitisMTb.ValidatingType = typeof(DateTime);
            // 
            // button4
            // 
            button4.BackColor = Color.Green;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button4.ForeColor = Color.White;
            button4.Location = new Point(599, 556);
            button4.Name = "button4";
            button4.Size = new Size(128, 59);
            button4.TabIndex = 50;
            button4.Text = "Hesapla";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // UyeEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1225, 686);
            Controls.Add(button4);
            Controls.Add(BitisMTb);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(ayMTb);
            Controls.Add(tarihMTb);
            Controls.Add(pictureBox1);
            Controls.Add(TelefonTb);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(KiloTb);
            Controls.Add(BoyTb);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(SeansCb);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(CinsiyetCb);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(YasTb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(İsimSoyisimTb);
            Controls.Add(label2);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "UyeEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UyeEkle";
            Load += UyeEkle_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox İsimSoyisimTb;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox YasTb;
        private Label label6;
        private ComboBox CinsiyetCb;
        private Label label7;
        private ComboBox SeansCb;
        private Label label9;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox BoyTb;
        private TextBox KiloTb;
        private Label label10;
        private Label label11;
        private MaskedTextBox TelefonTb;
        private PictureBox pictureBox1;
        private MaskedTextBox tarihMTb;
        private MaskedTextBox ayMTb;
        private Label label1;
        private Label label8;
        private MaskedTextBox BitisMTb;
        private Button button4;
    }
}