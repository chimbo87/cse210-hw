public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    // Getters
    public string Name { get { return _name; } }
    public Address CustomerAddress { get { return _address; } }
}