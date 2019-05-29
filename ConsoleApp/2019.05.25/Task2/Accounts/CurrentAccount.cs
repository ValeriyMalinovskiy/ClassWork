using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019._05._25
{
    class CurrentAccount : Account, ITransactionable
    {
        public CurrentAccount(string customerName, decimal initialMoney) : base(customerName, initialMoney)
        {

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
    }
}
