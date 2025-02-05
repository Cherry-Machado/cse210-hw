using System;
using System.Collections.Generic;

// Class representing an order
public class Order
{
    private List<Product> _products;
    private Customer _customer;

    // Constructor
    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    // Method to add a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    //Method to calculate the total price of the order
    
}