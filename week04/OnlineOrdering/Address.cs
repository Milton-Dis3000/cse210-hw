// Represents a customer's address.

public class Address
{
    // Private member variables to encapsulate the address data.
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    // Constructor to initialize the address with all its components.
    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    // Method to check if the address is in the USA.
    public bool IsInUSA()
    {
        // Your logic here to compare the _country attribute.
        // It should return true if the country is "USA", otherwise false.
        return _country.ToUpper() == "USA";
    }

    // Method to get a nicely formatted string of the full address.
    public string GetFullAddressString()
    {
        // Your logic here to combine all address parts into a single string.
        // Use newline characters (\n) for formatting.
        return $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
    }
}