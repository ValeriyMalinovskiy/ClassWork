using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019._05._25
{
    internal class SmartDevice
    {
        public string BrandName { get; protected set; }

        public DeviceState State { get; set; }

        public SmartDevice(string name)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(name))
                {
                    this.BrandName = name;
                    this.State = DeviceState.Off;
                }
            }
            catch (System.ArgumentNullException)
            {

                throw;
            }
        }

        public void TurnOn()
        {
            if (this.State == DeviceState.Off)
            {
                System.Console.WriteLine($"{this.BrandName} turned on");
                this.State = DeviceState.On;
            }
        }

        public void TurnOff()
        {
            if (this.State == DeviceState.On)
            {
                System.Console.WriteLine($"{this.BrandName} turned off");
                this.State = DeviceState.Off;
            }
        }

        public override string ToString()
        {
            return (this.State == DeviceState.On) ? $"{this.BrandName} is on" : $"{this.BrandName} is off";
        }
    }
}
