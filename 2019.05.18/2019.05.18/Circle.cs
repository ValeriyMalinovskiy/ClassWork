using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2019May11
{
    public class Circle : Figure
    {
        private int radius;

        public Circle(Point centerCoordinates, int radius) : base(centerCoordinates)
        {
            this.radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"The {this.GetType().Name} with radius {this.radius} center coordinates {CenterCoordinates.X} and {CenterCoordinates.Y} is being painted");
        }
    }
}
