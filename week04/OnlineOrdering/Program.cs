class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Maple Road", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Smith", address1);
        Customer customer2 = new Customer("Emily Johnson", address2);

        // Create orders
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        // Add products to order1
        order1.AddProduct(new Product("Laptop", "L001", 1200.00m, 1));
        order1.AddProduct(new Product("Mouse", "M001", 25.50m, 2));
        order1.AddProduct(new Product("Keyboard", "K001", 75.00m, 1));

        // Add products to order2
        order2.AddProduct(new Product("Smartphone", "P001", 800.00m, 1));
        order2.AddProduct(new Product("Headphones", "H001", 150.00m, 1));

        // Display order details
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine("Order Details:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalPrice():F2}");
        Console.WriteLine(); // Extra line for readability
    }
}