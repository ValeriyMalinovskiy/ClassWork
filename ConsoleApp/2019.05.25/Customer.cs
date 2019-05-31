using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019._05._25
{
    class Customer
    {
        public string Name { get; set; }

        public List<Account> accounts = new List<Account>();

        public Customer(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                this.Name = name;
            }
        }

        public void CreateNewAccount()
        {
            decimal interestRate = 0;
            decimal initialMoney = 0;
            int depositPeriod = 0;

            Console.WriteLine("Select account type you want to create.\n1 - Card account\n2 - Current account\n3 - Deposit account");
            switch (Console.ReadLine())
            {
                case "1":
                    {
                        initialMoney = InitialMoneySetter();
                        interestRate = InterestRateSetter();
                        accounts.Add(new CardAccount(this.Name, initialMoney, interestRate));
                    }
                    break;
                case "2":
                    {
                        initialMoney = InitialMoneySetter();
                        accounts.Add(new CurrentAccount(this.Name, initialMoney));
                    }
                    break;
                case "3":
                    {
                        initialMoney = InitialMoneySetter();
                        interestRate = InterestRateSetter();
                        depositPeriod = DepositPeriodSetter();
                        accounts.Add(new DepositAccount(this.Name, initialMoney, depositPeriod, interestRate));
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Incorrect input.");
                    }
                    break;
            }
        }

        public void ShowAllAccounts()
        {
            int accountCounter = 0;

            try
            {
                foreach (var item in this.accounts)
                {
                    accountCounter++;
                    Console.WriteLine($"{accountCounter} {item.GetType().Name} {item.Balance}");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No accounts created yet"); ;
            }
        }

        public void CloseAccount()
        {
            this.ShowAllAccounts();
            Console.WriteLine("Enter the account number to close");
            int accountIndex = int.Parse(Console.ReadLine()) - 1;
            this.accounts[accountIndex].CloseAccount();
            this.accounts.RemoveAt(accountIndex);
        }

        private decimal InitialMoneySetter()
        {
            Console.WriteLine("Enter the sum you want to add");
            if (decimal.TryParse(Console.ReadLine(), out decimal initialMoney))
            {
                return initialMoney;
            }
            else return 0;
        }

        private decimal InterestRateSetter()
        {
            Console.WriteLine("Enter the interest rate");
            if (decimal.TryParse(Console.ReadLine(), out decimal interestRate))
            {
                return interestRate;
            }
            else return 0;
        }

        private int DepositPeriodSetter()
        {
            Console.WriteLine("Enter the deposit period (month)");
            if (int.TryParse(Console.ReadLine(), out int period))
            {
                return period * 30;
            }
            else return 0;
        }

        public void FromAccountToAccount()
        {
            int indexOfAccountFrom = 0;
            int indexOfAccountTo = 0;
            decimal sum = 0;

            this.ShowAllAccounts();
            Console.WriteLine("Enter the account number to subtract money from");
            indexOfAccountFrom = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Enter the account number to add money to");
            indexOfAccountTo = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Enter the sum to transfer");
            sum = decimal.Parse(Console.ReadLine());

            accounts[indexOfAccountFrom].SubtractFromAccount(sum);
            accounts[indexOfAccountTo].AddToAccount(sum);
            this.ShowAllAccounts();
        }
    }
}
