using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USP___14
{
    public partial class UserControlInsertRevenue : UserControl
    {
        public UserControlInsertRevenue()
        {
            InitializeComponent();
            
            comboBox1.Items.Add("категория1");
            comboBox1.Items.Add("категория2");
            comboBox1.Items.Add("категория3");
            comboBox1.Items.Add("категория4");
            comboBox1.Items.Add("категория5");
            comboBox1.SelectedIndex = 0;
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Сума в лева") {
                textBox1.Text = "";
                panel1.BackColor = Color.FromArgb(0, 102, 204);
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Сума в лева";
                panel1.BackColor = Color.White;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Описание")
            {
                textBox2.Text = "";
                panel2.BackColor = Color.FromArgb(0, 102, 204);
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Описание";
                panel2.BackColor = Color.White;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Дата (dd.mm.yyyy)")
            {
                textBox4.Text = "";
                panel5.BackColor = Color.FromArgb(0, 102, 204);
            }

        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Дата (dd.mm.yyyy)";
                panel5.BackColor = Color.White;
            }
        }
    }
}
