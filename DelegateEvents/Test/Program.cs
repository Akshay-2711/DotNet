using Governance;
using Banking;

Account acct=new Account(1000);
Bankmanager bmanager=new Bankmanager();
Government gvt=new Government();
TaxOperations itoperation=new TaxOperations(gvt.DeductIncomeTax);
TaxOperations seroperation=new TaxOperations(gvt.DeductServiceTax);
TaxOperations profoperation=new TaxOperations(gvt.DeductProfessionalTax);
Checker bloacct =new Checker(bmanager.BlockAccount);
Checker sendemail =new Checker(bmanager.Email);
Checker sendsms =new Checker(bmanager.SendSMS);

itoperation();
seroperation();
profoperation();


acct.overbalance+=itoperation;
acct.overbalance+=seroperation;
acct.overbalance+=profoperation;

bloacct();
sendemail();
sendsms();

acct.underbalance+=bloacct;
acct.underbalance+=sendemail;
acct.underbalance+=sendsms;
Console.WriteLine("Enter Amount to be deposited");
double amount=double.Parse(Console.ReadLine());
acct.Deposit(amount);

Console.WriteLine("Before Tax processing");
Console.WriteLine(acct);

//performing action
Console.WriteLine("After Tax processing");
acct.TaxProcess();
//Console.WriteLine(acct);

Console.WriteLine("After Monitoring ");
acct.MonitorBalance();
//Console.WriteLine(acct);
