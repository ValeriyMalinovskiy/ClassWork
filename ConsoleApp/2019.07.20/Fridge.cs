using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019._07._20
{
    class Fridge
    {

        public StateEnum FridgeState { get; private set; }

        public MainDoorEnum MainDoorState { get; private set; }

        public FreezerEnum FreezerState { get; private set; }

        public Fridge()
        {
            this.FridgeState = StateEnum.On;
            this.MainDoorState = MainDoorEnum.MainDoorClosed;
            this.FreezerState = FreezerEnum.FreezerClosed;
        }

        public delegate void FridgeStateChangedDelegate((StateEnum, MainDoorEnum, FreezerEnum) state, EventArgs eventArgs);
        public event FridgeStateChangedDelegate FridgeEvent;
        private void OnFridgeInvoke((StateEnum, MainDoorEnum, FreezerEnum) state, EventArgs e)
        {
            this.FridgeEvent?.Invoke(state, e);
        }

        public virtual void ChangeMainDoorState()
        {
            if (this.MainDoorState == MainDoorEnum.MainDoorClosed)
            {
                this.MainDoorState = MainDoorEnum.MainDoorOpened;
            }
            else
            {
                this.MainDoorState = MainDoorEnum.MainDoorClosed;
            }
            this.OnFridgeInvoke((this.FridgeState, this.MainDoorState, this.FreezerState), new EventArgs());
        }

        public virtual void ChangeFreezerState()
        {
            if (this.FreezerState == FreezerEnum.FreezerClosed)
            {
                this.FreezerState = FreezerEnum.FreezerOpened;
            }
            else
            {
                this.FreezerState = FreezerEnum.FreezerClosed;
            }
            this.OnFridgeInvoke((this.FridgeState, this.MainDoorState, this.FreezerState), new EventArgs());
        }

        public virtual void ChangeFridgeState()
        {
            if (this.FridgeState == StateEnum.Off)
            {
                this.FridgeState = StateEnum.On;
            }
            else
            {
                this.FridgeState = StateEnum.Off;
            }
            this.OnFridgeInvoke((this.FridgeState, this.MainDoorState, this.FreezerState), new EventArgs());
        }

        public string ShowState()
        {
            return this.ToString();
        }

        public override string ToString()
        {
            return $"The fridge is {this.FridgeState}, {this.MainDoorState}, {this.FreezerState}";
        }
    }
}
