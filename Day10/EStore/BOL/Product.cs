namespace BOL;
public class Product
{
    public Product()
    {
    }

    public int Id{get;set;}
    public string Title{get;set;}

    public string Description{get;set;}

    public float Price{get;set;}

    public int Balance{get;set;}

    public Product(int id, string title, string description, float price, int balance)
    {
        Id = id;
        Title = title;
        Description = description;
        Price = price;
        Balance = balance;
    }

    

}
