using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHardestGame
{
    public enum Direction
    {
        UP,
        DOWN,
        LEFT,
        RIGHT,
        UP_LEFT,
        UP_RIGHT,
        DOWN_LEFT,
        DOWN_RIGHT
    }
    public class Square
    {
        public Point Position { get; set; }
        public int X { get { return Position.X; } }
        public int Y { get { return Position.Y; } }

        private static int Speed = 15;


        public Square()
        {
            Position = new Point(162, 162);
        }

        public void Draw(Graphics g)
        {
            SolidBrush b = new SolidBrush(Color.Orange);
            g.FillRectangle(b, X, Y, 15, 15);
            b.Dispose();
        }
        public void Move(Direction dir)
        {
            if(dir == Direction.RIGHT)
            {
                Position = new Point(X + 3, Y);
            }
            if(dir  == Direction.LEFT)
            {
                Position = new Point(X - 3, Y);
            }
            if(dir == Direction.UP)
            {
                Position = new Point(X, Y - 3);
            }
            if(dir == Direction.DOWN)
            {
                Position = new Point(X, Y + 3);
            }
           
        }

    }
}
