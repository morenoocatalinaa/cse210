class Program
{
    static void Main()
    {
        var address1 = new Address("123 Main St", "New York", "USA");
        var customer1 = new Customer("Alice", address1);
        var product1 = new Product("Laptop", "P001", 1000.00m, 1);
        var product2 = new Product("Headphones", "P002", 150.00m, 2);

        var order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        var address2 = new Address("456 Oak St", "Los Angeles", "USA");
        var customer2 = new Customer("Bob", address2);
        var product3 = new Product("Tablet", "P003", 500.00m, 1);
        var product4 = new Product("Keyboard", "P004", 100.00m, 2);

        var order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine($"Order 1 Total: {order1.CalculateTotalPrice():C}");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Order 2 Total: {order2.CalculateTotalPrice():C}");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
    }
}