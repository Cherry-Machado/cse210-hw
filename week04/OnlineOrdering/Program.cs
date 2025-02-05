using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine("");

        // Create adresses
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        //Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        //Create products
        Product product1 = new Product("Laptop", "LP123", 1000, 1);
        Product product2 = new Product("Mouse", "MS456", 25, 2);
        Product product3 = new Product("Keyboard", "KB789", 50, 1);
        Product product4 = new Product("Monitor", "MN101", 200, 1);
        Product product5 = new Product("Headphones", "HP202", 50, 3);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        

    }
}