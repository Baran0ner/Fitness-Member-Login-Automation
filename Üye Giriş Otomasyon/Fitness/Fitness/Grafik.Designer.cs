namespace Fitness
{
    partial class Index
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BoyTb = new TextBox();
            KiloTb = new TextBox();
            button1 = new Button();
            HesapTb = new TextBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(178, 143);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(217, 36);
            comboBox1.TabIndex = 41;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(7, 139);
            label1.Name = "label1";
            label1.Size = new Size(165, 38);
            label1.TabIndex = 42;
            label1.Text = "Üye Seçiniz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(81, 224);
            label2.Name = "label2";
            label2.Size = new Size(75, 38);
            label2.TabIndex = 43;
            label2.Text = "Boy:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(80, 281);
            label3.Name = "label3";
            label3.Size = new Size(76, 38);
            label3.TabIndex = 44;
            label3.Text = "Kilo:";
            label3.Click += label3_Click;
            // 
            // BoyTb
            // 
            BoyTb.BorderStyle = BorderStyle.FixedSingle;
            BoyTb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BoyTb.Location = new Point(178, 224);
            BoyTb.Name = "BoyTb";
            BoyTb.Size = new Size(125, 34);
            BoyTb.TabIndex = 45;
            // 
            // KiloTb
            // 
            KiloTb.BorderStyle = BorderStyle.FixedSingle;
            KiloTb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            KiloTb.Location = new Point(178, 285);
            KiloTb.Name = "KiloTb";
            KiloTb.Size = new Size(125, 34);
            KiloTb.TabIndex = 46;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(41, 422);
            button1.Name = "button1";
            button1.Size = new Size(151, 59);
            button1.TabIndex = 47;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // HesapTb
            // 
            HesapTb.BorderStyle = BorderStyle.FixedSingle;
            HesapTb.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            HesapTb.Location = new Point(256, 424);
            HesapTb.Name = "HesapTb";
            HesapTb.Size = new Size(125, 57);
            HesapTb.TabIndex = 48;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(556, 169);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(435, 401);
            chart1.TabIndex = 49;
            chart1.Text = "chart1";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Location = new Point(503, 50);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(3, 2);
            guna2HtmlLabel1.TabIndex = 50;
            guna2HtmlLabel1.Text = null;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Black;
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(483, 29);
            label4.Name = "label4";
            label4.Size = new Size(384, 50);
            label4.TabIndex = 51;
            label4.Text = "Vücut\\Kitle İndeks";
            label4.Click += label4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(973, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(362, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.vucut_kitle_endeksi2;
            pictureBox2.Location = new Point(1012, 208);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(285, 315);
            pictureBox2.TabIndex = 53;
            pictureBox2.TabStop = false;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Silver;
            guna2Panel1.Controls.Add(button3);
            guna2Panel1.Controls.Add(comboBox1);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.Controls.Add(BoyTb);
            guna2Panel1.Controls.Add(HesapTb);
            guna2Panel1.Controls.Add(KiloTb);
            guna2Panel1.Controls.Add(button1);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Location = new Point(-2, -2);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(454, 627);
            guna2Panel1.TabIndex = 1;
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
            button3.Location = new Point(32, 537);
            button3.Name = "button3";
            button3.Size = new Size(83, 59);
            button3.TabIndex = 40;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1328, 625);
            Controls.Add(guna2Panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(chart1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Index";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Index";
            Load += Grafik_Load;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox BoyTb;
        private TextBox KiloTb;
        private Button button1;
        private TextBox HesapTb;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Button button3;
    }
}