using System;
using System.Windows.Forms;

namespace Maket_PZ
{
    public partial class FactorsMed : Form
    {
        public FactorsMed()
        {
            InitializeComponent();
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox1, "Назва хвороби");
            t.SetToolTip(textBox2, "Середня кількість захворілих у місті за місяць");
            t.SetToolTip(textBox3, "Середня тривалість зайняття хворим палати");
            t.SetToolTip(numericUpDown1, "Відсоток від захворілих що помирають від хвороби");
            t.SetToolTip(label3, "Відсоток від захворілих що помирають від хвороби");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                bool ttt = true;
                for (int i = 0; i <= listBox1.Items.Count; i++)
                    if (Data.Factor_med[i].name == textBox1.Text)
                        ttt = false;

                if (ttt)
                {
                    int i = listBox1.Items.Count;
                    listBox1.Items.Add(textBox1.Text);
                    Data.med_factor_count++;
                    Data.Factor_med[i].name = textBox1.Text;
                    Data.Factor_med[i].sick = Convert.ToInt32(textBox2.Text);
                    Data.Factor_med[i].sick_time = Convert.ToInt32(textBox3.Text);
                    Data.Factor_med[i].die = numericUpDown1.Value;
                }
                else
                    MessageBox.Show("Фактор із таким ім'ям вже існує!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Ім'я фактора не задано!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                for (int i = listBox1.SelectedIndex; i <= listBox1.Items.Count; i++)
                {
                    Data.Factor_med[i].name = Data.Factor_med[i + 1].name;
                    Data.Factor_med[i].sick = Data.Factor_med[i + 1].sick;
                    Data.Factor_med[i].sick_time = Data.Factor_med[i + 1].sick_time;
                    Data.Factor_med[i].die = Data.Factor_med[i + 1].die;
                }
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                Data.med_factor_count--;
            }
            else
                MessageBox.Show("Фактор для видалення не обраний!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int index = listBox1.SelectedIndex;

                bool ttt = true;
                for (int i = 0; i <= listBox1.Items.Count; i++)
                    if (Data.Factor_med[i].name == textBox1.Text && index != i)
                        ttt = false;

                if (ttt)
                {
                    Data.Factor_med[index].name = textBox1.Text;
                    Data.Factor_med[index].sick = Convert.ToInt32(textBox2.Text);
                    Data.Factor_med[index].sick_time = Convert.ToInt32(textBox3.Text);
                    Data.Factor_med[index].die = numericUpDown1.Value;
                    listBox1.Items[listBox1.SelectedIndex] = Data.Factor_med[index].name;
                }
                else
                    MessageBox.Show("Фактор із таким ім'ям вже існує!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Фактор для змiни не обраний!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                textBox1.Text = Data.Factor_med[listBox1.SelectedIndex].name;
                textBox2.Text = Data.Factor_med[listBox1.SelectedIndex].sick.ToString();
                textBox3.Text = Data.Factor_med[listBox1.SelectedIndex].sick_time.ToString();
                numericUpDown1.Value = Data.Factor_med[listBox1.SelectedIndex].die;
            }
        }

        private void FactorsMed_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Data.close_menu_med)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
            }
        }
    }
}
