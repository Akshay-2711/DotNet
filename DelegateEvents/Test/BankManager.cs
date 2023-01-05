namespace Banking;

public delegate void Checker();
public class Bankmanager{


    public void BlockAccount(){
        Console.WriteLine("This account is blocked");
    }
    public void Email(){
        Console.WriteLine("Email has been sent to your registered email id");
    }

    public void SendSMS(){
         Console.WriteLine("SMS has been sent to your registered mobile no");
    }

}