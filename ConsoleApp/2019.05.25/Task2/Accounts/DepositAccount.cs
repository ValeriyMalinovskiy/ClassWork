using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019._05._25
{
    class DepositAccount : Account, IInterestCalculatable, ITransactionable
    {
        public decimal InterestRate { get; private set; }

        public int DepositPeriod { get; private set; }

        private readonly decimal daysInYear = DateTime.IsLeapYear(DateTime.Today.Year) ? 366 : 365;


        public DepositAccount(string customerName, decimal initialMoney, int depositPeriod, decimal interestRate) : base(customerName, initialMoney)
        {
            if (depositPeriod>=1)
            {
                this.DepositPeriod = depositPeriod;
            }
            if (interestRate>0)
            {
                this.InterestRate = interestRate;
            }
        }

        public decimal InterestMoneyCalculator(int daysPassed)
        {
            if ((daysPassed>=0)&&(daysPassed<=this.DepositPeriod))
            {
                for (int i = 0; i < daysPassed; i++)
                {
                    this.Balance += (decimal)((this.Balance * this.InterestRate / 100m) / this.daysInYear) * daysPassed;
                }
                return this.Balance;
            }
            else
            {
                Console.WriteLine("Incorrect period. Press any key.");
                Console.ReadKey();
            }
            return 0;
        }

        public void SubtractFromAccount(decimal sum)
        {
            Console.WriteLine("You can't get the money until the deposit period is over. Press any key.");
            Console.ReadKey();
        }

        public void AddToAccount(decimal sum)
        {
            Console.WriteLine("You can't put the money until the deposit period is over. Press any key.");
            Console.ReadKey();
        }
    }
}
