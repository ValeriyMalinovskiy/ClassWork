using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Car: Vehicle
    {
        public int DoorsCount { get; set; }
        public EngineType Engine { get; set; }
        public GearboxType Gearbox { get; set; }

        public Car(int doorsCount, EngineType engine, GearboxType gearbox,
            int wheelCount, ConsoleColor color, int maxspeed, int passengersCount):
            base(wheelCount,passengersCount, color, maxspeed)
        {
            DoorsCount = doorsCount;
            Engine = engine;
            Gearbox = gearbox;
        }
    }
    enum EngineType
    {
        Petrol,
        Diesel,
        Electric,
        Hybrid
    }

    enum GearboxType
    {
        Mechanic,
        Automatic,
    }
}
