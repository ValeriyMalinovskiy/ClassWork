namespace _2019._07._20
{
    internal class Fridge
    {
        private DoorState MainDoorState { get; set; }

        private DoorState FreezerDoorState { get; set; }

        private FridgeState FridgeState { get; set; }

        public Fridge()
        {
            this.FridgeState = FridgeState.On;
            this.MainDoorState = DoorState.Closed;
            this.FreezerDoorState = DoorState.Closed;
        }

        public delegate void FridgeDelegate(FridgeEventArgs args);

        public event FridgeDelegate FridgeInteraction;

        private void OnFridgeInteraction()
        {
            this.FridgeInteraction?.Invoke(new FridgeEventArgs(this.MainDoorState, this.FreezerDoorState, this.FridgeState));
        }

        public virtual void ChangeMainDoorState()
        {
            if (this.MainDoorState == DoorState.Closed)
            {
                this.MainDoorState = DoorState.Open;
            }
            else
            {
                this.MainDoorState = DoorState.Closed;
            }
            this.OnFridgeInteraction();
        }

        public virtual void ChangeFreezerDoorState()
        {
            if (this.FreezerDoorState == DoorState.Closed)
            {
                this.FreezerDoorState = DoorState.Open;
            }
            else
            {
                this.FreezerDoorState = DoorState.Closed;
            }
            this.OnFridgeInteraction();
        }

        public virtual void ChangeFridgeState()
        {
            if (this.FridgeState == FridgeState.Off)
            {
                this.FridgeState = FridgeState.On;
            }
            else
            {
                this.FridgeState = FridgeState.Off;
            }
            this.OnFridgeInteraction();
        }

        public string GetState()
        {
            return $"The fridge is {this.FridgeState}, the main door is {this.MainDoorState}, the freezer door is {this.FreezerDoorState}";
        }
    }
}
