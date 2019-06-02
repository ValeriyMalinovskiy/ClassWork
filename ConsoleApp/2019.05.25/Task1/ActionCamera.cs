using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019._05._25
{
    internal class ActionCamera : SmartDevice, IVoiceSwitchable
    {
        public ActionCamera(string name) : base(name)
        {
            this.BrandName = name;
            this.State = DeviceState.On;
        }
    }
}
