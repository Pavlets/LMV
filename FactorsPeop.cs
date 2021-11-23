using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maket_PZ
{
    public partial class FactorsPeop : Form
    {
        public FactorsPeop()
        {
            InitializeComponent();
            ToolTip t = new ToolTip();
            t.SetToolTip(numericUpDown1, "Відсоток від загального населення на який змінюється кількість людей у місті за місяць");
            t.SetToolTip(label3, "Відсоток від загального населення на який змінюється кількість людей у місті за місяць");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                bool ttt = true;
                for (int i = 0; i <= listBox1.Items.Count; i++)
                    if (Data.Factor_p[i].name == textBox1.Text)
                        ttt = false;

                if (ttt)
                {
                    int i = listBox1.Items.Count;
                    listBox1.Items.Add(textBox1.Text);
                    Data.p_factor_count++;
                    Data.Factor_p[i].name = textBox1.Text;
                    Data.Factor_p[i].value = numericUpDown1.Value;
                    if (radioButton1.Checked)
                        Data.Factor_p[i].v_up = true;
                    else
                        Data.Factor_p[i].v_up = false;
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
                        Data.Factor_p[i].name = Data.Factor_p[i + 1].name;
                        Data.Factor_p[i].value = Data.Factor_p[i + 1].value;
                        Data.Factor_p[i].v_up = Data.Factor_p[i + 1].v_up;
                  }
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                Data.p_factor_count--;
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
                    if (Data.Factor_p[i].name == textBox1.Text && index != i)
                        ttt = false;

                if (ttt)
                {
                    Data.Factor_p[index].name = textBox1.Text;
                    Data.Factor_p[index].value = numericUpDown1.Value;
                    if (radioButton1.Checked)
                        Data.Factor_p[index].v_up = true;
                    else
                        Data.Factor_p[index].v_up = false;
                    listBox1.Items[listBox1.SelectedIndex] = Data.Factor_p[index].name;
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
                textBox1.Text = Data.Factor_p[listBox1.SelectedIndex].name;
                numericUpDown1.Value = Data.Factor_p[listBox1.SelectedIndex].value;
                if (Data.Factor_p[listBox1.SelectedIndex].v_up)
                    radioButton1.Checked = true;
                else
                    radioButton2.Checked = true;
            }
        }
    }
}
