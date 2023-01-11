namespace BOL;


public class Employee
    {
    public Employee()
    {
    }

    public int? Id{get;set;}
        public string? FirstName{get;set;}
        public string? LastName{get;set;}
        public string? Address{get;set;}
        public string? Email{get;set;}
        public int? DeptId{get;set;}      
        public int? ManagerId{get;set;}

        public string? Password{get;set;}

    public Employee(int id, string firstName, string lastName, string address, string email, int deptId, int managerId, string password)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Address = address;
        Email = email;
        DeptId = deptId;
        ManagerId = managerId;
        Password = password;
    }
}