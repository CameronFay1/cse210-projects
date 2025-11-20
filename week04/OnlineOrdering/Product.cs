public class Product
{
    private string _name;
    private int _productId;
    private int _price;
    private int _quantity;
    public Product(string name, int productID, int price, int quantity)
    {
        _name = name;
        _productId = productID;
        _price = price;
        _quantity = quantity;
    } 
    public int GetPrice()
    {
        return _price;
    }
    public string Display()
    {
        return $"Item-({_name}) ID-({_productId}) Amount-({_quantity}) Pice-(${_price})";
    }
}