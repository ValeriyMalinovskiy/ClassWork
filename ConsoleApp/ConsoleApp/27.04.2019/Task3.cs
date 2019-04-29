using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Task3
    {
        private static void Print(string inputString, int color)
        {
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(inputString);
            Console.ResetColor();
        }

        private enum Color
        {
            DarkBlue = 1,
            DarkCyan = 3,
            DarkGreen = 2,
            DarkMagenta = 5,
            DarkRed = 4,
            DarkYellow = 6,
            Gray = 7,
            DarkGray = 8,
            Blue = 9,
            Green = 10,
            Cyan = 11,
            Red = 12,
            Magenta = 13,
            White = 15,
            Yellow = 14,
        }

        public static void UserInterface()
        {
            Print("Choose the color:", 8);
            for (int i = 1; i < 15; i++)
            {
                Print($"{i}", i);
            }
            int color = int.Parse(Console.ReadLine());
            Print("Type the string", 8);
            string stringToPrint = Console.ReadLine();
            Console.Clear();
            Print(stringToPrint, color);
        }
    }
}
