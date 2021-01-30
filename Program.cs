using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Ali";
            customer1.Surname = "Veli";
            customer1.CustomerNo = 123456;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Ayşe";
            customer2.Surname = "Fatma";
            customer2.CustomerNo = 12345689;

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Hasan";
            customer3.Surname = "Hüseyin";
            customer3.CustomerNo = 6556456;


            CustomerManager customerManager = new CustomerManager();
            customerManager.CustomerAdd(customer1);
            Console.WriteLine("-----------------------");
            customerManager.CustomerListing(customer2);
            Console.WriteLine("-----------------------");
            customerManager.CustomerDelete(customer3);

            
        }
    }
}
