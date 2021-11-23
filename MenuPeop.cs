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
                if (radioButtonYear.Checked)
                {
                    chart.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy";

                }
                //chart.ChartAreas[0].AxisX.Minimum = DateTime.Today.ToOADate();
                chart.Series[0].Points.Clear();
                
                int city_size = int.Parse(CitySize.Text);

                DateTime time_z = DateTime.Today;
                if (radioButtonYear.Checked)
                    while(time_z < dateTimePicker.Value)
                    {
                        if (city_size < 0)
                            city_size = 0;
                        chart.Series[0].Points.AddXY(time_z, city_size);
                        time_z = time_z.AddYears(1);
                    }



                /*for (int i = 1; i <= 365; i++)
                {
                    for (int j = 0; j <= Data.p_factor_count; j++)
                        if (Data.Factor_p[j].v_up)
                        {
                            city_size += Decimal.ToInt32(city_size * (Data.Factor_p[j].value / 100));
                        }
                        else
                        {
                            city_size -= Decimal.ToInt32(city_size * (Data.Factor_p[j].value / 100));
                        }

                    if (city_size < 0)
                        city_size = 0;
                    chart.Series[0].Points.AddXY(i, city_size);
                }*/
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
