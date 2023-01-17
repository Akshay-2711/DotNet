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

[HttpGet]
    public IActionResult Insertproduct()
    {
        return View();
    }

[HttpPost]
    public IActionResult Insertproduct(string id,string pname,string price,string pbrand)
    {   
        DataAccess.InsertProduct(int.Parse(id),pname,double.Parse(price),pbrand);
        return RedirectToAction("Index","Home");
    }

    [HttpDelete]
    public IActionResult Delete(int id)
    {
        DataAccess.Delete(id);
        return View();
    }

}