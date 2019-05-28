using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019._05._25
{
    abstract class SmartDevice
    {
        public abstract string BrandName { get; protected set; }

        public abstract bool IsDeviceOn { get; set; }

        public SmartDevice(string name)
        {
            this.BrandName = name;
            this.IsDeviceOn = false;
        }

        public void TurnOn()
        {
            if (!this.IsDeviceOn)
            {
                System.Console.WriteLine($"{this.BrandName} turned on");
                this.IsDeviceOn = true;
            }
        }

        public void TurnOff()
        {
            if (this.IsDeviceOn)
            {
                System.Console.WriteLine($"{this.BrandName} turned off");
                this.IsDeviceOn = false;
            }
        }

        public override string ToString()
        {
            return (this.IsDeviceOn) ? $"{this.BrandName} is on" : $"{this.BrandName} is off";
        }
    }
}
