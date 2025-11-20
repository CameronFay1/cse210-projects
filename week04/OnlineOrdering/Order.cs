public class Order
{
    private List<Product> _products = new List<Product>
    {
        new Product("Note Book",1,4,3),
        new Product("Milk",2,2,2),
        new Product("Egggs",3,5,3),
        new Product("Bread",4,3,1),
        new Product("Pencils",5,1,10)
    };
    public void PackingLabel()
    {
        foreach (Product i in _products)
        {
            Console.WriteLine(i.Display());
        }
    }
    public void TotalCost(bool inUSA)
    {
        int cost = 0;
       foreach (Product i in _products)
        {
            cost += i.GetPrice();
        } 
        if (inUSA == true)
        {
            cost += 5;
        }
        else if (inUSA == false)
        {
            cost += 35;
        }
        Console.WriteLine($"Price-(${cost})");
    }
}