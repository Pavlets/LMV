﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuMed));
            this.ChartStart = new System.Windows.Forms.Button();
            this.Factors = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.diagram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CitySize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.color_change = new System.Windows.Forms.Button();
            this.Diagram_radio = new System.Windows.Forms.RadioButton();
            this.Chart_radio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.diagram)).BeginInit();
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
            this.diagram.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
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
            // CitySize
            // 
            this.CitySize.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CitySize.Location = new System.Drawing.Point(19, 208);
            this.CitySize.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.CitySize.Name = "CitySize";
            this.CitySize.Size = new System.Drawing.Size(166, 28);
            this.CitySize.TabIndex = 8;
            this.CitySize.Text = "кількість днів";
            this.CitySize.Enter += new System.EventHandler(this.textBox1_Enter);
            this.CitySize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CitySize_KeyDown);
            this.CitySize.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Колір діаграми";
            // 
            // colorDialog
            // 
            this.colorDialog.AllowFullOpen = false;
            // 
            // color_change
            // 
            this.color_change.BackColor = System.Drawing.Color.Red;
            this.color_change.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("color_change.BackgroundImage")));
            this.color_change.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.color_change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color_change.Location = new System.Drawing.Point(163, 166);
            this.color_change.Margin = new System.Windows.Forms.Padding(0);
            this.color_change.Name = "color_change";
            this.color_change.Size = new System.Drawing.Size(22, 22);
            this.color_change.TabIndex = 14;
            this.color_change.UseVisualStyleBackColor = false;
            this.color_change.Click += new System.EventHandler(this.button1_Click_1);
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
            // MenuMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1076, 575);
            this.Controls.Add(this.Chart_radio);
            this.Controls.Add(this.Diagram_radio);
            this.Controls.Add(this.color_change);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CitySize);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.diagram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ChartStart;
        private System.Windows.Forms.Button Factors;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.DataVisualization.Charting.Chart diagram;
        private System.Windows.Forms.TextBox CitySize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button color_change;
        private System.Windows.Forms.RadioButton Diagram_radio;
        private System.Windows.Forms.RadioButton Chart_radio;
    }
}