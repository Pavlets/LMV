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
    public partial class MenuMed : Form
    {
        public MenuMed()
        {
            InitializeComponent();
            dateTimePicker1.CustomFormat = "MMMM,yyyy";
        }

        private void MenuMed_FormClosed(object sender, FormClosedEventArgs e)
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
            FactorsMed g = new FactorsMed();
            g.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Data.Factor_p[0].name);
        }
    }
}
