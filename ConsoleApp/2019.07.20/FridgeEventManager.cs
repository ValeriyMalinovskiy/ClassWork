using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019._07._20
{
    class FridgeEventManager
    {
        Fridge fridge = new Fridge();

        public void Manage()
        {
            fridge.FridgeEvent += OnFridgeStateChangedInvoke;
            Console.WriteLine("Press 1 to switch ON/OFF");
            switch (Console.ReadLine())
            {
                case "1":
                    fridge.ChangeFridgeState();
                    break;
            }
        }

        private void OnFridgeStateChangedInvoke((StateEnum, MainDoorEnum, FreezerEnum) fridge1, EventArgs e)
        {
            fridge.ChangeFridgeState();
        }

        private void OnDoorsStateChangedInvoke(EventArgs e)
        {
            fridge.ChangeMainDoorState();
        }
    }
}
