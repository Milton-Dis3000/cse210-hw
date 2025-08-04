using System.Collections.Generic;
using System.Text;

// Represents an order, containing a list of products and a customer.
public class Order
{
    // Private member variables for the products and customer.
    private List<Product> _products;
    private Customer _customer;

    // Constructor to initialize the order with a list of products and a customer object.
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    // Method to calculate the total cost of the order, including shipping.
    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }

        // Add shipping cost based on the customer's location.
        if (_customer.IsInUSA())
        {
            totalCost += 5; // USA shipping
        }
        else
        {
            totalCost += 35; // International shipping
        }

        return totalCost;
    }

    // Method to generate the packing label.
    public string GetPackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder();
        packingLabel.AppendLine("Packing Label:");
        foreach (Product product in _products)
        {
            // Now we use the public getter methods.
            packingLabel.AppendLine($"Product ID: {product.GetProductId()}, Name: {product.GetName()}");
        }
        return packingLabel.ToString();
    }

    // Method to generate the shipping label.
    public string GetShippingLabel()
    {
        StringBuilder shippingLabel = new StringBuilder();
        shippingLabel.AppendLine("Shipping Label:");
        shippingLabel.AppendLine(_customer.GetName());
        shippingLabel.AppendLine(_customer.GetAddress().GetFullAddressString());
        return shippingLabel.ToString();
    }
}