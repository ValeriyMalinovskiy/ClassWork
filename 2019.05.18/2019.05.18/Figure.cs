using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2019May11
{
    public class Figure
    {
        private Point centerCoordinates;

        public Point CenterCoordinates
        {
            get
            {
                return this.centerCoordinates;
            }
        }

        public Figure(Point centerCoordinates)
        {
            this.centerCoordinates.X = centerCoordinates.X;
            this.centerCoordinates.Y = centerCoordinates.Y;
        }

        public virtual void Draw()
        {
            Console.WriteLine($"The {this.GetType().Name} with center coordinates {CenterCoordinates.X} and {CenterCoordinates.Y} is being painted");
        }
    }
}
