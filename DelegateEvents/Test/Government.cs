namespace Governance;

public delegate void TaxOperations();
public class Government
{


    public void DeductIncomeTax()
    {
        Console.WriteLine("15% Income tax has been deducted from your account");
    }

    public void DeductServiceTax()
    {
        Console.WriteLine("10% Service Tax has been deducted from your account");
    }

    public void DeductProfessionalTax()
    {
        Console.WriteLine("12% Professional Tax has been deducted from your account");
    }






}