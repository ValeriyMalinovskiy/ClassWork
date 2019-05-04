using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Bicycle:Vehicle
    {
        public BicycleType BicycleType { get; set; }
        public BrakeType BrakeType { get; set; }

        public Bicycle(int wheelCount, int passengerCount, ConsoleColor color, int maxSpeed,BicycleType bicycleType, BrakeType brakeType):
            base(wheelCount, passengerCount, color, maxSpeed)
        {
            BicycleType = bicycleType;
            BrakeType = brakeType;
        }
    }

    enum BicycleType
    {
        MTB,
        Road,
        Gravel,
        BMX,
        Cruiser
    }

    enum BrakeType
    {
        Vbrake,
        HydraulicDisk,
        MechanicalDisk
    }
}
