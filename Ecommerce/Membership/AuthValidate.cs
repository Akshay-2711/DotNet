namespace Membership;
public static class AuthValidate
{

    public static Boolean Validate(string email, string password)
    {

        Boolean status = false;
        if (email == "aksh@gmail.com" && password == "aksh123")
        {
            return true;
        }
        return status;
    }





    public static Boolean Register(string firstname, string lastname,
    string email, string location, string contactno)
    {

        bool status = false;
        try
        {
            User user1 = new User();
            user1.FirstName = firstname;
            user1.LastName = lastname;
            //user1.Email = email;
            //user1.ContactNo = contactno;
            //user1.Location = location;
            status= true;
        }
        catch(Exception e)
        {
            Console.WriteLine("Invalid User!!"+e);
        }
        return status;
    }

}
