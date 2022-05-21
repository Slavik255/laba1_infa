using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olega
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 598;
            this.Height = 389;         
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Class1.strTextChangeN1 = textBox1.Text;
            button1.Enabled = this.Controls.OfType<TextBox>().All(x => x.Text.Length > 0);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Class1.strTextChangeN2 = textBox2.Text;
            button1.Enabled = this.Controls.OfType<TextBox>().All(x => x.Text.Length > 0);
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Class1.strTextChangeN3 = textBox3.Text;
            button1.Enabled = this.Controls.OfType<TextBox>().All(x => x.Text.Length > 0);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Class1.strTextChangeN4 = comboBox1.Text;
            button1.Enabled = this.Controls.OfType<TextBox>().All(x => x.Text.Length > 0);
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Class1.strTextChangeN5 = textBox4.Text;
            button1.Enabled = this.Controls.OfType<TextBox>().All(x => x.Text.Length > 0);
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Class1.strTextChangeN6 = textBox5.Text;
            button1.Enabled = this.Controls.OfType<TextBox>().All(x => x.Text.Length > 0);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string Str = textBox4.Text.Trim();
            int Num;
            bool a = int.TryParse(Str, out Num);
            if(a)
            {
                double b = Convert.ToDouble(textBox4.Text);
                if (b >= 0 && b <= 10)
                {
                    textBox4.Text = Convert.ToString(b);
                    Class1.strTextChangeN5 = textBox4.Text;
                    Form2 form2 = new Form2();
                    this.Hide();
                    form2.ShowDialog();
                    this.Close();
                }
                else MessageBox.Show("Вы недопустимое значение веса!!!");
            }
            else MessageBox.Show("Вы ввели не число!!!");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Вещественный");
            comboBox1.Items.Add("Невещественный");
            button1.Enabled = false;
        }
    }
}
