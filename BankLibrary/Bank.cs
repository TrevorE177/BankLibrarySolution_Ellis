namespace BankLibrary
{
    public class Bank
    {
        private readonly string _customer;
        private double _balance;

        private Bank()
        {

        }

        public Bank(string customer, double balance)    // CC 3
        {
            if (balance > 10000 || balance < 0)     // i changed this to "<" because I wanted to >:(
                throw new ArgumentOutOfRangeException("amount");
            _customer = customer;
            _balance = balance;
        }

        public string Customer
        {
            get { return _customer; }
        }

        public double Balance
        {
            get { return _balance; }
        }

        public double Withdraw(double amount)   // CC 5
        {
            if (amount > 500)
                amount = 500;

            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            if (amount > _balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            // deleted "if (amount < 0)" because it was redundant.  Also, when I tried to
            // write a test for it, the exception wouldn't trigger (?)

            _balance -= amount;
            return _balance;
        }

        public double Deposit(double amount)    // CC 2
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            _balance += amount;
            return _balance;
        }
    }
}