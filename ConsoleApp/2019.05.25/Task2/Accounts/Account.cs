using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019._05._25
{
    abstract class Account
    {
        protected decimal balance;

        //protected string customerName;

        public Account(string customerName, decimal initialMoney)
        {
            this.Balance = initialMoney;
            this.CustomerName = customerName;
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
            protected set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.customerName = value;
                }
            }
        }


        public decimal CloseAccount()
        {
            {
                Console.WriteLine($"You have received {this.balance} and closed {this.GetType().Name} account");
                Console.WriteLine($"You have closed {this.GetType().Name} account");
                return this.balance;
            }
        }

        //public void AddToAccount(decimal sum)
        //{
        //    if (sum>0)
        //    {
        //        this.Balance += sum;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Operation failed. Sum must be greater than zero. Press any key.");
        //        Console.ReadKey();
        //    }
        //}

        //public void SubtractFromAccount(decimal sum)
        //{
        //    if (sum>0)
        //    {
        //        this.Balance -= sum;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Operation failed. Insufficient funds. Press any key.");
        //        Console.ReadKey();
        //    }
        //}
    }
}
