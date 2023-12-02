using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address usaAddress = new Address("123 Main St", "Cityville", "CA", "USA");
        Address nonUsaAddress = new Address("456 Oak St", "Townsville", "NSW", "Australia");

        // Create customers
        Customer usaCustomer = new Customer("Priscilla Smith", usaAddress);
        Customer nonUsaCustomer = new Customer("Joseph Cothill", nonUsaAddress);

        // Create products
        Product product1 = new Product("Widget", "W123", 10.99, 2);
        Product product2 = new Product("Gadget", "G456", 24.99, 1);
        Product product3 = new Product("Doohickey", "D789", 15.49, 3);

        // Create orders
        Order order1 = new Order(usaCustomer);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(nonUsaCustomer);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display order details
        Console.WriteLine("Order 1 Details:");
        order1.DisplayOrderDetails();
        Console.WriteLine();

        Console.WriteLine("Order 2 Details:");
        order2.DisplayOrderDetails();
    }
}