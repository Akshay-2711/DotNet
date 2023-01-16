using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TestMVC.Models;
using DAL;
using Test.BOL;

namespace TestMVC.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {   
        List<Product> p = DataAccess.GetAllProducts();
        this.ViewData["products"]=p;
        
        return View();
    }
     public IActionResult Detail(int id)
    {   
        Product p = DataAccess.GetproductById(id);
        this.ViewData["products"]=p;
        
        return View();
    }

    public IActionResult Insert(Product p)
    {
        DataAccess.InsertProduct(p);
        this.ViewData["products"]=p;
        return RedirectAction("Insertproduct");
    }
}