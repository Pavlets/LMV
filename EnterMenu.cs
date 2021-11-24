using System;
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
            string login_pl = "ivanov";
            string login_med = "petrov";
            string pasword_pl = "parolpeop";
            string pasword_med = "parolmed";

            if (textBox1.Text == login_pl && textBox2.Text == pasword_pl)
            {
                MenuPeop f = new MenuPeop();
                f.Show();

                this.Hide();
            }
            else if (textBox1.Text == login_med && textBox2.Text == pasword_med)
            {
                MenuMed f = new MenuMed();
                f.Show();

                this.Hide();
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
