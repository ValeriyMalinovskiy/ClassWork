namespace _2019._05._25
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();

        }

        static void Task1()
        {
            var cam1 = new ActionCamera("GoPro 6");
            var cam2 = new ActionCamera("Sony X3000R");
            var speaker1 = new SmartSpeaker("TDK Outloud");
            var speaker2 = new SmartSpeaker("JBL speaker");

            var devices = new SmartDevice[]
            {cam1, cam2, speaker1, speaker2};

            foreach (var item in devices)
            {
                //item.TurnOff();
                item.TurnOn();
            }
            System.Console.WriteLine();

            foreach (var item in devices)
            {
                System.Console.WriteLine(((SmartDevice)item).ToString());
            }
        }
    }
}
