using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019._05._25
{
    abstract class Account : ITransactionable
    {
        protected decimal balance;

        protected string customerName;

        public Account(string customerName, decimal initialMoney)
        {
            this.Balance = initialMoney;
            this.customerName = customerName;
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            protected set
            {
                if (value >= 0)
                {
                    this.balance = value;
                }
            }
        }


        public string CustomerName
        {
            get
            {
                return this.customerName;
            }
        }


        internal decimal CloseAccount()
        {
            {
                Console.WriteLine($"You have received {this.balance} and closed {this.GetType().Name} account");
                Console.WriteLine($"You have closed {this.GetType().Name} account");
                return this.balance;
            }
        }

        public virtual void AddToAccount(decimal sum)
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

        public virtual void SubtractFromAccount(decimal sum)
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
