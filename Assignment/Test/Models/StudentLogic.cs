using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
namespace Assessment;
using DataAccess;

public class StudentLogic
{

    List<Student> std =new List<Student>( DataAccess.Deserializer.RestoreData());
    
    public List<Student> insertData(string name, string email, string mob, string password)
    {
        std.Add(new Student(name, email, mob, password));
        foreach (Student s in std)
        {
            Console.WriteLine(s);
        }
        return std;
    }

    public bool StoreData(List<Student> s)
    {

        try
        {

            var options = new JsonSerializerOptions { IncludeFields = true };
            var registerjson = JsonSerializer.Serialize<List<Student>>(s, options);
            string filename = @"E:\Akshobhya_Akshay\.NET\Practice\Assignment\StudentData\student.json";

            System.IO.File.WriteAllText(filename, registerjson);
            Console.WriteLine("Student registered successfully!!");
            
           
        }
        finally
        {

        }
        return true;
    }


    public void validate(string email,string password)
    {
    
    }
}