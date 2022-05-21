using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem lvi = new ListViewItem(Name.Text);
                lvi.SubItems.Add(Special.Text);
                lvi.SubItems.Add(Cours.Text);
                if (B.Checked)
                {
                    lvi.SubItems.Add(B.Text);
                }
                else
                {
                    lvi.SubItems.Add(K.Text);
                }
                listView1.Items.Add(lvi);
            }
            catch { }
        }

        private void Red_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.SelectedItems[0].Text = Name.Text;
                listView1.SelectedItems[0].SubItems[1].Text = Special.Text;
                listView1.SelectedItems[0].SubItems[2].Text = Cours.Text;
                listView1.SelectedItems[0].SubItems[3].Text = B.Checked ? B.Text : K.Text;
            }
            catch { }
        }

        private void Dell_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            catch { }
        }

        private void Info_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            foreach(ListViewItem item in listView1.Items)
            {
                if(item.SubItems[3].Text == "Контракт")
                {
                    ListInfo.listViews.Add((ListViewItem)item.Clone());
                }
            }
            form2.ShowDialog();
        }
    }
}
