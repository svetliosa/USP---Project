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
    public partial class UserControlSearch : UserControl
    {
        public UserControlSearch()
        {
            InitializeComponent();
           
            comboBox2.Items.Add("Приход");
            comboBox2.Items.Add("Разход");
            comboBox3.Items.Add("Януари");
            comboBox3.Items.Add("Февруари");
            comboBox3.Items.Add("Март");
            comboBox3.Items.Add("Април");
            comboBox3.Items.Add("Май");
            comboBox3.Items.Add("Юни");
            comboBox3.Items.Add("Юли");
            comboBox3.Items.Add("Август");
            comboBox3.Items.Add("Септември");
            comboBox3.Items.Add("Октомври");
            comboBox3.Items.Add("Ноември");
            comboBox3.Items.Add("Декември");
            
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == "Приход")
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Прих Кат1");
                comboBox1.Items.Add("Прих Кат2");
                comboBox1.Items.Add("Прих Кат3");
                comboBox1.Items.Add("Прих Кат4");
                comboBox1.SelectedIndex = 0;
            }
            else if (comboBox2.SelectedItem == "Разход")
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Раз Кат1");
                comboBox1.Items.Add("Раз Кат2");
                comboBox1.Items.Add("Раз Кат3");
                comboBox1.Items.Add("Раз Кат4");
                comboBox1.SelectedIndex = 0;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControlSearch_Load(object sender, EventArgs e)
        {
        
            
        }
    }
}
