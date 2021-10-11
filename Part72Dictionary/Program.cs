using System;
using System.Collections.Generic;

namespace Part72Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                Id = 101,
                Name = "Shubham",
                Salary=50000

            };
            Customer customer2 = new Customer
            {
                Id = 102,
                Name = "Sauraah",
                Salary = 40000

            };
            Customer customer3 = new Customer
            {
                Id = 103,
                Name = "Rahul",
                Salary = 20000

            };
           
            Dictionary<int,Customer >customers= new Dictionary<int, Customer>();
            customers.Add(customer1.Id, customer1);
            customers.Add(customer2.Id, customer2);
            customers.Add(customer3.Id, customer3);
            Customer custo103=customers[103];
           // Console.WriteLine("Id = {0} Name = {1} Salary = {2}",custo103.Id,custo103.Name,custo103.Salary);
           foreach(KeyValuePair<int,Customer> newList in customers)
            {
                Console.WriteLine("Key ={0}", newList.Key);
                 Customer custo= newList.Value;
                Console.WriteLine("Id = {0} Name = {1} Salary = {2}", custo.Id, custo.Name, custo.Salary);
                Console.WriteLine("----------------------------------------------------------------------------");

            }

        }
    }
   public  class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

    }
}
