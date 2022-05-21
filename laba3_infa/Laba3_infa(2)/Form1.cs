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

namespace Lab3_task2
{
    public partial class Form1 : Form
    {
        public int PlayerScore = 0;
        public int OldPlaerScore = 0;
        public int OpponentScore = 0;
        public int PositionButton = 700;
        public bool Pass = false;
        Bitmap Back = new Bitmap(@"E:\Program po 3d modelirovanii-o\Rabotu visual studio\laba3_infa\Laba3_infa(2)\Cards\Back.png");
        List<Card> Cards = new List<Card>();
        List<Card> ReserveCards = new List<Card>();
        List<Card> Reshuffle = new List<Card>();
        public bool Game_over = false;
        public int Random { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            DirectoryInfo directory = new DirectoryInfo(@"E:\Program po 3d modelirovanii-o\Rabotu visual studio\laba3_infa\Laba3_infa(2)\Cards\All");
            foreach(FileInfo file in directory.EnumerateFiles("*.png"))
            {                
                switch (file.Name[0])
                {
                    case '2':
                        Cards.Add(new Card(2, new Bitmap(Image.FromFile(file.FullName)), 140, 140));
                        break;
                    case '3':
                        Cards.Add(new Card(3, new Bitmap(Image.FromFile(file.FullName)), 140, 140));
                        break;
                    case '4':
                        Cards.Add(new Card(4, new Bitmap(Image.FromFile(file.FullName)), 140, 140));
                        break;
                    case '5':
                        Cards.Add(new Card(5, new Bitmap(Image.FromFile(file.FullName)), 140, 140));
                        break;
                    case '6':
                        Cards.Add(new Card(6, new Bitmap(Image.FromFile(file.FullName)), 140, 140));
                        break;
                    case '7':
                        Cards.Add(new Card(7, new Bitmap(Image.FromFile(file.FullName)), 140, 140));
                        break;
                    case '8':
                        Cards.Add(new Card(8, new Bitmap(Image.FromFile(file.FullName)), 140, 140));
                        break;
                    case '9':
                        Cards.Add(new Card(9, new Bitmap(Image.FromFile(file.FullName)), 140, 140));
                        break;
                    case 'T':
                        Cards.Add(new Card(10, new Bitmap(Image.FromFile(file.FullName)), 140, 140));
                        break;
                    case 'J' :
                        Cards.Add(new Card(10, new Bitmap(Image.FromFile(file.FullName)), 140, 140));
                        break;
                    case 'Q':
                        Cards.Add(new Card(10, new Bitmap(Image.FromFile(file.FullName)), 140, 140));
                        break;
                    case 'K':
                        Cards.Add(new Card(10, new Bitmap(Image.FromFile(file.FullName)), 140, 140));
                        break;                                      
                    case 'A':
                        Cards.Add(new Card(1, new Bitmap(Image.FromFile(file.FullName)), 140, 140));
                        break;
                }
            }
            ReserveCards = Cards;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (Card card in Reshuffle)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if ((card.X + Back.Width - 100 > Cursor.Position.X) && (card.X + 50 < Cursor.Position.X))
                    {
                        if ((card.Y + Back.Height - 200 > Cursor.Position.Y) && (card.Y + 50 < Cursor.Position.Y))
                        {
                            if (Cursor.Position.Y > ClientRectangle.Height / 2 + 210)
                            {
                                if (card.Number == 1)
                                {
                                    PlayerScore += PlayerScore + 11 > 21 ? 1 : 11;
                                }
                                else
                                {
                                    PlayerScore += card.Number;
                                }
                                button1.Text = $"{PlayerScore}";
                                card.Number = 0;
                            }
                            card.X = e.X;
                            card.Y = e.Y;
                            Refresh();
                            break;
                        }
                    }
                }
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Random random = new Random();
            while(Reshuffle.Count != 52)
            {
                int temp = random.Next(0, Cards.Count);
                Reshuffle.Add(Cards[temp]);
                Cards.RemoveAt(temp);
            }
            Cards = ReserveCards;
            foreach(Card card in Reshuffle)
            {
                graphics.DrawImage(card.IMG, new Rectangle(card.X - 60, card.Y - 60, 100, 140));
            }
            graphics.DrawImage(Back, new Rectangle(80, 80, 100, 140));
            graphics.DrawImage(Back, new Rectangle(81, 81, 100, 140));
            graphics.DrawImage(Back, new Rectangle(82, 82, 100, 140));
            graphics.DrawImage(Back, new Rectangle(83, 83, 100, 140));
            graphics.DrawImage(Back, new Rectangle(84, 84, 100, 140));
            graphics.DrawImage(Back, new Rectangle(85, 85, 100, 140));
            graphics.DrawImage(Back, new Rectangle(86, 86, 100, 140));
            graphics.DrawImage(Back, new Rectangle(87, 87, 100, 140));                    
        }            
        private void Timer_Tick(object sender, EventArgs e)
        {
            if(PlayerScore > OldPlaerScore)
            {
                Opponent();
                PositionButton += 10;
                OldPlaerScore = PlayerScore;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Pass = true;
            while (Game_over == false)
            {
                Opponent();
            }
        }
        public void Opponent()
        {
            Random random = new Random();
            Random = random.Next(0, Reshuffle.Count);
            if (OpponentScore == 20)
            {
                if (Pass == true)
                {
                    Game_over = true;
                    The_End();
                }
            }
            else if (PlayerScore > OpponentScore)
            {
                Reshuffle[Random].X = PositionButton;
                Reshuffle[Random].Y = 70;
                if (Reshuffle[Random].Number == 1)
                {
                    OpponentScore += OpponentScore + 11 > 21 ? 1 : 11;
                }
                else
                {
                    OpponentScore += Reshuffle[Random].Number;
                }
                button4.Text = Convert.ToString(OpponentScore);
                Refresh();
            }
            else if (OpponentScore > 18)
            {
                switch (random.Next(0, 2))
                {
                    case 0:
                        if (Pass == true)
                        {
                            Game_over = true;
                            The_End();
                        }
                        break;
                    case 1:
                        if (Reshuffle[Random].Number != 0)
                        {
                            Reshuffle[Random].X = PositionButton;
                            Reshuffle[Random].Y = 70;
                            if (Reshuffle[Random].Number == 1)
                            {
                                OpponentScore += OpponentScore + 11 > 21 ? 1 : 11;
                            }
                            else
                            {
                                OpponentScore += Reshuffle[Random].Number;
                            }
                            button4.Text = Convert.ToString(OpponentScore);
                            Refresh();
                        }
                        else
                        {
                            Opponent();
                        }
                        break;
                }
            }
            else if (OpponentScore == 18 || OpponentScore == 17 || OpponentScore == 16 || OpponentScore == 15)
            {
                switch (random.Next(0, 3))
                {
                    case 0:
                        if (Pass == true)
                        {
                            Game_over = true;
                            The_End();
                        }
                        break;
                    default:
                        if (Reshuffle[Random].Number != 0)
                        {
                            Reshuffle[Random].X = PositionButton;
                            Reshuffle[Random].Y = 70;
                            if (Reshuffle[Random].Number == 1)
                            {
                                OpponentScore += OpponentScore + 11 > 21 ? 1 : 11;
                            }
                            else
                            {
                                OpponentScore += Reshuffle[Random].Number;
                            }
                            button4.Text = Convert.ToString(OpponentScore);
                            Refresh();
                        }
                        else
                        {
                            Opponent();
                        }
                        break;
                }
            }
            else if (Reshuffle[Random].Number != 0)
            {
                Reshuffle[Random].X = PositionButton;
                Reshuffle[Random].Y = 70;
                if (Reshuffle[Random].Number == 1)
                {
                    OpponentScore += OpponentScore + 11 > 21 ? 1 : 11;
                }
                else
                {
                    OpponentScore += Reshuffle[Random].Number;
                }
                button4.Text = Convert.ToString(OpponentScore);
                Refresh();
            }
            else if (Reshuffle[Random].Number == 0)
            {
                Opponent();
            }
        }               
        private void NewTimer_Tick(object sender, EventArgs e)
        {
            if(OpponentScore > 21)
            {
                Game_over = true;
                PlayerScore = 0;
                OpponentScore = 0;
                MessageBox.Show("Вы выиграли!");
                Application.Restart();                
            }
            else if(PlayerScore > 21)
            {
                Game_over = true;
                PlayerScore = 0;
                OpponentScore = 0;
                MessageBox.Show("Вы проиграли!");
                Application.Restart();
            }
            else if(PlayerScore == 21)
            {
                Game_over = true;
                PlayerScore = 0;
                OpponentScore = 0;
                MessageBox.Show("Вы выиграли!");
                Application.Restart();
            }
            else if (OpponentScore == 21)
            {
                Game_over = true;
                PlayerScore = 0;
                OpponentScore = 0;
                MessageBox.Show("Вы проиграли!");
                Application.Restart();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void The_End()
        {
            if (OpponentScore > 21)
            {
                PlayerScore = 0;
                OpponentScore = 0;
                MessageBox.Show("Вы выиграли!");
                Application.Restart();
            }
            else if (OpponentScore == PlayerScore)
            {
                PlayerScore = 0;
                OpponentScore = 0;
                MessageBox.Show("Ничья!");
                Application.Restart();
            }
            else
            {
                PlayerScore = 0;
                OpponentScore = 0;
                MessageBox.Show("Вы проиграли!");
                Application.Restart();
            }
        }   
    }
}
