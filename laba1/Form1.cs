using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Class1 instanceClass1 = new Class1();


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            bool success = int.TryParse(instanceClass1.n, out number)
            instanceClass1.n = Convert.ToInt32(textBox1.Text);
            if (instanceClass1.n < 100 || instanceClass1.n > 999)
            {
                label1.BackColor = Color.Red;
                label1.Text = "Введенное число не является трехзначным!";
            }
            else
            {
                label1.BackColor = Color.Aqua;
                label1.Text = "Набрано трехзначное число";
                instanceClass1.digit();
                textBox2.Text = "Сумма двух наименьших чисел" + "\r\n";
                textBox2.Text = textBox2.Text + instanceClass1.st + instanceClass1.s;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
