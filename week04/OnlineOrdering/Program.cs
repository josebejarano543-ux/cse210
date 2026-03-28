using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 - USA
        Address address1 = new Address("123 Main St", "Provo", "UT", "USA");
        Customer customer1 = new Customer("Jose Bejarano", address1);

        List<Product> products1 = new List<Product>
        {
            new Product("Laptop", "P100", 800, 1),
            new Product("Mouse", "P101", 25, 2),
            new Product("Keyboard", "P102", 45, 1)
        };

        Order order1 = new Order(customer1, products1);

        // Order 2 - Outside USA
        Address address2 = new Address("456 Maple Rd", "Toronto", "Ontario", "Canada");
        Customer customer2 = new Customer("Maria Lopez", address2);

        List<Product> products2 = new List<Product>
        {
            new Product("Phone", "P200", 600, 1),
            new Product("Charger", "P201", 20, 3)
        };

        Order order2 = new Order(customer2, products2);

        // OUTPUT
        Console.WriteLine("=== ORDER 1 ===");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total: ${order1.CalculateTotalCost()}");

        Console.WriteLine("\n=== ORDER 2 ===");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total: ${order2.CalculateTotalCost()}");
    }
}