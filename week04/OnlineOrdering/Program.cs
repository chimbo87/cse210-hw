using System;
using System.Collections.Generic;

// Address Class
public class Address
{
    // Private member variables
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    // Constructor
    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    // Method to check if address is in USA
    public bool IsInUSA()
    {
        return _country.ToUpper() == "USA";
    }

    // Method to return full address as a string
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_stateProvince}\n{_country}";
    }
}

// Customer Class
public class Customer
{
    // Private member variables
    private string _name;
    private Address _address;

    // Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Getter for name
    public string GetName()
    {
        return _name;
    }

    // Method to check if customer is in USA
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    // Getter for address
    public Address GetAddress()
    {
        return _address;
    }
}

// Product Class
public class Product
{
    // Private member variables
    private string _name;
    private string _productId;
    private decimal _price;
    private int _quantity;

    // Constructor
    public Product(string name, string productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Method to calculate total cost of product
    public decimal GetTotalCost()
    {
        return _price * _quantity;
    }

    // Getters
    public string GetName() => _name;
    public string GetProductId() => _productId;
}

// Order Class
public class Order
{
    // Private member variables
    private List<Product> _products;
    private Customer _customer;
    private const decimal USA_SHIPPING_COST = 5.00m;
    private const decimal INTERNATIONAL_SHIPPING_COST = 35.00m;

    // Constructor
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // Method to add product to order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Method to calculate total order price
    public decimal GetTotalPrice()
    {
        decimal productTotal = 0;
        foreach (Product product in _products)
        {
            productTotal += product.GetTotalCost();
        }

        // Add shipping cost based on customer location
        decimal shippingCost = _customer.IsInUSA() ? USA_SHIPPING_COST : INTERNATIONAL_SHIPPING_COST;
        return productTotal + shippingCost;
    }

    // Method to generate packing label
    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += $"Product: {product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return packingLabel;
    }

    // Method to generate shipping label
    public string GetShippingLabel()
    {
        return $"Name: {_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("456 Global Rd", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Headphones", "WH001", 99.99m, 2));
        order1.AddProduct(new Product("Bluetooth Speaker", "BS002", 49.99m, 1));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Laptop", "LP003", 1299.99m, 1));
        order2.AddProduct(new Product("Keyboard", "KB004", 79.99m, 1));

        // Display order details
        Console.WriteLine("Order 1 Details:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order1.GetTotalPrice():F2}");

        Console.WriteLine("\n-------------------\n");

        Console.WriteLine("Order 2 Details:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order2.GetTotalPrice():F2}");
    }
}