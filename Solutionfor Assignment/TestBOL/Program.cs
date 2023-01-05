using BOL;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

Student s1 = new Student { Id = 1, Name = "Akshay Gavhane", Email = "akshay@gmail.com", MobileNo = "9898989898", Gender = "MALE" };
Student s2 = new Student { Id = 2, Name = "Akshobhya Bellurkar", Email = "akshobhya@gmail.com", MobileNo = "7878878787", Gender = "MALE" };
Student s3 = new Student { Id = 3, Name = "Akash Patole", Email = "akash69@gmail.com", MobileNo = "9898696969", Gender = "MALE" };
Student s4 = new Student { Id = 4, Name = "Prathamesh Shewale", Email = "prathamesh12@gmail.com", MobileNo = "9764312873", Gender = "MALE" };
Student s5 = new Student { Id = 5, Name = "Anjali Patil", Email = "anjalip@gmail.com", MobileNo = "9382711379", Gender = "FEMALE" };

List<Student> studlist = new List<Student>();
studlist.Add(s1);
studlist.Add(s2);
studlist.Add(s3);
studlist.Add(s4);
studlist.Add(s5);

// try{
// var options=new JsonSerializerOptions{IncludeFields=true};
// var writejson=JsonSerializer.Serialize<List<Student>>(studlist,options);
// string? filename=@"E:\Akshobhya_Akshay\.NET\Practice\Day5\students.json";
// File.WriteAllText(filename,writejson);

// string? readjson=File.ReadAllText(filename);
// List<Student>? jsonstud=JsonSerializer.Deserialize<List<Student>>(readjson);

// foreach(Student s in  jsonstud)
// {
//     Console.WriteLine($"{s.Name}:{s.MobileNo},{s.Email}");
// }

// }catch(Exception e)  {
//         Console.WriteLine(e);
// }

Console.WriteLine("1.Insert ");
Console.WriteLine("2.Delete ");
Console.WriteLine("3.Update ");
Console.WriteLine("4.Get by Id ");
Console.WriteLine("5.Display all ");
Console.WriteLine("6.Serialization ");
Console.WriteLine("7.DeSerialization ");
Console.WriteLine("10.Exit ");

bool exit = false;
 
 int temp;
while (!exit)
{
    Console.WriteLine("Enter choice");
    string ops = Console.ReadLine();
    int op = Convert.ToInt32(ops);

    switch (op)
    {
        case 1:

            Console.WriteLine("Enter Id,name,email,mobileno,gender");
            string ids = Console.ReadLine();
            int id = Convert.ToInt32(ids);
            string name = Console.ReadLine();
            string email = Console.ReadLine();
            string mobileno = Console.ReadLine();
            string gender = Console.ReadLine();

            Student s = new Student { Id = id, Name = name, Email = email, MobileNo = mobileno, Gender = gender };
            studlist.Add(s);
            break;

        case 2:
            Console.WriteLine("Enter your Id");
            string value=Console.ReadLine();
             temp = Convert.ToInt32(value);
            foreach (Student std in studlist)
            {
                if (std.Id == temp)
                {
                    studlist.Remove(std);
                    break;
                }
                

            }
            

            break;

        case 3:
            break;

        case 4:
            Console.WriteLine("Enter your Id");
            string val=Console.ReadLine();
             temp = Convert.ToInt32(val);
            foreach (Student std in studlist)
            {
                if (std.Id == temp)
                {
                    System.Console.WriteLine(std);
                    break;
                }
            }
            System.Console.WriteLine("Not a valid Id");

            break;

        case 5:

            foreach (Student std in studlist)
            {
                Console.WriteLine(std);
            }
            break;

        case 6:
            //serialization
            var options = new JsonSerializerOptions { IncludeFields = true };
            var writejson = JsonSerializer.Serialize<List<Student>>(studlist, options);
            string? filename = @"E:\Akshobhya_Akshay\.NET\Practice\Day5\students.json";
            File.WriteAllText(filename, writejson);
            break;

        case 7:
            filename = @"E:\Akshobhya_Akshay\.NET\Practice\Day5\students.json";
            string? readjson = File.ReadAllText(filename);
            List<Student>? jsonstud = JsonSerializer.Deserialize<List<Student>>(readjson);
            foreach (Student std in jsonstud)
            {
                Console.WriteLine(std);
            }
            break;

        case 10:
            exit = false;
            break;


    }
}
