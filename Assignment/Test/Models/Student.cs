namespace Assessment;

public class Student{
    public Student()
    {
    }

    private string Name{get;set;}

    private string Email{get;set;}

    private string MobileNo{get;set;}

    private string Password{get;set;}

    public Student(string name, string email, string mobileNo, string password)
    {
        Name = name;
        Email = email;
        MobileNo = mobileNo;
        Password = password;
    }

    


    public override string? ToString()
    {
        return base.ToString()+"Name="+this.Name+" Email="+this.Email+" MobileNo="+this.MobileNo;
    }
}