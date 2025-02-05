using System;
using System.Collections.Generic;

// Class representing a Customer
public class Customer
{
    private string _name;
    private Address _address;

    // Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    //Method to check if the customer lives in the USA
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    // Method to get the customer's name and address
    public string GetCustomerInfo()
    {
        return $"{_name}\n{_address.GetFullAddress()}";
    }
}