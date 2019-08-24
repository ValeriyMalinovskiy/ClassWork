using System;

namespace _2019._07._20
{
    internal class FridgeOwner
    {
        private readonly Fridge fridge;

        public FridgeOwner(Fridge fridge)
        {
            this.fridge = fridge;
            this.fridge.FridgeInteraction += this.ShowFridgeState;
        }

        public void ShowFridgeState(FridgeEventArgs e)
        {
            Console.Write($"The fridge is {e.FridgeState}, the main door is {e.MainDoorState}, the freezer door is {e.FreezerDoorState}");
        }

        public void ProcessUserActions()
        {
            while (true)
            {
                Console.WriteLine("1 - Open/close main door\n2 - Open/close freezer\n3 - switch the fridge on/off\n4 - Show current state"); Console.Write(Environment.NewLine);
                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            this.fridge.ChangeMainDoorState();
                        }
                        break;
                    case "2":
                        {
                            this.fridge.ChangeFreezerDoorState();
                        }
                        break;
                    case "3":
                        {
                            this.fridge.ChangeFridgeState();
                        }
                        break;
                    case "4":
                        {
                            Console.WriteLine(this.fridge.GetState());
                        }
                        break;
                }
                Console.Write(Environment.NewLine);
            }
        }
    }
}
