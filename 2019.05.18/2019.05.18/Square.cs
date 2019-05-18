using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2019May11
{
    internal class Square : Figure
    {
        private int side;

        public Square(int side, Point centerCoordinates) : base(centerCoordinates)
        {
            this.side = side;
        }

        public override void Draw()
        {
            Console.WriteLine($"The {this.GetType().Name} with side {this.side} center coordinates {CenterCoordinates.X} and {CenterCoordinates.Y} is being painted");
        }
    }
}
