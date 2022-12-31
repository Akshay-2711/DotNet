

//namespace Membership;

public class User
{
    // private string firstname;
    // private string lastname;
   /*  private string location;
    private string email;
    private string contactno; */
    public User():this("aksh","gavhane")
    {
        /* this.firstname = "Aksh";
        this.lastname = "CDAC";
        this.location="Pune";
        this.contactno="7878777787";
        this.email="asldjlksajdkj"; */
    }

    public User(string firstname, string lastname)
    {
        this.FirstName = firstname;
        this.LastName = lastname; 
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    /* public string Location{get;set;}
    public string Email{get;set;}

    public string ContactNo{get;set;} */




}