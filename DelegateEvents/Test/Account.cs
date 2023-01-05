namespace Banking;
using Governance;

public class Account{

    public event TaxOperations overbalance;
    public event Checker underbalance;

    public double Balance{get;set;}

    public Account(double balance)
    {
        Balance = balance;
    }

    public void WithDraw(double amount)
    {   

        this.Balance-=amount;
    }
    public void Deposit(double amount)
    {
        this.Balance+=amount;
    }

    public override string ToString()
    {
        return base.ToString() + "Balance:"+this.Balance;
    }

    public void TaxProcess(){

        if(this.Balance>=250000){
            overbalance();
        }
        
        else{
            Console.WriteLine("Balance:"+this.Balance+" NO Tax applied");
        }
    }

    public void MonitorBalance(){
         if(this.Balance<5000){
            underbalance();
        }
    }


}