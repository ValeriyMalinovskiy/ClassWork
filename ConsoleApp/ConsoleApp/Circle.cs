using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ConsoleApp
{
    public class Circle : Figure
    {
        private int radius;

        public int Radius
        {
            get
            {
                return this.radius;
            }
        }

        public Circle(Point centerCoordinates, int radius) : base(centerCoordinates)
        {
            this.radius = radius;
        }

        public void Draw()
        {
            Console.WriteLine($"The {this.GetType().Name} with center coordinates {CenterCoordinates.X} and {CenterCoordinates.Y} is being painted");
        }
    }
}
