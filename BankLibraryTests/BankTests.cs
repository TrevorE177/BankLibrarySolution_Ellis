using BankLibrary;
using System.Runtime.CompilerServices;

namespace BankLibraryTests
{
    [TestClass]
    public class BankTests
    {
        // Testing Bank Method

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void VerifyInvalidAccount()
        {
            string customer = "Customer";
            double balance = 10001;

            Bank b = new Bank(customer, balance);

            Assert.AreEqual(customer, b.Customer);
            Assert.AreEqual(balance, b.Balance);
        }

        [TestMethod]
        public void VerifyValidAccount()
        {
            string customer = "Customer";
            double balance = 7500;

            Bank b = new Bank(customer, balance);

            Assert.AreEqual(customer, b.Customer);
            Assert.AreEqual(balance, b.Balance);
        }

        // Testing Withdraw Method

        [TestMethod]
        public void Test_Withdraw()
        {
            string customer = "Customer";
            double balance = 100;
            double withdrawl = 50;

            Bank b = new Bank(customer, balance);

            Assert.AreEqual(balance - withdrawl, b.Withdraw(withdrawl));
        }

        [TestMethod]
        public void Test_WithdrawOver500()
        {
            string customer = "Customer";
            double balance = 1000;
            double withdrawl = 600;

            Bank b = new Bank(customer, balance);

            Assert.AreEqual(balance - 500, b.Withdraw(withdrawl));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_WithdrawLessThanOrZero()
        {
            string customer = "Customer";
            double balance = 100;
            double withdrawl = 0;

            Bank b = new Bank(customer, balance);

            Assert.AreEqual(balance - withdrawl, b.Withdraw(withdrawl));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_WithdrawOverBalance()
        {
            string customer = "Customer";
            double balance = 100;
            double withdrawl = 200;

            Bank b = new Bank(customer, balance);

            Assert.AreEqual(balance - withdrawl, b.Withdraw(withdrawl));
        }

        // Testing Deposit Method

        [TestMethod]
        public void Test_DepositMoreThanZero()
        {
            string customer = "Customer";
            double balance = 0;
            double deposit = 25;

            Bank b = new Bank(customer, balance);

            Assert.AreEqual(balance + deposit, b.Deposit(deposit));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_DepositZero()
        {
            string customer = "Customer";
            double balance = 0;
            double deposit = 0;

            Bank b = new Bank(customer, balance);

            Assert.AreEqual(balance + deposit, b.Deposit(deposit));            
        }
    }
}