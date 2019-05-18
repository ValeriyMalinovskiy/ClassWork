using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2019May11
{
    internal class Triangle : Figure
    {
        private int side;

        private int angle1;

        private int angle2;

        public Triangle(Point centerCoordinates, int side, int angle1, int angle2) : base (centerCoordinates)
        {
            this.side = side;
            this.angle1 = angle1;
            this.angle2 = angle2;
        }

        public override void Draw()
        {
            Console.WriteLine($"The {this.GetType().Name} with angles {this.angle1}, {this.angle2} center coordinates {CenterCoordinates.X} and {CenterCoordinates.Y} is being painted");
        }
    }
} 
