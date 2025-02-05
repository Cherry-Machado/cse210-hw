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
    public double CalculateTotalPrice()
    {
        double productTotal = 0;
        foreach (var product in _products)
        {
            productTotal += product.CalculateTotalCost();
        }
        double shippingCost = _customer.LivesInUSA() ? 5 : 35;
        return productTotal + shippingCost;
    }

    //Method to generate the packing label
    public string GeneratePackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (var product in _products)
        {
            packingLabel += $"-  {product.GetPackingLabelInfo()}\n";
        }
        return packingLabel;
    }

    //Method to generate the shipping label
    public string GenerateShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetCustomerInfo()}";
    }
}