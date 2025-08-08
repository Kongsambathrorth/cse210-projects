// Customer.cs

/// <summary>
/// Represents a customer with a name and an address.
/// </summary>
public class Customer
{
    // Private member variables for the customer's name and address.
    private string _name;
    private Address _address;

    /// <summary>
    /// Constructor to initialize the Customer object.
    /// </summary>
    /// <param name="name">The customer's name.</param>
    /// <param name="address">The customer's address (as an Address object).</param>
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    /// <summary>
    /// Determines if the customer lives in the USA by checking their address.
    /// </summary>
    /// <returns>True if the customer's address is in the USA, otherwise false.</returns>
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    // Getter for the customer's name.
    public string Name => _name;

    // Getter for the customer's address object.
    public Address Address => _address;
}
