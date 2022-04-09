using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba2_infa
{
    public partial class Form1 : Form
    {
        public void DriveTreeInit()
        {
            string[] drivesArray = Directory.GetLogicalDrives();
            treeView1.BeginUpdate();
            treeView1.Nodes.Clear();

            foreach (string s in drivesArray)
            {
                TreeNode drive = new TreeNode(s, 0, 0);
                treeView1.Nodes.Add(drive);

                GetDirs(drive);
            }

            treeView1.EndUpdate();
        }

        public Form1()
        {
            InitializeComponent();
            DriveTreeInit();
        }

        /////Получение папок
        /////
        /////
        string fullPath;

        public void GetDirs(TreeNode node)
        {
            DirectoryInfo[] diArray;

            node.Nodes.Clear();

            fullPath = node.FullPath;
            DirectoryInfo di = new DirectoryInfo(fullPath);

            try
            {
                diArray = di.GetDirectories();
            }
            catch { return; }


            foreach (DirectoryInfo dirinfo in diArray)
            {
                TreeNode dir = new TreeNode(dirinfo.Name, 0, 1);
                node.Nodes.Add(dir);
            }
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            listView1.CheckBoxes = true;
        }

        private void treeView1_BeforeExpand(object sender, TreeViewEventArgs e)
        {
            treeView1.BeginUpdate();

            foreach (TreeNode node in e.Node.Nodes)
            {
                GetDirs(node);
            }

            treeView1.EndUpdate();
        }

        private void открытьToolStripButton1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                treeView1.BeginUpdate();
                treeView1.Nodes.Clear();
                TreeNode TN = new TreeNode(fbd.SelectedPath);
                treeView1.Nodes.Add(TN);
                GetDirs(TN);


                treeView1.EndUpdate();
            }
        }

        private void сохранитьToolStripButton1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {

                TreeNode TNode = treeView1.SelectedNode;
                string DI_path = TNode.FullPath;
                string path = fbd.SelectedPath + @"\saved.txt";
                FileStream FS = new FileStream(path, FileMode.Create, FileAccess.Write);
                StreamWriter file = new StreamWriter(FS);



                DirectoryInfo DI = new DirectoryInfo(DI_path);
                DirectoryInfo[] dri = DI.GetDirectories();
                foreach (DirectoryInfo s in dri)
                {
                    file.Write(s.Name);
                }
                file.Close();
                FS.Close();
            }
        }

        private void справкаToolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("К сожалению, я не знаю, чем вам помочь! По вопросам обращайтесь к уважаемой Мартыненко А.М.!");
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        void MoreFiles(TreeViewEventArgs e)
        {
            treeView1.BeginUpdate();

            foreach (TreeNode node in e.Node.Nodes)
            {
                GetDirs(node);
            }

            treeView1.EndUpdate();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode SelectedNode = e.Node;
            fullPath = SelectedNode.FullPath;
            DirectoryInfo DI = new DirectoryInfo(fullPath);
            FileInfo[] FIarray;
            DirectoryInfo[] DIarray;

            try
            {
                FIarray = DI.GetFiles();
                DIarray = DI.GetDirectories();
            }
            catch
            {
                return;
            }

            listView1.Items.Clear();


            //Directories
            foreach (DirectoryInfo dirInfo in DIarray)
            {
                ListViewItem lvi = new ListViewItem(dirInfo.Name);
                lvi.SubItems.Add("");
                lvi.SubItems.Add("");
                lvi.Checked = true;
                listView1.Items.Add(lvi);
            }


            //Files
            long counter = 0,
                 counterSmall = 0,
                 counterMid = 0,
                 counterBig = 0,
                 png = 0,
                 jpg = 0,
                 bmp = 0,
                 gif = 0,
                 docx = 0,
                 xlsx = 0,
                 pdf = 0,
                 txt = 0,
                 zip = 0,
                 rar = 0,
                 exe = 0,
                 dll = 0,
                 ini = 0,
                 sys = 0,
                 dat = 0,
                fb2 = 0,
                html = 0,
                js = 0;
            string textSmall = "",
                   textMid = "",
                   textBig = "";


            foreach (FileInfo fileInfo in FIarray)
            {
                ListViewItem lvi = new ListViewItem(fileInfo.Name);
                lvi.Tag = fileInfo.FullName;
                lvi.SubItems.Add(fileInfo.Length.ToString());
                string fileNameExtension = Path.GetExtension(fileInfo.Name).ToLower(); // Расширение
                lvi.SubItems.Add(fileNameExtension);
                lvi.Checked = true;

                if (fileNameExtension == ".png" || fileNameExtension == ".jpg" || fileNameExtension == ".bmp" || fileNameExtension == ".gif")
                {
                    lvi.BackColor = Color.PaleGreen;
                }
                else if (fileNameExtension == ".docx" || fileNameExtension == ".xlsx" || fileNameExtension == ".pdf" || fileNameExtension == ".txt")
                {
                    lvi.BackColor = Color.LightBlue;
                }
                else if (fileNameExtension == ".zip" || fileNameExtension == ".rar" || fileNameExtension == ".7z")
                {
                    lvi.BackColor = Color.Yellow;
                }
                else if (fileNameExtension == ".exe" || fileNameExtension == ".dll" || fileNameExtension == ".ini" || fileNameExtension == ".sys")
                {
                    lvi.BackColor = Color.Red;
                }
                listView1.Items.Add(lvi);


                if (fileNameExtension == ".png")
                {
                    png++;
                }
                if (fileNameExtension == ".jpg")
                {
                    jpg++;
                }
                if (fileNameExtension == ".bmp")
                {
                    bmp++;
                }
                if (fileNameExtension == ".gif")
                {
                    gif++;
                }
                if (fileNameExtension == ".docx")
                {
                    docx++;
                }
                if (fileNameExtension == ".xlsx")
                {
                    xlsx++;
                }
                if (fileNameExtension == ".pdf")
                {
                    pdf++;
                }
                if (fileNameExtension == ".txt")
                {
                    txt++;
                }
                if (fileNameExtension == ".zip")
                {
                    zip++;
                }
                if (fileNameExtension == ".rar")
                {
                    rar++;
                }
                if (fileNameExtension == ".exe")
                {
                    exe++;
                }
                if (fileNameExtension == ".dll")
                {
                    dll++;
                }
                if (fileNameExtension == ".ini")
                {
                    ini++;
                }
                if (fileNameExtension == ".sys")
                {
                    sys++;
                }
                if (fileNameExtension == ".dat")
                {
                    dat++;
                }
                if (fileNameExtension == ".fb2")
                {
                    fb2++;
                }
                if (fileNameExtension == ".html")
                {
                    html++;
                }
                if (fileNameExtension == ".js")
                {
                    js++;
                }


                counter += fileInfo.Length;
                if (fileInfo.Length < 100000)
                {
                    counterSmall++;
                    textSmall += fileInfo.Name;
                }
                else if (fileInfo.Length > 100000 && fileInfo.Length < 1000000)
                {
                    counterMid++;
                    textMid += fileInfo.Name;
                }
                else if (fileInfo.Length > 1000000)
                {
                    counterBig++;
                    textBig += fileInfo.Name;
                }
            }


            //StatusBar
            statusStrip1.Items[0].Text = "Всего байт в папке: " + counter;
            statusStrip1.Items[1].Text = "Выбрано " + listView1.CheckedItems.Count + " элементов из " + listView1.CheckedItems.Count;
            MoreFiles(e);

            chart1.Series.Clear();
            chart1.Series.Add("Расширения файлов");

            chart1.ChartAreas[0].AxisX.Interval = 1;

            chart1.ChartAreas[0].AxisX.Maximum = 20;
            chart1.ChartAreas[0].AxisY.Maximum = 20;

            chart1.Series[0].Points.AddXY("exe", exe);
            chart1.Series[0].Points.AddXY("txt", txt);
            chart1.Series[0].Points.AddXY("docx", docx);
            chart1.Series[0].Points.AddXY("png", png);
            chart1.Series[0].Points.AddXY("jpg", jpg);
            chart1.Series[0].Points.AddXY("bmp", bmp);
            chart1.Series[0].Points.AddXY("gif", gif);
            chart1.Series[0].Points.AddXY("xlsx", xlsx);
            chart1.Series[0].Points.AddXY("pdf", pdf);
            chart1.Series[0].Points.AddXY("zip", zip);
            chart1.Series[0].Points.AddXY("rar", rar);
            chart1.Series[0].Points.AddXY("dll", dll);
            chart1.Series[0].Points.AddXY("ini", ini);
            chart1.Series[0].Points.AddXY("sys", sys);
            chart1.Series[0].Points.AddXY("dat", dat);
            chart1.Series[0].Points.AddXY("fb2", fb2);
            chart1.Series[0].Points.AddXY("html", html);
            chart1.Series[0].Points.AddXY("js", js);
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType++;
            statusStrip1.Items[0].Text = chart1.Series[0].ChartType.ToString();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                int sizeMaxList = listView1.Items.Count;
                int x = listView1.CheckedItems.Count;


                statusStrip1.Items[1].Text = "Выбрано " + x + " элементов из " + sizeMaxList;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                listView1.Font = fd.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {

                listView1.BackColor = cd.Color;
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("К сожалению, я не знаю, чем вам помочь!");
        }

        private void справкаToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("К сожалению, я не знаю, чем вам помочь!");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {

                TreeNode TNode = treeView1.SelectedNode;
                string DI_path = TNode.FullPath;
                string path = fbd.SelectedPath + @"\saved.txt";
                FileStream FS = new FileStream(path, FileMode.Create, FileAccess.Write);
                StreamWriter file = new StreamWriter(FS);



                DirectoryInfo DI = new DirectoryInfo(DI_path);
                DirectoryInfo[] dri = DI.GetDirectories();
                foreach (DirectoryInfo s in dri)
                {
                    file.Write(s.Name);
                }
                file.Close();
                FS.Close();
            }
        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {

                TreeNode TNode = treeView1.SelectedNode;
                string DI_path = TNode.FullPath;
                string path = fbd.SelectedPath + @"\saved.txt";
                FileStream FS = new FileStream(path, FileMode.Create, FileAccess.Write);
                StreamWriter file = new StreamWriter(FS);



                DirectoryInfo DI = new DirectoryInfo(DI_path);
                DirectoryInfo[] dri = DI.GetDirectories();
                foreach (DirectoryInfo s in dri)
                {
                    file.Write(s.Name);
                }
                file.Close();
                FS.Close();
            }
        }

        private void открытьToolStripButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                treeView1.BeginUpdate();
                treeView1.Nodes.Clear();
                TreeNode TN = new TreeNode(fbd.SelectedPath);
                treeView1.Nodes.Add(TN);
                GetDirs(TN);


                treeView1.EndUpdate();
            }
        }
    }
}
