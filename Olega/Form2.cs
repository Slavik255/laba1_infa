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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Width = 571; 
            this.Height = 312;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            label8.Text = Class1.strTextChangeN1;
            label9.Text = Class1.strTextChangeN2;
            label10.Text = Class1.strTextChangeN3;
            label11.Text = Class1.strTextChangeN4;
            label12.Text = Class1.strTextChangeN5;
            label13.Text = Class1.strTextChangeN6;
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
