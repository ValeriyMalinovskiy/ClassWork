using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019._05._25
{
    abstract class Account
    {
        abstract public string CustomerName { get; protected set; }

        abstract public decimal Balance { get; protected set; }

        public Account(string customerName, decimal initialMoney)
        {
            this.Balance = initialMoney;
            this.CustomerName = customerName;
        }

        public decimal CloseAccount()
        {
            if (this.Balance > 0)
            {
                Console.WriteLine($"You have received {this.Balance} and closed {this.GetType().Name} account");
                return this.Balance;
            }
            if (this.Balance < 0)
            {
                Console.WriteLine($"You have payed {this.Balance} and closed {this.GetType().Name} account");
                return this.Balance;
            }
            else
                Console.WriteLine($"You have closed {this.GetType().Name} account");
            return 0;
        }
    }
}
