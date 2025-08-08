// Order.cs
using System.Text;

/// <summary>
/// Represents a customer's order, containing a list of products and customer information.
/// </summary>
public class Order
{
    // Private member variables for the list of products and the customer.
    private List<Product> _products;
    private Customer _customer;

    /// <summary>
    /// Constructor to initialize the Order with a customer.
    /// Products are added separately.
    /// </summary>
    /// <param name="customer">The customer placing the order.</param>
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    /// <summary>
    /// Adds a product to the order.
    /// </summary>
    /// <param name="product">The product to add.</param>
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    /// <summary>
    /// Calculates the final total price of the order, including shipping.
    /// </summary>
    /// <returns>The total price of the order.</returns>
    public double CalculateTotalPrice()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalCost();
        }

        // Add shipping cost based on customer's location.
        if (_customer.LivesInUSA())
        {
            total += 5; // $5 shipping for USA
        }
        else
        {
            total += 35; // $35 shipping for international
        }
        return total;
    }

    /// <summary>
    /// Generates a packing label string for the order.
    /// </summary>
    /// <returns>A string containing the packing label.</returns>
    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();
        label.AppendLine("Packing Label:");
        foreach (var product in _products)
        {
            label.AppendLine($"- Product: {product.Name}, ID: {product.ProductId}");
        }
        return label.ToString();
    }

    /// <summary>
    /// Generates a shipping label string for the order.
    /// </summary>
    /// <returns>A string containing the shipping label.</returns>
    public string GetShippingLabel()
    {
        StringBuilder label = new StringBuilder();
        label.AppendLine("Shipping Label:");
        label.AppendLine($"Customer: {_customer.Name}");
        label.AppendLine(_customer.Address.GetFullAddress());
        return label.ToString();
    }
}
