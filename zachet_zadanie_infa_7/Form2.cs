using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zachet_zadanie_infa_7
{
    public partial class Form2 : Form
    {
        public static Func<string> GetText;
        public Form2()
        {
            InitializeComponent();
            this.Width = 417;
            this.Height = 301;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string Str = textBox2.Text.Trim();
            int Num;
            bool isNum = int.TryParse(Str, out Num);
            if (isNum)
            {
                double r = Convert.ToDouble(textBox2.Text);
                double p = 3.14;
                double result = p * Math.Pow(r, 2);
                textBox2.Text = Convert.ToString(result);
                Form4 form4 = new Form4();
                this.Hide();
                form4.ShowDialog();
                this.Close();
            }
            else MessageBox.Show("Вы ввели не число!!!");
        }       
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Class1.strTextChangeN1 = textBox2.Text;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

    }
}
