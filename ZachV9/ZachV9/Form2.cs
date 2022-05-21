using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZachV9
{
    public partial class Form2 : Form
    {

        string label1Text = "Фамилия";
        string label2Text = "Имя";
        string label3Text = "Отчество";
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string text)
        {
            InitializeComponent();
            label1Text = text;
            label2Text = text;
            label3Text = text;
            label1.Text = Class1.strTextChangeN1;
            label3.Text = Class1.strTextChangeN2;
            label2.Text = Class1.strTextChangeN3;
            label4.Text = Class1.strTextChangeN4;
            label5.Text = Class1.strTextChangeN5;
            label6.Text = Class1.strTextChangeN6;
        }
       
        
        public void button2_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Application.Exit();*/
            this.Hide();
           
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = Class1.strTextChangeN1 ;
        }
        private void label1_Text(object sender, EventArgs e)
        {
            label1.Text = Class1.strTextChangeN1;
        }

        private void label2_TextChanged(object sender, EventArgs e)
        {
            label2.Text = Class1.strTextChangeN2 ;
        }

        private void label3_TextChanged(object sender, EventArgs e)
        {
            label3.Text = Class1.strTextChangeN3;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
