using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // ----- Order 1: US Customer -----
        Console.WriteLine("----- Order 1 -----");

        // Create the address for a US customer.
        Address address1 = new Address("123 Main St", "Los Angeles", "CA", "USA");

        // Create the customer with the US address.
        Customer customer1 = new Customer("John Smith", address1);

        // Create products for the first order.
        Product product1_1 = new Product("Laptop", "P-101", 1200.50, 1);
        Product product1_2 = new Product("Mouse", "P-102", 25.00, 2);

        // Create a list of products and the order.
        List<Product> products1 = new List<Product> { product1_1, product1_2 };
        Order order1 = new Order(products1, customer1);

        // Display the results for the first order.
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");

        Console.WriteLine("\n----------------------------------------\n");

        // ----- Order 2: International Customer -----
        Console.WriteLine("----- Order 2 -----");
        
        // Create the address for an international customer.
        Address address2 = new Address("456 International Blvd", "Vancouver", "BC", "Canada");

        // Create the customer with the international address.
        Customer customer2 = new Customer("Maria Rodriguez", address2);

        // Create products for the second order.
        Product product2_1 = new Product("Keyboard", "P-201", 75.25, 1);
        Product product2_2 = new Product("Headphones", "P-202", 150.00, 1);

        // Create a list of products and the order.
        List<Product> products2 = new List<Product> { product2_1, product2_2 };
        Order order2 = new Order(products2, customer2);

        // Display the results for the second order.
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
    }
}