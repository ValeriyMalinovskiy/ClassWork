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

        public int Side
        {
            get
            {
                return this.side;
            }
        }

        public int Angle2
        {
            get
            {
                return this.angle2;
            }
        }

        public int Angle1
        {
            get
            {
                return this.angle1;
            }
        }

        public Triangle(Point centerCoordinates, int side, int angle1, int angle2) : base (centerCoordinates)
        {
            this.side = side;
            this.angle1 = angle1;
            this.angle2 = angle2;
        }

        public void Draw()
        {
            Console.WriteLine($"The {this.GetType().Name} with center coordinates {CenterCoordinates.X} and {CenterCoordinates.Y} is being painted");
        }
    }
} 
