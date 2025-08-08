// Product.cs

/// <summary>
/// Represents a product in an order.
/// </summary>
public class Product
{
    // Private member variables for product details.
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    /// <summary>
    /// Constructor to initialize the Product object.
    /// </summary>
    /// <param name="name">The name of the product.</param>
    /// <param name="productId">The unique ID of the product.</param>
    /// <param name="price">The price per unit of the product.</param>
    /// <param name="quantity">The quantity of the product being ordered.</param>
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    /// <summary>
    /// Calculates the total cost for this product line item.
    /// </summary>
    /// <returns>The total cost (price * quantity).</returns>
    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    // Getter for the product's name.
    public string Name => _name;

    // Getter for the product's ID.
    public string ProductId => _productId;
}
