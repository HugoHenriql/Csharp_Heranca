namespace Course.Entities
{
    class SavingsAccount : Account
    {
       public double interestRate { get; set; }

       public SavingsAccount()
       {
            public SavingsAccount(int number, string holder, double balance, double interestRate) : base(Number, Holder, Balance)
            {
                InterestRate = interestRate;
            }

            public void UpdateBalance()
            {
                Balance += Balance * InterestRate;
            }

            public override void  Withdraw(double mount){
                Balance -= amount;
            }
       }
    }