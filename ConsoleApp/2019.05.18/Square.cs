using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ConsoleApp
{
    internal class Square : Figure
    {
        private int side;

        public int Side
        {
            get
            {
                return this.side;
            }
        }

        public Square(int side, Point centerCoordinates) : base(centerCoordinates)
        {
            this.side = side;
        }

        public void Draw()
        {
            Console.WriteLine($"The {this.GetType().Name} with center coordinates {CenterCoordinates.X} and {CenterCoordinates.Y} is being painted");
        }
    }
}
