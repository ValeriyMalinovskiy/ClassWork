using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2019May11
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure[] figures =
            {
                new Triangle(new Point(3,4), 3, 30, 45),
                new Square(3, new Point(5,2)),
                new Circle( new Point(6,7), 5)
            };

            foreach (var item in figures)
            {
                item.Draw();
            }
        }
    }
}
