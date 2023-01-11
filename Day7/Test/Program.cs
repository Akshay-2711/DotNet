using Assessment;
using System.Collections.Generic;
using System.Threading;
using TFLCollection;
using Maths;

List<Student> std=new List<Student>();
std.Add(new Student() {Name="Akshay Gavhane",StudentId=1,Email="aksh@gmail.com",MobileNo="9898989898",Gender="MALE" });
std.Add(new Student() {Name="Akshobhya Bellurkar",StudentId=2,Email="aksh@gmail.com",MobileNo="9898989898",Gender="MALE" });
std.Add(new Student() {Name="Ratnakar Patil",StudentId=3,Email="aksh@gmail.com",MobileNo="9898989898",Gender="MALE" });
std.Add(new Student() {Name="Akash Patole",StudentId=4,Email="aksh@gmail.com",MobileNo="9898989898",Gender="MALE" });
std.Add(new Student() {Name="Prathamesh Shewale",StudentId=5,Email="aksh@gmail.com",MobileNo="9898989898",Gender="MALE" });


foreach(Student s in std)
{
    Console.WriteLine(s);
}

Dictionary<string,Student> stud=new Dictionary<string, Student>();
stud.Add("dada",new Student() {Name="Akshay Gavhane",StudentId=1,Email="aksh@gmail.com",MobileNo="9898989898",Gender="MALE" });

Student stude = stud["dada"];
Console.WriteLine(stude);

Player p1= new Player("Sourav Ganguly",50, 300, 50000);
Player p2= new Player("Sachin Tendulkar",49, 350, 100000);
Player p3= new Player("Rahul Dravid",48, 250, 70000);

List<Player> indianPlayers=new List<Player>();
indianPlayers.Add(p1);
indianPlayers.Add(p2);
indianPlayers.Add(p3);

indianPlayers.Sort();

foreach( Player currentPlayer in indianPlayers){
  Console.WriteLine(currentPlayer);
}


MathEngine m=new MathEngine();
int result = m.Addition(10,20);
Console.WriteLine(result);
result = m.Subtraction(30,4);
Console.WriteLine(result);
result=m.Multiply(25,4);
Console.WriteLine(result);
