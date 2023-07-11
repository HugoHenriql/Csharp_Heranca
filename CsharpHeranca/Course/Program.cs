using System;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc =new BusinessAccount (8010, "Maria", 100.0, 500.0);

            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

            Console.WriteLine(account.Balance);

            //UPCASTING
             
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount (8010, "bob", 100.0, 500.0);
            Account acc3 = new SavingsAccount (8010, "Anna", 100.0, 500.0); 

            //DOWNCASTING   

            BusinessAccount acc4 = (BusinessAccount) acc2;
            acc4.Loan(100.0);

            if(acc3 is BusinessAccount){
                BusinessAccount acc5 = (BusinessAccount)acc3;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }
            if(acc3 is SavingsAccount){
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpadateBalance();
                Console.WriteLine("Update Balance !");

            }        
}
    }
}
