using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        

        public void CustomerAdd(Customer customer)
        {
            Console.WriteLine(customer.Name+" Added");
        }


        public void CustomerListing(Customer customer)
        {
            Console.WriteLine("Customer Listing...");
            Console.WriteLine("ID: "+customer.Id);
            Console.WriteLine("Customer Name: "+customer.Name);
            Console.WriteLine("Customer Surname: "+customer.Surname);
            Console.WriteLine("Customer No: "+customer.CustomerNo);
        }
        public void CustomerDelete(Customer customer)
        {
            Console.WriteLine(customer.Name+" Deleted");
        }
    }
}
