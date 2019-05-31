namespace _2019._05._25
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();

            Task2();

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

        static void Task2()
        {
            Bank bank = new Bank();
            bank.AddClientToDataBase(new Customer("Vasya"));
            do
            {
                System.Console.WriteLine("Select an operation:" +
                    "\n1 - Close Account" +
                    "\n2 - Create New Account" +
                    "\n3 - From Account To Account" +
                    "\n4 - Close Account" +
                    "\n5 - Show All Accounts" +
                    "\n6 - Add To Account" +
                    "\n7 - Balance" +
                    "\n8 - Subtract From Account");

                switch (System.Console.ReadLine())
                {
                    case "1":
                        {
                            bank.customers[0].CloseAccount();
                        }
                        break;
                    case "2":
                        {
                            bank.customers[0].CreateNewAccount();
                        }
                        break;
                    case "3":
                        {
                            bank.customers[0].FromAccountToAccount();
                        }
                        break;
                    case "4":
                        {
                            bank.customers[0].CloseAccount();
                        }
                        break;
                    case "5":
                        {
                            bank.customers[0].ShowAllAccounts();
                        }
                        break;
                    case "6":
                        {
                            bank.customers[0].ShowAllAccounts();
                            System.Console.WriteLine("Select an account, press Enter. Type the sum, press Enter.");
                            bank.customers[0].accounts[int.Parse(System.Console.ReadLine()) - 1].AddToAccount(decimal.Parse(System.Console.ReadLine()));
                        }
                        break;
                    case "7":
                        {
                            bank.customers[0].ShowAllAccounts();
                            System.Console.WriteLine("Select an account, press Enter.");
                            System.Console.WriteLine(bank.customers[0].accounts[int.Parse(System.Console.ReadLine()) - 1].Balance);
                        }
                        break;
                    case "8":
                        {
                            bank.customers[0].ShowAllAccounts();
                            System.Console.WriteLine("Select an account, press Enter. Type the sum, press Enter.");
                            bank.customers[0].accounts[int.Parse(System.Console.ReadLine()) - 1].SubtractFromAccount(decimal.Parse(System.Console.ReadLine()));
                        }
                        break;
                }
                System.Console.WriteLine();
            } while (true);
        }
    }
}
