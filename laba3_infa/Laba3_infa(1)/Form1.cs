using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;


namespace Lab3_task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 1300;
            this.Height = 930;
        }
        private void GetFiles(FileInfo[] files)
        {
            Data.imageDirectories = new List<string>();
            var photoFiles = new string[] { ".png", ".jpg", ".bmp", ".gif" };

            imageList1.ImageSize = new Size(150, 150);
            listView1.View = View.LargeIcon;
            listView1.Items.Clear();
            imageList1.Images.Clear();
            listView2.Items.Clear();
            listView1.LargeImageList = imageList1;

            foreach (var image in files)
            {
                if (photoFiles.Contains(image.Extension))
                {
                    imageList1.Images.Add(new Bitmap(image.FullName));
                    Data.imageDirectories.Add(image.FullName);
                }
            }
            if (imageList1.Images.Count == 0)
            {
                MessageBox.Show("There are no images!");
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                return;
            }
            for (int i = 0; i < imageList1.Images.Count; i++)
            {
                ListViewItem image = new ListViewItem();
                image.ImageIndex = i;
                listView1.Items.Add(image);
            }

            foreach (var image in files)
            {
                if (photoFiles.Contains(image.Extension))
                {
                    var photo = Image.FromFile(image.FullName);
                    ListViewItem item = new ListViewItem(new string[] { image.Name, photo.Width.ToString(), photo.Height.ToString(), "" });
                    listView2.Items.Add(item);
                    listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }
        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            var index = listView1.SelectedItems[0].Index;
            var FileInfo = new FileInfo(Data.imageDirectories.ElementAt(index));
            var image = Image.FromFile(FileInfo.FullName);
            Data.imagePath = FileInfo.FullName;
            pictureBox1.Image = image;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (Data.Copyright == null || Data.Copyright.Trim() == string.Empty)
            {
                MessageBox.Show("Write your copyright!");
            }
            else
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
                saveFile.Title = "Save an Image File";
                saveFile.ShowDialog();

                if (saveFile.FileName != "")
                {
                    System.IO.FileStream fileStream = (System.IO.FileStream)saveFile.OpenFile();
                    var image = Image.FromFile(@"E:\Program po 3d modelirovanii-o\Rabotu visual studio\laba3_infa\Laba3_infa(1)\temp\\temp.jpg");
                    switch (saveFile.FilterIndex)
                    {
                        case 1:
                        {
                            image.Save(fileStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;
                        }                          
                        case 2:
                        {
                            image.Save(fileStream, System.Drawing.Imaging.ImageFormat.Bmp);
                            break;
                        }                           
                        case 3:
                        {
                            image.Save(fileStream, System.Drawing.Imaging.ImageFormat.Gif);
                            break;
                        }                           
                    }
                    image.Dispose();
                    image = null;
                    fileStream.Dispose();
                    fileStream.Close();
                    fileStream = null;
                }
            }
        }       
        private void addCopyrightingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
        private void batchModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Data.file = new FileInfo(openFileDialog1.FileName);
                if (!Data.file.Exists)
                {
                    MessageBox.Show("Choose correct file!");
                }
                else
                {
                    GetFiles(new FileInfo[] { Data.file });
                }
            }
        }
        private void openDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Data.directory = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                if (!Data.directory.Exists)
                {
                    MessageBox.Show("Choose correct directory!");
                }
                else
                {
                    GetFiles(Data.directory.GetFiles());
                }
            }
        }
        private void saveImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }
        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && listView1.SelectedItems.Count != 0)
            {
                var index = listView1.SelectedItems[0].Index;
                listView1.Items.RemoveAt(index);
                listView2.Items.RemoveAt(index);
                imageList1.Images.RemoveAt(index);
                Data.imageDirectories.RemoveAt(index);
                listView1.LargeImageList = new ImageList();
                listView1.LargeImageList = imageList1;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Data.directory = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                if (!Data.directory.Exists)
                {
                    MessageBox.Show("Choose correct directory!");
                }
                else
                {
                    if (Data.Copyright == null || Data.Copyright.Trim() == string.Empty)
                    {
                        MessageBox.Show("Write your copyright!");
                    }
                    else
                    {
                        foreach (var text in Data.imageDirectories)
                        {
                            if (pictureBox1.Image != null)
                            {
                                Image image = Image.FromFile(text);
                                Graphics graphics = Graphics.FromImage(image);
                                graphics.DrawString(Data.Copyright, new System.Drawing.Font("Times new roman", 18, FontStyle.Bold), new SolidBrush(Color.Black), new RectangleF(100, 300, 0, 100), new StringFormat(StringFormatFlags.NoWrap));
                                pictureBox1.Image.Dispose();
                                if (File.Exists(@"E:\Program po 3d modelirovanii-o\Rabotu visual studio\laba3_infa\Laba3_infa(1)\temp\\temp.jpg"))
                                {
                                    File.Delete(@"E:\Program po 3d modelirovanii-o\Rabotu visual studio\laba3_infa\Laba3_infa(1)\temp\\temp.jpg");
                                }

                                image.Save(@"E:\Program po 3d modelirovanii-o\Rabotu visual studio\laba3_infa\Laba3_infa(1)\temp\\temp.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                                pictureBox1.Image = image;

                                var item = listView1.SelectedItems[0];
                                var count = 0;
                                for (int i = 0; i < listView1.Items.Count; i++)
                                {
                                    if (listView1.Items[i] == item)
                                    {
                                        count = i;
                                    }
                                }
                                Data.needToCopyright = false;
                            }

                            var save = Image.FromFile(@"E:\Program po 3d modelirovanii-o\Rabotu visual studio\laba3_infa\Laba3_infa(1)\temp\\temp.jpg");
                            save.Save($@"{Data.directory}\{(new FileInfo(text).Name)}", System.Drawing.Imaging.ImageFormat.Jpeg);
                            save.Dispose();
                            save = null;            
                        }
                        MessageBox.Show("All files are saved.");
                    }
                }
            }
        }
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void copyrightTextToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            if (Data.needToCopyright)
            {
                if (pictureBox1.Image != null)
                {
                    Image image = Image.FromFile(Data.imagePath);
                    Graphics graphics = Graphics.FromImage(image);
                    graphics.DrawString(Data.Copyright, new System.Drawing.Font("Times new roman", 18, FontStyle.Bold), new SolidBrush(Color.Black), new RectangleF(100, 300, 0, 100), new StringFormat(StringFormatFlags.NoWrap));
                    pictureBox1.Image.Dispose();
                    if (File.Exists(@"E:\Program po 3d modelirovanii-o\Rabotu visual studio\laba3_infa\Laba3_infa(1)\temp\\temp.jpg"))
                    {
                        File.Delete(@"E:\Program po 3d modelirovanii-o\Rabotu visual studio\laba3_infa\Laba3_infa(1)\temp\\temp.jpg");
                    }
                    image.Save(@"E:\Program po 3d modelirovanii-o\Rabotu visual studio\laba3_infa\Laba3_infa(1)\temp\\temp.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                    pictureBox1.Image = image;

                    var item = listView1.SelectedItems[0];
                    var count = 0;
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        if (listView1.Items[i] == item)
                        {
                            count = i;
                        }
                    }
                    var fileInfo = new FileInfo(Data.imageDirectories[count]);
                    var photo = Image.FromFile(Data.imageDirectories[count]);
                    listView2.Items[count] = new ListViewItem(new string[] { fileInfo.Name, photo.Width.ToString(), photo.Height.ToString(), Data.Copyright });
                    listView1.Items[count].BackColor = Color.Red;


                    Bitmap TargetBitmapImage = new Bitmap(Data.imagePath);
                    Bitmap BitmapOverlay = new Bitmap(@"E:\Program po 3d modelirovanii-o\Rabotu visual studio\laba3_infa\Laba3_infa(1)\Resources\Background.jpg");
                    Bitmap ResultBitmapImage = new Bitmap(TargetBitmapImage.Width, TargetBitmapImage.Height, PixelFormat.Format32bppArgb);
                    Graphics picture = Graphics.FromImage(ResultBitmapImage);
                    picture.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
                    picture.DrawImage(TargetBitmapImage, 0, 0);

                    picture.DrawImage(BitmapOverlay, 0, 0);
                    Image Image2 = Image.FromHbitmap(ResultBitmapImage.GetHbitmap());
                    if (File.Exists(@"E:\Program po 3d modelirovanii-o\Rabotu visual studio\laba3_infa\Laba3_infa(1)\temp\temp2.jpg"))
                    {
                        File.Delete(@"E:\Program po 3d modelirovanii-o\Rabotu visual studio\laba3_infa\Laba3_infa(1)\temp\temp2.jpg");
                    }
                    Image2.Save(@"E:E:\Program po 3d modelirovanii-o\Rabotu visual studio\laba3_infa\Laba3_infa(1)\temp\temp2.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                    imageList1.Images[count] = Image2;
                    listView1.LargeImageList = new ImageList();
                    listView1.LargeImageList = imageList1;
                    Image2.Dispose();
                    Image2 = null;
                    image = null;
                    Data.needToCopyright = false;
                }
            }
            else if (Data.needToGetFiles)
            {
                GetFiles(Data.directory.GetFiles());
            }
        }
        private void copyrightDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("К сожалению, я не знаю, чем вам помочь!");
        }
        private void operationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
