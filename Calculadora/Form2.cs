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
            if ((string)listBox1.SelectedItem == "CELSIUS" && (string) listBox2.SelectedItem == "KELVIN")
            {
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + 273);
            }
            if ((string)listBox1.SelectedItem == "KELVIN" && (string)listBox2.SelectedItem == "CELSIUS")
            {
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) - 273);
            }
            if ((string)listBox1.SelectedItem == "CELSIUS" && (string)listBox2.SelectedItem == "FAHERNHEIT")
            {
                textBox3.Text = Convert.ToString(((Convert.ToInt32(textBox1.Text) *9)/5)+32);
            }
            if ((string)listBox1.SelectedItem == "FAHERNHEIT" && (string)listBox2.SelectedItem == "CELSIUS")
            {
                textBox3.Text = Convert.ToString((Convert.ToInt32(textBox1.Text) - 32) / 9);
            }
            if ((string)listBox1.SelectedItem == "FAHERNHEIT" && (string)listBox2.SelectedItem == "KELVIN")
            {
               int temp;
                temp=(Convert.ToInt32(textBox1.Text) - 32) / 9;
                textBox3.Text = Convert.ToString(temp + 273);
            }
            if ((string)listBox1.SelectedItem == "KELVIN" && (string)listBox2.SelectedItem == "FAHERNHEIT")
            {
                int temp2;
                temp2 = Convert.ToInt32(textBox1.Text) - 273;
                textBox3.Text = Convert.ToString(((temp2 * 9) / 5) + 32);
            }
            if ((string)listBox1.SelectedItem == "FAHERNHEIT" && (string)listBox2.SelectedItem == "FAHERNHEIT")
            {
                textBox3.Text = textBox1.Text;
            }
            if ((string)listBox1.SelectedItem == "KELVIN" && (string)listBox2.SelectedItem == "KELVIN")
            {
                textBox3.Text = textBox1.Text;
            }
            if ((string)listBox1.SelectedItem == "CELSIUS" && (string)listBox2.SelectedItem == "CELSIUS")
            {
                textBox3.Text = textBox1.Text;
            }

            //CELSIUS KELVIN FAHERNHEIT    (listBox1.SelectedItem == "KELVIN" && listBox2.SelectedItem == "CELSIUS") || 
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
/*
  public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((string)listBox1.SelectedItem == "Two")
                label1.Text = "bien";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("One");
            listBox1.Items.Add("Two");
            listBox1.Items.Add("Three");
        }
        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }
 */