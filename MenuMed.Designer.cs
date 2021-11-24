
namespace Maket_PZ
{
    partial class MenuMed
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuMed));
            this.ChartStart = new System.Windows.Forms.Button();
            this.Factors = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.diagram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Days_future = new System.Windows.Forms.TextBox();
            this.Diagram_radio = new System.Windows.Forms.RadioButton();
            this.Chart_radio = new System.Windows.Forms.RadioButton();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.diagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
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
            this.ChartStart.Text = "Побудувати діаграму";
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
            // diagram
            // 
            this.diagram.BackColor = System.Drawing.Color.Gainsboro;
            this.diagram.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DarkUpwardDiagonal;
            this.diagram.BorderlineColor = System.Drawing.Color.Black;
            this.diagram.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.diagram.BorderlineWidth = 2;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.diagram.ChartAreas.Add(chartArea1);
            this.diagram.Cursor = System.Windows.Forms.Cursors.IBeam;
            legend1.BorderColor = System.Drawing.Color.Black;
            legend1.BorderWidth = 2;
            legend1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Legend1";
            this.diagram.Legends.Add(legend1);
            this.diagram.Location = new System.Drawing.Point(205, 19);
            this.diagram.Name = "diagram";
            this.diagram.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Color = System.Drawing.Color.Red;
            series1.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.ToolTip = "Чисельність хворих #AXISLABEL - #PERCENT";
            this.diagram.Series.Add(series1);
            this.diagram.Size = new System.Drawing.Size(851, 480);
            this.diagram.TabIndex = 7;
            title1.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = "Діаграма хворих міста";
            this.diagram.Titles.Add(title1);
            // 
            // Days_future
            // 
            this.Days_future.Enabled = false;
            this.Days_future.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Days_future.Location = new System.Drawing.Point(19, 215);
            this.Days_future.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.Days_future.Name = "Days_future";
            this.Days_future.Size = new System.Drawing.Size(166, 28);
            this.Days_future.TabIndex = 8;
            this.Days_future.Text = "кількість днів";
            this.Days_future.Visible = false;
            this.Days_future.Enter += new System.EventHandler(this.textBox1_Enter);
            this.Days_future.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CitySize_KeyDown);
            this.Days_future.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // Diagram_radio
            // 
            this.Diagram_radio.AutoSize = true;
            this.Diagram_radio.Checked = true;
            this.Diagram_radio.Location = new System.Drawing.Point(19, 86);
            this.Diagram_radio.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Diagram_radio.Name = "Diagram_radio";
            this.Diagram_radio.Size = new System.Drawing.Size(106, 25);
            this.Diagram_radio.TabIndex = 15;
            this.Diagram_radio.TabStop = true;
            this.Diagram_radio.Text = "Діаграма";
            this.Diagram_radio.UseVisualStyleBackColor = true;
            this.Diagram_radio.CheckedChanged += new System.EventHandler(this.Diagram_radio_CheckedChanged);
            // 
            // Chart_radio
            // 
            this.Chart_radio.AutoSize = true;
            this.Chart_radio.Location = new System.Drawing.Point(19, 121);
            this.Chart_radio.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.Chart_radio.Name = "Chart_radio";
            this.Chart_radio.Size = new System.Drawing.Size(88, 25);
            this.Chart_radio.TabIndex = 16;
            this.Chart_radio.Text = "Графік";
            this.Chart_radio.UseVisualStyleBackColor = true;
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.Color.White;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Яркий пастель",
            "Яркий",
            "Оттенки серого",
            "Изощрённый",
            "Свет",
            "Пастель",
            "Тона земли",
            "Полупрозрачный",
            "Ягода",
            "Шоколад",
            "Огонь",
            "Морской-зелёный"});
            this.comboBox.Location = new System.Drawing.Point(19, 166);
            this.comboBox.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(166, 29);
            this.comboBox.TabIndex = 17;
            this.comboBox.Text = "Палітра дiаг.";
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // Chart
            // 
            this.Chart.BackColor = System.Drawing.Color.Gainsboro;
            this.Chart.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DarkUpwardDiagonal;
            this.Chart.BorderlineColor = System.Drawing.Color.Black;
            this.Chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.Chart.BorderlineWidth = 2;
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea2);
            this.Chart.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Chart.Enabled = false;
            legend2.BorderColor = System.Drawing.Color.Black;
            legend2.BorderWidth = 2;
            legend2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend2.IsTextAutoFit = false;
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend2.Name = "Legend1";
            this.Chart.Legends.Add(legend2);
            this.Chart.Location = new System.Drawing.Point(205, 19);
            this.Chart.Name = "Chart";
            this.Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.Chart.Size = new System.Drawing.Size(801, 480);
            this.Chart.TabIndex = 18;
            title2.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.Name = "Title1";
            title2.Text = "Прогнозування кількості хворих у місті";
            this.Chart.Titles.Add(title2);
            this.Chart.Visible = false;
            // 
            // MenuMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1076, 575);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.Chart_radio);
            this.Controls.Add(this.Diagram_radio);
            this.Controls.Add(this.Days_future);
            this.Controls.Add(this.diagram);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Factors);
            this.Controls.Add(this.ChartStart);
            this.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "MenuMed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Системне меню";
            this.Activated += new System.EventHandler(this.MenuMed_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.diagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ChartStart;
        private System.Windows.Forms.Button Factors;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.DataVisualization.Charting.Chart diagram;
        private System.Windows.Forms.TextBox Days_future;
        private System.Windows.Forms.RadioButton Diagram_radio;
        private System.Windows.Forms.RadioButton Chart_radio;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
    }
}