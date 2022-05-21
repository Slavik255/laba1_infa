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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.Width = 347;
            this.Height = 189;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label2.Text = Class1.strTextChangeN1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_TextChanged(object sender, EventArgs e)
        {
            label2.Text = Class1.strTextChangeN1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
