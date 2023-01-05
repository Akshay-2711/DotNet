namespace Assessment;

public class Student{
    public Student()
    {   
        
    }

    public string Name{get;set;}
    public int StudentId{get;set;}
    public string Email{get;set;}
    public string MobileNo{get;set;}
    public string Gender{get;set;}

    public override string? ToString()
    {
        return "Name:"+this.Name+" StudentId: "+this.StudentId;
    }

    // public Student(string name, int studentId, string email, string mobileNo, string gender)
    // {
    //     Name = name;
    //     StudentId = studentId;
    //     Email = email;
    //     MobileNo = mobileNo;
    //     Gender = gender;
    // }





}