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
    public partial class Form1 : Form
    {
        private double datos1;/*aqui va las variables globales*/
        private double datos2;
        private char operacion;
        private double rpta;
        int x = 1;
        Form1(int datos1, int datos2,int dato3, char operacion)
        {
            this.datos1 = datos1;
            this.datos2 = datos2;
            this.operacion = operacion;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "")
            {
                if (operacion != Convert.ToChar("+"))//cambia de una operacion a otra
                {
                    x = 1;
                }
                if (x!=1)
                {
                    this.datos2 = Convert.ToInt32(textBox1.Text);
                    this.operacion = Convert.ToChar("+");
                    textBox1.Text = Convert.ToString(Toperacion());
                    datos1 = rpta;
                    //this.datos1 = datos2;
                    //this.datos2 = Convert.ToInt32(null);
                }
                else
                {
                    this.datos1 = Convert.ToInt32(textBox1.Text);
                    this.operacion = Convert.ToChar("+");
                    textBox1.Text = "";
                    x = 2;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.datos1 != null && this.datos2 != null)
            {
                this.datos2 = Convert.ToInt32(textBox1.Text);
                textBox1.Text = "";
                textBox1.Text = Convert.ToString(Toperacion());
            }
        }
        private double Toperacion()
        {
            if (this.operacion == Convert.ToChar("+"))
            {
                return rpta=this.datos1 + this.datos2;
            }
            else
            {
                if (this.operacion == Convert.ToChar("-"))
                {
                    return rpta=this.datos1 - this.datos2;
                }
                else
                {
                    if (this.operacion == Convert.ToChar("*"))
                    {
                        return rpta=this.datos1 * this.datos2;
                    }
                    else
                    {
                        return rpta=this.datos1 / this.datos2;
                    }

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (operacion != Convert.ToChar("-"))//cambia de una operacion a otra
                {
                    x = 1;
                }
                if (x != 1)
                {
                    this.datos2 = Convert.ToInt32(textBox1.Text);
                    this.operacion = Convert.ToChar("-");
                    textBox1.Text = Convert.ToString(Toperacion());
                    datos1 = rpta;
                    //this.datos1 = datos2;
                    //this.datos2 = Convert.ToInt32(null);
                }
                else
                {
                    this.datos1 = Convert.ToInt32(textBox1.Text);
                    this.operacion = Convert.ToChar("-");
                    textBox1.Text = "";
                    x = 2;
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (operacion != Convert.ToChar("*"))//cambia de una operacion a otra
                {
                    x = 1;
                }
            if (x != 1)
                {
                    this.datos2 = Convert.ToInt32(textBox1.Text);
                    this.operacion = Convert.ToChar("*");
                    textBox1.Text = Convert.ToString(Toperacion());
                    datos1 = rpta;
                    //this.datos1 = datos2;
                    //this.datos2 = Convert.ToInt32(null);
                }
            else
                {
                    this.datos1 = Convert.ToDouble(textBox1.Text);
                    this.operacion = Convert.ToChar("*");
                    textBox1.Text = "";
                    x = 2;
                }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (operacion != Convert.ToChar("/"))//cambia de una operacion a otra
            {
                x = 1;
            }
            if (x != 1)
            {
                this.datos2 = Convert.ToInt32(textBox1.Text);
                this.operacion = Convert.ToChar("/");
                textBox1.Text = Convert.ToString(Toperacion());
                datos1 = rpta;
                //this.datos1 = datos2;
                //this.datos2 = Convert.ToInt32(null);
            }
            else
            {
                this.datos1 = Convert.ToInt32(textBox1.Text);
                this.operacion = Convert.ToChar("/");
                textBox1.Text = "";
                x = 2;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            datos1 = 0;
            datos2 = 0;
            rpta = 0;
            Close();
        }
    }
}
