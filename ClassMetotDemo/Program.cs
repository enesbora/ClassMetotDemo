using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Enes";
            customer1.LastName = "Bora";


            Customer customer2 = new Customer();
            customer2.Id = 1;
            customer2.FirstName = "Fatih";
            customer2.LastName = "Sayar";

            Customer[] customers = new Customer[] { customer1, customer2 };

            foreach (var customer in customers)
            {
                Console.WriteLine("Musteri Adları : " + customer.FirstName + "\n");
                Console.WriteLine("Musteri Kredi Notu : " + customer.LastName + "\n");
            }

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Update(customer2);
            customerManager.Delete(customer1);

        }
    }
}
