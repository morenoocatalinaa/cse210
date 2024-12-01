public class Product
{
    private string name;
    private string productId;
    private decimal price;
    private int quantity;

    public Product(string name, string productId, decimal price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public string Name => name;
    public string ProductId => productId;

    public decimal TotalCost() => price * quantity;

    public override string ToString() => $"{Name} ({ProductId}) - {quantity} units at {price:C} each, Total: {TotalCost():C}";
}