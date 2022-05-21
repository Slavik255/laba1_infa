using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_task2
{
    class Card
    {
        public int Number { get; set; }
        public Bitmap BackImg { get { return new Bitmap(@"E:\Program po 3d modelirovanii-o\Rabotu visual studio\laba3_infa\Laba3_infa(2)\Cards\Back.png"); } }
        public Bitmap IMG { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Card(int number, Bitmap img, int x, int y)
        {
            this.Number = number;
            this.IMG = img;
            this.X = x;
            this.Y = y;
        }
    }
}
