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

        public List<Account> accounts;

        public Customer(string name, CurrentAccount currentAccount)
        {
            this.Name = name;
            this.accounts.Add(currentAccount);
        }

        public void CreateNewAccount(Customer customerName)
        {
            Console.WriteLine("You can create the following account:");
            foreach (var item in accounts)
            {
                item.GetType
            }
            if (true)
            {

            }
        }
    }
}
