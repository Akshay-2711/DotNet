namespace DAL;
using BOL;
public class DBmanager
{   

    public  static List<Product> GetAllProducts()
    {
        
    List<Product> product=new List<Product>();

    product.Add(new Product { Id = 1, Title = "Gerbera", Description = "Wedding Flower", Price = 6, Balance = 5000 });
    product.Add(new Product { Id = 2, Title = "Rose", Description = "Valentine Flower", Price = 50, Balance = 5000 });
    product.Add(new Product { Id = 3, Title = "Daisy", Description = "Glooming Flower", Price = 40, Balance = 5000 });
    product.Add(new Product { Id = 4, Title = "Mogra", Description = "Smelling Flower", Price = 6, Balance = 5000 });
    product.Add(new Product { Id = 5, Title = "Madhumalti", Description = "Home Flower", Price = 60, Balance = 1200 });

    return product;
    }

}
