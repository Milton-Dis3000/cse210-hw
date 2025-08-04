// Represents a product in an order.
public class Product
{
    // Private member variables to encapsulate the product data.
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    // Constructor to initialize the product with its values.
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Public getter methods.
    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }

    // Method to calculate the total cost of this product (price * quantity).
    public double GetTotalCost()
    {
        return _price * _quantity;
    }
}