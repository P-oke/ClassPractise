using System.Globalization;
using System;

namespace AnotherAssembly
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccountHolder bankAccountHolder = new BankAccountHolder();
            bankAccountHolder.debitAmount = 700;
            bankAccountHolder.creditAmount = 500;
            bankAccountHolder.showAccountName();
            bankAccountHolder.AmountToCredit();
            bankAccountHolder.AmountToDebit();


        }
    }
    public class BankAccount
    {
        protected string accountName;

        protected int userId;

        public void AmountToDebit()
        {
            Console.WriteLine("Your Bank gives you access to debit your account");
        }

        public void AmountToCredit()
        {
            Console.WriteLine("Your Bank gives you access to credit your account");
        }


    }

    public class BankAccountHolder : BankAccount
    {
        private double availableBalance = 1000;

        public double creditAmount;

        public double debitAmount;

        private string customerAccountName;

        public void SetMyId()
        {
            BankAccountHolder bankAccountHolder = new BankAccountHolder();
            bankAccountHolder.userId = 7998;

        }

        public void showAccountName()
        {
            BankAccountHolder bankAccountHolder = new BankAccountHolder();
            customerAccountName = bankAccountHolder.accountName = "Ayomikun Paul";
        }

        public new void AmountToCredit()
        {
            availableBalance = availableBalance + creditAmount;
            Console.WriteLine($"Dear {customerAccountName}, you have credited {creditAmount} to your account, your available balance is {availableBalance}");
        }

        public new void AmountToDebit()
        {
            availableBalance = availableBalance - debitAmount;
            Console.WriteLine($"Dear {customerAccountName}, you have debited {debitAmount} from your account, your available balance is {availableBalance}");

        }




    }

}
