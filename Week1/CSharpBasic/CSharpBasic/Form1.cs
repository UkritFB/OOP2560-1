using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBasic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "bool22";
            textBox2.Text = sizeof(bool).ToString();
            textBox3.Text = "Ture";
            textBox4.Text = "False";
  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "char";
            textBox2.Text = sizeof(char).ToString();
            textBox3.Text = (char.MinValue - '\0' ).ToString();
            textBox4.Text = (char.MaxValue - '\0').ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "unsigned int 16 bit";
            textBox2.Text = sizeof(UInt16).ToString();
            textBox3.Text = (UInt16.MinValue - '\0').ToString();
            textBox4.Text = (UInt16.MaxValue - '\0').ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Sbyte";
            textBox2.Text = sizeof(SByte).ToString();
            textBox3.Text = (SByte.MinValue - '\0').ToString();
            textBox4.Text = (SByte.MaxValue - '\0').ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Long";
            textBox2.Text = sizeof(long).ToString();
            textBox3.Text = (long.MinValue - '\0').ToString();
            textBox4.Text = (long.MaxValue - '\0').ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "float";
            textBox2.Text = sizeof(float).ToString();
            textBox3.Text = float.MinValue.ToString();
            textBox4.Text = float.MaxValue.ToString();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "byte";
            textBox2.Text = sizeof(byte).ToString();
            textBox3.Text = byte.MinValue.ToString();
            textBox4.Text = byte.MaxValue.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "decimal";
            textBox2.Text = sizeof(decimal ).ToString();
            textBox3.Text = decimal .MinValue.ToString();
            textBox4.Text = decimal .MaxValue.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "double";
            textBox2.Text = sizeof(double).ToString();
            textBox3.Text = double .MinValue.ToString();
            textBox4.Text = double .MaxValue.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "int";
            textBox2.Text = sizeof(int).ToString();
            textBox3.Text = int.MinValue.ToString();
            textBox4.Text = int.MaxValue.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "short";
            textBox2.Text = sizeof(short ).ToString();
            textBox3.Text = short .MinValue.ToString();
            textBox4.Text = short .MaxValue.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "uint";
            textBox2.Text = sizeof(uint ).ToString();
            textBox3.Text = uint .MinValue.ToString();
            textBox4.Text = uint .MaxValue.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "ulong";
            textBox2.Text = sizeof(ulong ).ToString();
            textBox3.Text = ulong .MinValue.ToString();
            textBox4.Text = ulong .MaxValue.ToString();
        }
    }
}
