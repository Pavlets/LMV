
namespace Maket_PZ
{
    partial class MenuPeop
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPeop));
            this.ChartStart = new System.Windows.Forms.Button();
            this.Factors = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CitySize = new System.Windows.Forms.TextBox();
            this.radioButtonMonth = new System.Windows.Forms.RadioButton();
            this.radioButtonYear = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartStart
            // 
            this.ChartStart.BackColor = System.Drawing.Color.Silver;
            this.ChartStart.FlatAppearance.BorderSize = 0;
            this.ChartStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.ChartStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ChartStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChartStart.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChartStart.Location = new System.Drawing.Point(205, 519);
            this.ChartStart.Margin = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.ChartStart.Name = "ChartStart";
            this.ChartStart.Size = new System.Drawing.Size(580, 37);
            this.ChartStart.TabIndex = 3;
            this.ChartStart.Text = "Побудувати графiк";
            this.ChartStart.UseVisualStyleBackColor = false;
            this.ChartStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // Factors
            // 
            this.Factors.BackColor = System.Drawing.Color.Silver;
            this.Factors.FlatAppearance.BorderSize = 0;
            this.Factors.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Factors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Factors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Factors.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Factors.Location = new System.Drawing.Point(19, 19);
            this.Factors.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.Factors.Name = "Factors";
            this.Factors.Size = new System.Drawing.Size(166, 37);
            this.Factors.TabIndex = 4;
            this.Factors.Text = "Фактори впливу";
            this.Factors.UseVisualStyleBackColor = false;
            this.Factors.Click += new System.EventHandler(this.button2_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Silver;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(790, 519);
            this.Exit.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(266, 37);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Вийти з профiлю";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Bookshelf Symbol 7", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.dateTimePicker.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(19, 127);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.dateTimePicker.MinDate = new System.DateTime(2021, 11, 23, 18, 33, 39, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowUpDown = true;
            this.dateTimePicker.Size = new System.Drawing.Size(166, 28);
            this.dateTimePicker.TabIndex = 6;
            this.dateTimePicker.Value = new System.DateTime(2021, 11, 23, 18, 33, 39, 0);
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.Gainsboro;
            this.chart.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DarkUpwardDiagonal;
            this.chart.BorderlineColor = System.Drawing.Color.Black;
            this.chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart.BorderlineWidth = 2;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Location = new System.Drawing.Point(205, 19);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Red;
            series1.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.Name = "Series1";
            series1.ToolTip = "Чисельність населення на #VALX рік буде\\nдорівнювати - #VAL";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(851, 480);
            this.chart.TabIndex = 7;
            title1.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = "Динаміка чисельності населення міста";
            this.chart.Titles.Add(title1);
            // 
            // CitySize
            // 
            this.CitySize.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CitySize.Location = new System.Drawing.Point(19, 76);
            this.CitySize.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.CitySize.Name = "CitySize";
            this.CitySize.Size = new System.Drawing.Size(166, 28);
            this.CitySize.TabIndex = 8;
            this.CitySize.Text = "чис. населення";
            this.CitySize.Enter += new System.EventHandler(this.textBox1_Enter);
            this.CitySize.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // radioButtonMonth
            // 
            this.radioButtonMonth.AutoSize = true;
            this.radioButtonMonth.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonMonth.Location = new System.Drawing.Point(19, 240);
            this.radioButtonMonth.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.radioButtonMonth.Name = "radioButtonMonth";
            this.radioButtonMonth.Size = new System.Drawing.Size(88, 25);
            this.radioButtonMonth.TabIndex = 10;
            this.radioButtonMonth.Text = "Місяці";
            this.radioButtonMonth.UseVisualStyleBackColor = true;
            // 
            // radioButtonYear
            // 
            this.radioButtonYear.AutoSize = true;
            this.radioButtonYear.Checked = true;
            this.radioButtonYear.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonYear.Location = new System.Drawing.Point(19, 210);
            this.radioButtonYear.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.radioButtonYear.Name = "radioButtonYear";
            this.radioButtonYear.Size = new System.Drawing.Size(73, 25);
            this.radioButtonYear.TabIndex = 11;
            this.radioButtonYear.TabStop = true;
            this.radioButtonYear.Text = "Роки";
            this.radioButtonYear.UseVisualStyleBackColor = true;
            this.radioButtonYear.CheckedChanged += new System.EventHandler(this.radioButtonYear_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Одиниці графіка:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 290);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Колiр графіка";
            // 
            // colorDialog
            // 
            this.colorDialog.AllowFullOpen = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(151, 290);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 22);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MenuPeop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1076, 575);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonYear);
            this.Controls.Add(this.radioButtonMonth);
            this.Controls.Add(this.CitySize);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Factors);
            this.Controls.Add(this.ChartStart);
            this.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "MenuPeop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Системне меню";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ChartStart;
        private System.Windows.Forms.Button Factors;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.TextBox CitySize;
        private System.Windows.Forms.RadioButton radioButtonMonth;
        private System.Windows.Forms.RadioButton radioButtonYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button button1;
    }
}