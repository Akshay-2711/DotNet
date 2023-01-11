using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Test.Models;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using Assessment;

namespace Test.Controllers;

public class AuthController : Controller
{

    private readonly ILogger<AuthController> _logger;

    public AuthController(ILogger<AuthController> logger)
    {
        _logger = logger;
    }

    public IActionResult Login()
    {

        Console.WriteLine("In auth controller");
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }

    public IActionResult Registered(string name, string email, string mob, string password)
    {
        StudentLogic s=new StudentLogic();
        List<Student> st1=new List<Student>();
        st1=s.insertData( name,  email,  mob, password);
        s.StoreData(st1);
        return Redirect("/home");
    }
    // public IActionResult Validate(string email, string password)
    // {
    //     //deser
    //     //if(obj.Email==email&& obj.pass==pass)
    //     string filename = @"E:\Akshobhya_Akshay\.NET\Practice\Assignment\StudentData";

    //     string restorejson = System.IO.File.ReadAllText(filename);
    //     List<Student> jsonstudent = JsonSerializer.Deserialize<List<Student>>(restorejson);

    //     foreach (Student s in jsonstudent)
    //         return View();

    // }

    
   

}
