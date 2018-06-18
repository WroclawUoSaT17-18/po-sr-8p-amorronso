using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake_vol2
{
    class Snake
    {
        public Rectangle[] Body; //array, 'cuz theres are many rectangles in snake body

        //x,y place to start the snake, w,h size
        private int x = 0, y = 0, width = 10, height = 10;

        public Snake()
        {
            Body = new Rectangle[1];
            Body[0] = new Rectangle(x, y, width, height);
        }

        public void Draw()
        {
            //
            for (int i = Body.Length - 1; i > 0; i--)
                Body[i] = Body[i - 1];
        }

        public void Draw(Graphics graphics)
        {
            graphics.FillRectangles(Brushes.Green, Body);
        }

        public void Move(int direction) // 0 = Right, 1 = Down, 2 = Left, 3 = Up
        {
            Draw();
            switch (direction)
            {
                case 0:
                    Body[0].X += 10;
                    break;
                case 1:
                    Body[0].Y += 10;
                    break;
                case 2:
                    Body[0].X -= 10;
                    break;
                case 3:
                    Body[0].Y -= 10;
                    break;

            }
        }

        public void Grow()
        {
            //take the lenght of snake and add one to the end... LIST is easier than array
            List<Rectangle> temp = Body.ToList();
            temp.Add(new Rectangle(Body[Body.Length - 1].X, Body[Body.Length - 1].Y, width, height));
            Body = temp.ToArray();

        }

    }
}

