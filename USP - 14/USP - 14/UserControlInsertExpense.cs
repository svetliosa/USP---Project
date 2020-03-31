using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace USP___14
{
    public partial class UserControlInsertExpense : UserControl
    {
        public UserControlInsertExpense()
        {
            InitializeComponent();
            comboBox1.Items.Add("Сметки");
            comboBox1.Items.Add("Домакинство");
            comboBox1.Items.Add("Заеми");
            comboBox1.Items.Add("Лични разходи");
            comboBox1.Items.Add("Други");
            comboBox1.SelectedIndex = 0;

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Сума в лева")
            {
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControlInsertExpense_Load(object sender, EventArgs e)
        {

        }

        private void flatButtonCreateRevenue_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=USP-14;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            float Suma = float.Parse(textBox1.Text);
            string Data = textBox4.Text.ToString();
            string Opisanie = textBox2.Text.ToString();
            string Tip = "Разход";
            string Kategoria = comboBox1.Text;
            string Mesec = Data.Substring(3, 2);
            if (textBox1.Text == "") { MessageBox.Show("Error!"); }
            if (textBox2.Text == "") { MessageBox.Show("Error!"); }
            if (textBox4.Text == "") { MessageBox.Show("Error!"); }

            else
            {
                if (con.State == System.Data.ConnectionState.Open)
                {

                    string q = "insert into USP14_Table(Tip_DB,Suma_DB,Kategoria_DB,Data_DB,Opisanie_DB,Mesec_DB)values('" + Tip + "','" + Suma + "','" + Kategoria + "','" + Data
                + "','" + Opisanie + "','" + Mesec + "')";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Connection Made!");
                }
            }
        }
    }
}
