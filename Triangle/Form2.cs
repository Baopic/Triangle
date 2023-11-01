using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    public partial class Form2 : Form
    {
        public double a, b, c;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public Form2(double a, double b, double c)
        {
            InitializeComponent();
            this.a = a;
            this.b = b;
            this.c = c;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                label5.Text = "Треугольник не существует";
                return;
            }

            if (a == b && b == c)
            {
                label5.Text = "Равносторонний треугольник";
            }
            else if (a == b || a == c || b == c)
            {
                label5.Text = "Равнобедренный треугольник";
            }
            else
            {
                label5.Text = "Разносторонний треугольник";
            }
        }
    }
}
