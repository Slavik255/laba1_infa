using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /// Автоматическое подстраивание ширины и высоты будет отключено
            this.Password.AutoSize = false;
            this.Password.Size = new System.Drawing.Size(this.Password.Size.Width, 46);
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("CLICK!");
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            string log = "123";
            string pas = "123";
            if (Login.Text == log & Password.Text == pas)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else MessageBox.Show("Wrong login or password!");

        }

        private void Login_TextChanged(object sender, System.EventArgs e)
        {
      
        }

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (Show.Checked)
                Password.PasswordChar = (char)0;
            else
                Password.PasswordChar = '*';
        }

        private void Password_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
