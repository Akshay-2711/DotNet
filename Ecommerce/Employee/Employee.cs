namespace Employee;
public class Employee
{
    private string email,firstname,lastname, address;
    private int id, base_salary, da, hra; 
    private DateTime dob;

    public string LastName { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }

    public int Id { get; set; }
    public int Base_Salary { get; set; }
    public int DA { get; set; }
    public string FirstName { get; set; }
    public int HRA { get; set; }



    public Employee(string email, string firstname, string lastname, string address, int id, int salary, int dA, int hRA, DateTime dob)
    {
        this.email = email;
        this.firstname = firstname;
        this.lastname = lastname;
        this.address = address;
        this.id = id;
        this.base_salary = salary;
        DA = dA;
        HRA = hRA;
        this.dob = dob;
    }
}
