
using Banking;

Account acct= new Account(5000);
acct.Deposit(4000);
acct.Balance=10000;
float currbalance=acct.Balance;

Console.WriteLine("currbalance: {0}",currbalance);
