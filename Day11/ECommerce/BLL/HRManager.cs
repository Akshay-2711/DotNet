namespace BLL;
using BOL;
using DAL.Connected;
public class HRManager
{
    public List<Department> GetAllDepartments()
    {
        List<Department> allDepartments = new List<Department>();
        allDepartments = DBManager.GetAllDepartments();
        return allDepartments;
    }

    public List<Employee> GetEmployeesByDepartment(int id)
    {

        List<Employee> allEmployees = new List<Employee>();
        allEmployees = DBManager.GetEmployeesByDepartment(id);
       
        
        return allEmployees;

    }

}