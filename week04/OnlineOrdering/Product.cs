using System;
using System.Collections.Generic;

public class Product
{
    private string _name;
    private string _productId;
    private double _prince;
    private int _quantity;

    // Constructor
    public Product(string name, string productId, double price, int quatity)
    {
        _name = name;
        _productId = productId;
        _prince = price;
        _quantity = quatity;
    }

    // Method to calculate the total cost of the product
    public double CalculateTotalCost()
    {
        return _prince * _quantity;
    }

    // Method to get the product's name and ID fot the packing label
    public string GetPackingLabelInfo()
    {
        return $"Product: {_name} (ID: {_productId})";
    }
}