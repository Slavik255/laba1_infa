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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            AutoCompleteStringCollection source = new AutoCompleteStringCollection()
        {   
            "ГУМАНИТАРНЫЕ НАУКИ",
            "ЕСТЕСТВЕННЫЕ НАУКИ",
            "ЖУРНАЛИСТИКА И ИНФОРМАЦИЯ",
            "ИНФОРМАТИКА И ВЫЧИСЛИТЕЛЬНАЯ ТЕХНИКА",
            "ИНФОРМАЦИОННАЯ БЕЗОПАСНОСТЬ",
            "МЕЖДУНАРОДНЫЕ ОТНОШЕНИЯ",
            "МЕНЕДЖМЕНТ И АДМИНИСТРИРОВАНИЕ",
            "МЕТРОЛОГИЯ, ИЗМЕРИТЕЛЬНАЯ ТЕХНИКА И ИНФОРМАЦИОННО-ИЗМЕРИТЕЛЬНЫЕ ТЕХНОЛОГИИ",
            "ПРАВО",
            "СИСТЕМНЫЕ НАУКИ И КИБЕРНЕТИКА",
            "СОЦИАЛЬНО-ПОЛИТИЧЕСКИЕ НАУКИ",
        };
            textBox1.AutoCompleteCustomSource = source;
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            userSurnameField.TextChanged += userSurnameField_TextChanged;
            frm2 = new Form2();
        }
        Form2 frm2;
        private void userSurnameField_TextChanged(object sender, EventArgs e)
        {
            Class1.strTextChangeN1 = userSurnameField.Text;
        }

        private void userNameField_TextChanged(object sender, EventArgs e)
        {
            Class1.strTextChangeN2 = userNameField.Text;
        }

        private void userLastnameField_TextChanged(object sender, EventArgs e)
        {
            Class1.strTextChangeN3 = userLastnameField.Text;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            
            Form2 frm2 = new Form2(this.userSurnameField.Text);
            frm2.Show();

        }

        private void userSurnameField_MouseHover_1(object sender, EventArgs e)
        {
            toolTip1.Show("Фамилия", userSurnameField);
        }
        private void userNameField_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Имя", userNameField);
        }

        private void userLastnameField_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Отчество", userLastnameField);
        }

       

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Class1.strTextChangeN6 = checkedListBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Class1.strTextChangeN4 = textBox1.Text;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            Class1.strTextChangeN5 = comboBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
        
}
