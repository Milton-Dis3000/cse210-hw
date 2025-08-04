// Represents a customer with their name and address.
public class Customer
{
    // Private member variables to encapsulate the customer data.
    private string _name;
    private Address _address;

    // Constructor to initialize the customer with a name and an Address object.
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Public getter methods.
    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    // Method to check if the customer lives in the USA.
    // It delegates the check to the Address class.
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }
}