
using Membership;
Console.WriteLine("Enter your email");
string mail=Console.ReadLine();

Console.WriteLine("Enter Your password");
string pass=Console.ReadLine();

if(AuthValidate.Validate(mail,pass))
{
    Console.WriteLine("Welcome!!!");
}
else{
Console.WriteLine("Invalid User!");
}

AuthValidate.Register("aksh","Gavhane","aksh.ak@gmail.com","Saishraddha","9898989898");
