using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add (Customer customer)
        {
            Console.WriteLine("You are correctly added to the system" + customer.FirstName + " " + customer.LastName);
        }

        public void Delete (Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + "You have deleted the account.");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.Id + " " + customer.FirstName + " " + customer.LastName + " " + " is updated.");
        }
    }

}
