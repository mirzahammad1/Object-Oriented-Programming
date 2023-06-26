// See https://aka.ms/new-console-template for more information
namespace BankingSystem
{
    abstract class BankAccount
    {
        public string AccountNumber;
        public double Balance;
        public string OwnerName; 

        public BankAccount(string accountNumber, double balance, string ownerName)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            OwnerName = ownerName;
        }

        public abstract void Display();
    }

    class SavingsAccount : BankAccount
    {
        public double InterestRate;

        public SavingsAccount(string accountNumber, double balance, string ownerName, double interestRate)
            : base(accountNumber, balance, ownerName)
        {
            InterestRate = interestRate;
        }

        public void CalculateInterest()
        {
            Balance += Balance * InterestRate;
        }
        public override void Display()
        {
            Console.WriteLine("Account Number: {0}", AccountNumber);
            Console.WriteLine("Owner Name: {0}", OwnerName);
            Console.WriteLine("Balance: {0}", Balance);
        }
    }

    class CheckingAccount : BankAccount
    {
        public CheckingAccount(string accountNumber, double balance, string ownerName)
            : base(accountNumber, balance, ownerName)
        {

        }

        public override void Display()
        {
            Console.WriteLine("Account Number: {0}", AccountNumber);
            Console.WriteLine("Owner Name: {0}", OwnerName);
            Console.WriteLine("Balance: {0}", Balance);
        }
    }

    class InvestmentAccount : BankAccount
    {
        public InvestmentAccount(string accountNumber, double balance, string ownerName)
            : base(accountNumber, balance, ownerName)
        {
        }

        public void BuyStock(string symbol, int quantity, double price)
        {
            if (Balance < price * quantity)
            {
                throw new ArgumentOutOfRangeException("quantity");
            }

            Balance -= price * quantity;
        }
        public override void Display()
        {
            Console.WriteLine("Account Number: {0}", AccountNumber);
            Console.WriteLine("Owner Name: {0}", OwnerName);
            Console.WriteLine("Balance: {0}", Balance);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Account Number");
            string ACCOUNT = Console.ReadLine();
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Checking Account");
            SavingsAccount savingsAccount = new SavingsAccount(ACCOUNT, 1000, name, 0.08);
            savingsAccount.Display();
            savingsAccount.CalculateInterest();
            savingsAccount.Display();

            Console.WriteLine();
            Console.WriteLine("Checking Account");
            CheckingAccount checkingAccount = new CheckingAccount(ACCOUNT, 1000, name);
            checkingAccount.Display();

            Console.WriteLine();
            Console.WriteLine("Investment Account");
            InvestmentAccount investmentAccount = new InvestmentAccount(ACCOUNT, 10000, name);
            investmentAccount.BuyStock("GOOGLE", 500, 9);
            investmentAccount.Display();
        }
    }
}