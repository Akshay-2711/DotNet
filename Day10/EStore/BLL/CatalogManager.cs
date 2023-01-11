namespace BLL;
using DAL;
using BOL;
public class CatalogManager
{   


    public List<Product> GetProducts(){

        List<Product> allproduct=new List<Product>();
        allproduct=DBmanager.GetAllProducts();
        return allproduct;

    }

}
