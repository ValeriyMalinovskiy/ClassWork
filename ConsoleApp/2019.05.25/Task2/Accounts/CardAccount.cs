using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019._05._25
{
    class CardAccount : Account, ITransactionable, IInterestCalculatable
    {
        public decimal InterestRate { get; private set; }

        private readonly decimal daysInYear = DateTime.IsLeapYear(DateTime.Today.Year) ? 366 : 365;

        public CardAccount(string customerName, decimal initialMoney, decimal interestRate) : base(customerName, initialMoney)
        {
            this.InterestRate = interestRate;
        }


        public void AddToAccount(decimal sum)
        {
            if (sum > 0)
            {
                this.Balance += sum;
            }
            else
            {
                Console.WriteLine("Operation failed. Sum must be greater than zero. Press any key.");
                Console.ReadKey();
            }
        }

        public void SubtractFromAccount(decimal sum)
        {
            if (sum > 0)
            {
                this.Balance -= sum;
            }
            else
            {
                Console.WriteLine("Operation failed. Insufficient funds. Press any key.");
                Console.ReadKey();
            }
        }

        public decimal InterestMoneyCalculator(int daysPassed)
        {
            for (int i = 0; i < daysPassed; i++)
            {
                this.Balance += (decimal)((this.Balance * this.InterestRate / 100m) / this.daysInYear) * daysPassed;
            }
            return this.Balance;
        }
    }
}
