using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019._05._25
{
    class Bank
    {
        private List<Customer> customers = new List<Customer>();

        public void AddClientToDataBase(Customer customer)
        {
            customers.Add(customer);
        }

        public Account[] GetCustomerAccountList(Customer name)
        {
            foreach (var item in customers)
            {
                item.accounts.
            }
        }
    }
}
