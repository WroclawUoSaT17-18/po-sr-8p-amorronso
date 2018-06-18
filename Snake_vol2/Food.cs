using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake_vol2
{
    class Food
    {
        //every piece of food is a 10x10 of piece block
        public Rectangle Piece;
        private int x, y, width = 10, height = 10;

        //constructor, one parameter
        public Food(Random rand)
        {
            Generate(rand);
            Piece = new Rectangle(x, y, width, height);
        }
        public void Draw(Graphics graphics)//
        {
            Piece.X = x;
            Piece.Y = y;
            graphics.FillRectangle(Brushes.CadetBlue, Piece);
        }
        //generates random x, y for piece of food
        public void Generate(Random rand)
        {
            x = rand.Next(0, 30) * 10; //depend on our window size, here is 0-29
            y = rand.Next(0, 20) * 10; 
        }
    }
}
