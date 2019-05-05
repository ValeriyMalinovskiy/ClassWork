using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Vehicle
    {
        private int wheelCount = 1;
        public int WheelCount
        {
            get
            {
                return wheelCount;
            }

            set
            {
                if (value > 0)
                {
                    wheelCount = value;
                }
            }
        }

        public ConsoleColor Color { get; set; }

        private int maxSpeed = 1;
        public int MaxSpeed
        {
            get
            {
                return maxSpeed;
            }

            set
            {
                if (value > 0)
                {
                    maxSpeed = value;
                }
                else
                {
                    throw new ArgumentException("Max speed must be greater that zero");
                }
            }
        }

        public int PassengerCount { get; set; }

        public void Move(int meters)
        {
            Console.ForegroundColor = Color;
            Console.WriteLine($"{GetType().Name} has moved {meters} meters");
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }

        public Vehicle(int wheelCount, int passengerCount, ConsoleColor color, int maxSpeed)
        {
            WheelCount = wheelCount;
            PassengerCount = passengerCount;
            Color = color;
            MaxSpeed = maxSpeed;
        }
    }
}
