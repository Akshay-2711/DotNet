namespace DataAccess;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using Assessment;

public class Deserializer{

public  static List<Student> RestoreData()
{   
     
    string filename = @"E:\Akshobhya_Akshay\.NET\Practice\Assignment\StudentData";

    string restorejson = System.IO.File.ReadAllText(filename);
    List<Student> jsonstudent = JsonSerializer.Deserialize<List<Student>>(restorejson);
    return  jsonstudent;
}
}
