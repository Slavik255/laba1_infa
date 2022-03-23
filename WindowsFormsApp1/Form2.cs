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
    public partial class Form2 : Form
    {
        FormOrganizer form2;

        public Form2()
        {
            InitializeComponent();
        }
        public Form2(FormOrganizer otherForm)
        {
            InitializeComponent();

            form2 = otherForm;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Meeting");
            comboBox1.Items.Add("Memo");
            comboBox1.Items.Add("Task");

        }
        private void Form2_Load_1(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Meeting");
            comboBox1.Items.Add("Memo");
            comboBox1.Items.Add("Task");
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string U, T, D;
            U = dateTimePicker1.Text;
            T = comboBox1.Text;
            D = monthCalendar1.Text;

            ListViewItem item1 = new ListViewItem(monthCalendar1.SelectionStart.ToShortDateString().ToString());
            item1.SubItems.Add(dateTimePicker1.Value.ToShortTimeString());
            item1.SubItems.Add(comboBox1.Text);
            item1.SubItems.Add(textBox1.Text);

            form2.listView1.Items.AddRange(new ListViewItem[] { item1 });

            //form2.listView1.Items.Add(dateTimePicker1.Value.ToShortTimeString());
            //form2.listView1.Items.Add(monthCalendar1.ShowToday.ToString());
            //form2.listView1.Items.Add(comboBox1.Text);
        }
    }
}
