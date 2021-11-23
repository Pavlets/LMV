using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Maket_PZ
{
    public partial class MenuPeop : Form
    {
        public MenuPeop()
        {
            InitializeComponent();
            CitySize.ForeColor = Color.Gray;
            CitySize.Font = new Font("Constantia", 10, FontStyle.Italic);
            dateTimePicker.CustomFormat = "MMMM,yyyy";
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            EnterMenu f = new EnterMenu();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FactorsPeop g = new FactorsPeop();
            g.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CitySize.Text != "чис. населення")
            {
                chart.Series[0].XValueType = ChartValueType.Date;
                chart.Series[0].Points.Clear();

                int city_size = int.Parse(CitySize.Text);

                DateTime time_z = DateTime.Today;
                time_z = time_z.AddDays(-time_z.Day);
                if (radioButtonYear.Checked)
                {
                    time_z = time_z.AddMonths(-time_z.Month);
                    chart.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy";
                    chart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Years;
                    chart.ChartAreas[0].AxisX.Interval = 1;
                    while (time_z < dateTimePicker.Value)
                    {
                        if (city_size < 0)
                            city_size = 0;
                        chart.Series[0].Points.AddXY(time_z, city_size);
                        time_z = time_z.AddYears(1);
                        for (int j = 1; j <= 12; j++)
                        {
                            for (int jj = 0; jj <= Data.p_factor_count; jj++)
                                if (Data.Factor_p[jj].v_up)
                                {
                                    city_size += Decimal.ToInt32(city_size * (Data.Factor_p[jj].value / 100));
                                }
                                else
                                {
                                    city_size -= Decimal.ToInt32(city_size * (Data.Factor_p[jj].value / 100));
                                }
                            //MessageBox.Show(city_size.ToString());
                        }
                    }
                }
                else
                {
                    chart.ChartAreas[0].AxisX.LabelStyle.Format = "M.yyyy";
                    chart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Months;
                    chart.ChartAreas[0].AxisX.Interval = 1;
                    while (time_z < dateTimePicker.Value)
                    {
                        if (city_size < 0)
                            city_size = 0;
                        chart.Series[0].Points.AddXY(time_z, city_size);
                        time_z = time_z.AddMonths(1);
                        for (int jj = 0; jj <= Data.p_factor_count; jj++)
                            if (Data.Factor_p[jj].v_up)
                            {
                                city_size += Decimal.ToInt32(city_size * (Data.Factor_p[jj].value / 100));
                            }
                            else
                            {
                                city_size -= Decimal.ToInt32(city_size * (Data.Factor_p[jj].value / 100));
                            }
                        //MessageBox.Show(city_size.ToString());
                    }
                }
            }
            else
                MessageBox.Show("Введіть чисельність населення міста!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (CitySize.ForeColor == Color.Gray)
            {
                CitySize.Text = "";
                CitySize.Font = new Font("Constantia", 10, FontStyle.Regular);
                CitySize.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (CitySize.Text == "")
            {
                CitySize.ForeColor = Color.Gray;
                CitySize.Font = new Font("Constantia", 10, FontStyle.Italic);
                CitySize.Text = "чис. населення";
            }
        }
    }
}
