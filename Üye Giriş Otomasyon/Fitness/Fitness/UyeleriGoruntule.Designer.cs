namespace Fitness
{
    partial class UyeleriGoruntule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeleriGoruntule));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            İsimSoyisimTb = new TextBox();
            button2 = new Button();
            button3 = new Button();
            genderChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)genderChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // İsimSoyisimTb
            // 
            İsimSoyisimTb.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            İsimSoyisimTb.Location = new Point(96, 161);
            İsimSoyisimTb.MaxLength = 25;
            İsimSoyisimTb.Name = "İsimSoyisimTb";
            İsimSoyisimTb.Size = new Size(232, 41);
            İsimSoyisimTb.TabIndex = 43;
            İsimSoyisimTb.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.White;
            button2.Location = new Point(373, 155);
            button2.Name = "button2";
            button2.Size = new Size(128, 54);
            button2.TabIndex = 45;
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
            button3.Location = new Point(23, 649);
            button3.Name = "button3";
            button3.Size = new Size(92, 62);
            button3.TabIndex = 46;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // genderChart
            // 
            genderChart.BorderSkin.BackColor = Color.Black;
            genderChart.BorderSkin.BackSecondaryColor = Color.White;
            genderChart.BorderSkin.BorderWidth = 30;
            genderChart.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Name = "ChartArea1";
            genderChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            genderChart.Legends.Add(legend1);
            genderChart.Location = new Point(954, 177);
            genderChart.Name = "genderChart";
            genderChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            genderChart.PaletteCustomColors = new Color[]
    {
    Color.DodgerBlue,
    Color.Pink
    };
            series1.BorderColor = Color.Black;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Label = "#PERCENT{P}";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            dataPoint1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.BottomLeft;
            dataPoint1.Color = Color.LightSkyBlue;
            dataPoint1.Label = "Erkek";
            dataPoint1.LabelAngle = 1;
            dataPoint1.LabelBorderWidth = 15;
            dataPoint1.LabelFormat = "Cinsiyet Dağılımı";
            dataPoint2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.BottomRight;
            dataPoint2.Color = Color.Red;
            dataPoint2.Label = "Kadın";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            genderChart.Series.Add(series1);
            genderChart.Size = new Size(370, 465);
            genderChart.TabIndex = 49;
            genderChart.Text = "chart1";
            title1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            title1.Name = "Title1";
            title1.Text = "Cinsiyet Dağılımı";
            genderChart.Titles.Add(title1);
            genderChart.Click += genderChart_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.Snow;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 255, 128);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DarkGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Green;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(12, 229);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Size = new Size(936, 403);
            dataGridView1.TabIndex = 50;
            
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.f3033944_91a4_4fd8_a9e7_285e07fc47c6;
            pictureBox1.Location = new Point(507, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(354, 230);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Black;
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(96, 102);
            label4.Name = "label4";
            label4.Size = new Size(132, 38);
            label4.TabIndex = 52;
            label4.Text = "Üye Ara";
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(820, 655);
            button1.Name = "button1";
            button1.Size = new Size(128, 50);
            button1.TabIndex = 53;
            button1.Text = "Yazdır";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // UyeleriGoruntule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1321, 733);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(genderChart);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(İsimSoyisimTb);
            Name = "UyeleriGoruntule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UyeleriGoruntule";
            Load += UyeleriGoruntule_Load;
            ((System.ComponentModel.ISupportInitialize)genderChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox İsimSoyisimTb;
        private Button button2;
        private Button button3;
        private System.Windows.Forms.DataVisualization.Charting.Chart genderChart;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label label4;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button button1;
    }
}