namespace Banking;

public class Account{
    private float balance=2000;

    public Account(float bal)
    {
        this.balance=bal;
    }

    public float Balance{
        get{return this.balance;}
        set{this.balance=value;}
    }

    public void Withdraw(float amount){
        if(amount<=0){
            throw new Exception("Amount to be withdrawn cant be 0");
        }
         this.balance-=amount;

    }

    public void Deposit(float amount)
    {
        this.balance+=amount;
    }












}