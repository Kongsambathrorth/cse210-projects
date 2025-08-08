// Address.cs

/// <summary>
/// Represents a physical address.
/// </summary>
public class Address
{
    // Private member variables to store address details.
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    /// <summary>
    /// Constructor to initialize the Address object with all its details.
    /// </summary>
    /// <param name="streetAddress">The street address.</param>
    /// <param name="city">The city.</param>
    /// <param name="stateOrProvince">The state or province.</param>
    /// <param name="country">The country.</param>
    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    /// <summary>
    /// Checks if the address is in the USA.
    /// </summary>
    /// <returns>True if the country is "USA" or "United States", otherwise false.</returns>
    public bool IsInUSA()
    {
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase) || 
               _country.Equals("United States", StringComparison.OrdinalIgnoreCase);
    }

    /// <summary>
    /// Returns the full address as a formatted string.
    /// </summary>
    /// <returns>A string representation of the full address.</returns>
    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateOrProvince}\n{_country}";
    }
}


