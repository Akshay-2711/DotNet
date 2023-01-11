using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EStoreApp.Models;
using BLL;
using BOL;
using DAL;

namespace EStoreApp.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

     public IActionResult Index()
    {   
        CatalogManager cm =new CatalogManager();
        List<Product> allproducts=cm.GetProducts();
        this.ViewData["products"]=allproducts;
        return View();
    }




}
