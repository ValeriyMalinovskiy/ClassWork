using System;

namespace _2019._07._20
{
    public class FridgeEventArgs : EventArgs
    {
        public DoorState MainDoorState { get; private set; }

        public DoorState FreezerDoorState { get; private set; }

        public FridgeState FridgeState { get; private set; }

        public FridgeEventArgs(DoorState mainDoorState, DoorState freezerDoorState, FridgeState fridgeState)
        {
            this.MainDoorState = mainDoorState;
            this.FreezerDoorState = freezerDoorState;
            this.FridgeState = fridgeState;
        }
    }
}
