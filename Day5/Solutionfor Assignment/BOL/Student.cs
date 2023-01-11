namespace BOL;
using System.ComponentModel.DataAnnotations;

//public enum Sgender {MALE,FEMALE,OTHERS};
[Serializable]
public class Student
{
    public Student()
    {
    }


    public Student(int id, string name, string email, string mobileNo, string gender)
    {
        Id = id;
        Name = name;
        Email = email;
        MobileNo = mobileNo;
        Gender = gender;
    }

    [Required]
    public int Id{get;set;}

    [Required]
    public string? Name{get;set;}
    public string? Email{get;set;}

    public string? MobileNo{get;set;}

    public string? Gender {get;set;}

    

    public override string ToString()
    {
        return "Id: "+ this.Id +" Email: "+this.Email+" Name : "+this.Name+" MobileNo: "+this.MobileNo;
    }
}
