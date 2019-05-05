using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Moto: Vehicle
    {
        public MotoType MotoType { get; set; }
        public Moto(int wheelCount, int passengerCount, ConsoleColor color, int maxSpeed, MotoType motoType):
            base(wheelCount,passengerCount,color,maxSpeed)
        {
            MotoType = motoType;
        }

    }

    enum MotoType
    {
        Adventure,
        Chopper,
        Cruiser,
        Enduro
    }
}
