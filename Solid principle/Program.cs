using System;
using System.Collections.Generic;
using System.Linq;
using Solid_principle.Customer;

namespace Solid_principle
{
    class Program

    {   
        static void Main()
        {
            /*var employeeOnly= new List<IEmployee>();
            employeeOnly.Add(new PermanentEmployee(1,"Dorin"));
            employeeOnly.Add(new TemporaryEmployee(1,"John/"));
            foreach (var employee in employeeOnly)
            {
                Console.WriteLine("Employee{0},Bonus{1}", employee?.ToString(),
                    employee.CalculateBonus(1000).ToString());
                //Console.WriteLine("Employee{0},Bonus{1}", empJohn.ToString(), empJohn.CalcutateBonus(1000).ToString());*/
            var customers= new List<ICalculateDiscount>();
            customers.Add(new PremiumCustomer("Dorin",1,"Premium"));
            customers.Add(new PremiumCustomer("Andrei", 2,"Premium"));
            customers.Add(new SimpleCustomer("Ion", 1,"Simple"));
            customers.Add(new SimpleCustomer("Andreea", 2,"Simple"));
            customers.Add(new SuperPremiumCustomer("Marius", 1,"SuperPremium"));
            customers.Add(new SuperPremiumCustomer("George", 2,"SuperPremium"));
            customers.Add(new CustomerNotRegistered("David", 1,"NoRegistered"));
            customers.Add(new CustomerNotRegistered("Daniela", 2,"NoRegistered"));
           
                var premiumCustumers =customers.Where(custumer => custumer.CustomerType == "Premium").ToList();
                var superPremium= customers.Where(custumer => custumer.CustomerType == "SuperPremium").ToList();
                var noregisteredCustomers = customers.Where(custumer => custumer.CustomerType == "NoRegistered").ToList();
                var simpleCustomers = customers.Where(custumer => custumer.CustomerType == "Simple").ToList();
                
                foreach (var premium in premiumCustumers) Console.WriteLine($"Customer: {premium.Name} is a premium customer and the total amount after discount  is : {premium.CalculateDiscount(120,4)}");
                foreach (var super in superPremium) Console.WriteLine($"Customer: {super.Name} is a super premium customer and the total amount after discount  is : {super.CalculateDiscount(120, 4)}");
                foreach (var noRegistered in noregisteredCustomers) Console.WriteLine($"Customer: {noRegistered.Name} is a no registered customer and the total amount after discount  is : {noRegistered.CalculateDiscount(120, 4)}");
                foreach (var simple in simpleCustomers) Console.WriteLine($"Customer: {simple.Name} is a simple customer and the total amount after discount  is : {simple.CalculateDiscount(120, 4)}");
            
                
            foreach (ICalculateDiscount customer in customers) Console.WriteLine($"{customer.Name}, {customer.CalculateDiscount(120,6)}");
            foreach (ICalculateDiscount customer in customers) Console.WriteLine($"{customer.Name}, {customer.CalculateDiscount(120, 2)}");
            foreach (ICalculateDiscount customer in customers) Console.WriteLine($"{customer.Name}, {customer.CalculateDiscount(223, 6)}");

        }
    }

    
}

