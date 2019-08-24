namespace _2019._07._20
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            FridgeOwner owner = new FridgeOwner(new Fridge());
            owner.ProcessUserActions();
        }
    }
}
