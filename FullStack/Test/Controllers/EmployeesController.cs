using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Test.Model;
using Test.DAL;
namespace Test.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeesController : ControllerBase
{
        

    private readonly ILogger<EmployeesController> _logger;

    public EmployeesController(ILogger<EmployeesController> logger)
    {
         _logger = logger;
    }

[HttpGet]
[EnableCors()]
    public IEnumerable <Employees> GetAllEmployees()
    {
        List<Employees> employee=DataAccess.GetAllEmployees();
        return employee;
    }
    
[Route("{id}")]
[HttpGet]
[EnableCors()]
    public ActionResult<Employees> GetById(int id){
         Employees emp=DataAccess.GetEmployeeById(id);
         return emp;
    }

[HttpPost]
[EnableCors()]
    public IActionResult InsertEmp(Employees e)
    {
        DataAccess.InsertEmployee(e);
        return Ok(new {message="Employee Inserted Successfully!"});

    }
    
[Route("{id}")]
[HttpDelete]
[EnableCors()]
    public ActionResult<Employees> DeleteEmp(int id)
    {
        DataAccess.DeleteEmployee(id);
        return Ok(new{message="Employee deleted successfully"});
    }

}
