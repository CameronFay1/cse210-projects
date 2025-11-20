public class Customer
{
    private string _name;
    private Address _address;
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public void Display()
    {
        Console.Write($"Name-({_name}) Address({_address.Display()})");

    }
}