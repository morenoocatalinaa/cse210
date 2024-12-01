public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product) => products.Add(product);

    public decimal CalculateTotalPrice()
    {
        decimal total = 0;
        foreach (var product in products)
        {
            total += product.TotalCost();
        }
        return total;
    }

    public string GetPackingLabel()
    {
        string label = $"Packing Label for Order: {customer.Name}\n";
        foreach (var product in products)
        {
            label += product.ToString() + "\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = $"Shipping Label for Order: {customer.Name}\n";
        shippingLabel += $"Address: {customer.Address}\n";
        return shippingLabel;
    }
}