using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019May04
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles =
                {
                new Bicycle(2, 0, ConsoleColor.Cyan, 60, BicycleType.MTB, BrakeType.MechanicalDisk),
                new Bicycle(2, 0, ConsoleColor.Yellow, 70, BicycleType.Road, BrakeType.Vbrake),
                new Moto(2, 1, ConsoleColor.White, 230, MotoType.Enduro),
                new Moto(2, 1, ConsoleColor.Red, 190, MotoType.Adventure),
                new Car(4, EngineType.Petrol, GearboxType.Mechanic, 4, ConsoleColor.Magenta, 200, 3),
                new Car(2, EngineType.Electric, GearboxType.Automatic, 4, ConsoleColor.Green, 250, 1)
                };

            //foreach (var veh in vehicles)
            //{
            //    veh.Move(1000);
            //}

            ShowVehicleAttributes(vehicles);

            Console.ReadKey();
        }

        static void ShowVehicleAttributes(Vehicle[] vehicles)
        {
            string str = String.Format("{0,-10} {1,-15} {2,-7} {3,-10} {4,-10} {5,-10} {6,-10} {7,-10} {8,-12} {9,-10} \n \n",
                "WheelCount", "PassengersCount", "Color", "Maxspeed", "DoorsCount", "Engine", "Gearbox", "MotoType", "BicycleType", "BrakeType");
            Type t;
            for (int i = 0; i < vehicles.Length; i++)
            {
                t = vehicles[i].GetType();
                if (t.Equals(typeof(Car)))
                {
                    str += String.Format("{0,-10} {1,-15} {2,-7} {3,-10} {4,-10} {5,-10} {6,-10} {7,-10} {8,-12} {9,-10} \n",
                vehicles[i].WheelCount, vehicles[i].PassengerCount, vehicles[i].Color, vehicles[i].MaxSpeed, ((Car)vehicles[i]).DoorsCount, ((Car)vehicles[i]).Engine, ((Car)vehicles[i]).Gearbox, "", "", "");
                }
                else if (t.Equals(typeof(Moto)))
                {
                    str += String.Format("{0,-10} {1,-15} {2,-7} {3,-10} {4,-10} {5,-10} {6,-10} {7,-10} {8,-12} {9,-10} \n",
                    vehicles[i].WheelCount, vehicles[i].PassengerCount, vehicles[i].Color, vehicles[i].MaxSpeed, "", "", "", ((Moto)vehicles[i]).MotoType, "", "");
                }
                else
                {
                    str += String.Format("{0,-10} {1,-15} {2,-7} {3,-10} {4,-10} {5,-10} {6,-10} {7,-10} {8,-12} {9,-10} \n",
                    vehicles[i].WheelCount, vehicles[i].PassengerCount, vehicles[i].Color, vehicles[i].MaxSpeed, "", "", "", "", ((Bicycle)vehicles[i]).BicycleType, ((Bicycle)vehicles[i]).BrakeType);
                }
            }

            Console.WriteLine(str);
        }
    }
}

