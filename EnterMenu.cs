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
    public partial class EnterMenu : Form
    {
        public EnterMenu()
        {
            InitializeComponent();
            this.Show();
            label1.Focus();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string login_pl = "ivanov"; // Зада
            string login_med = "petrov";
            string pasword_pl = "parolpeop";
            string pasword_med = "parolmed";

            if (textBox1.Text == login_pl && textBox2.Text == pasword_pl)
            {
                this.Hide();

                MenuPeop f = new MenuPeop();
                f.Show();
            }
            else if (textBox1.Text == login_med && textBox2.Text == pasword_med)
            {
                this.Hide();

                MenuMed f = new MenuMed();
                f.Show();
            }
            else
            {
                textBox2.Text = "";
                MessageBox.Show("Невiрно введенний логiн або пароль!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }
    }
}
