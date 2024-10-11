using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        var address1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        var address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        // Create customers
        var customer1 = new Customer("John Doe", address1);
        var customer2 = new Customer("Jane Smith", address2);

        // Create orders
        var order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "001", 999.99m, 1));
        order1.AddProduct(new Product("Mouse", "002", 19.99m, 2));

        var order2 = new Order(customer2);
        order2.AddProduct(new Product("Smartphone", "003", 699.99m, 1));
        order2.AddProduct(new Product("Charger", "004", 24.99m, 3));

        // Display total cost for Order 1
        Console.WriteLine("Order 1:");
        Console.WriteLine($"Total Cost: ${order1.TotalCost()}");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine();

        // Display total cost for Order 2
        Console.WriteLine("Order 2:");
        Console.WriteLine($"Total Cost: ${order2.TotalCost()}");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.ShippingLabel());
    }
}
