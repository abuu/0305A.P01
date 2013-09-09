using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.GetItemText(1)== "CELSIUS" && listBox1.SelectedValue == "KELVIN")
            {
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + 273);
            }
            if (listBox1.GetItemText(0) == "KELVIN" && listBox2.GetItemText(1) == "CELSIUS")
            {
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) - 273);
            }
            //CELSIUS KELVIN FAHERNHEIT    (listBox1.SelectedItem == "KELVIN" && listBox2.SelectedItem == "CELSIUS") || 
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
