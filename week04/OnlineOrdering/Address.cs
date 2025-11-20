public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country; 
    } 
    public bool IsInUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return true;
        }
    }
    
    public string Display()
    {
        return $"street-({_street}) City-({_city}) State-({_state}) country-({_country})"; 
    }
}