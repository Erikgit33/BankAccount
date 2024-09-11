namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount();
            BankAccount account2 = new BankAccount();

            account1.Deposit(100);
            account2.Deposit(40);
            Console.WriteLine();

            Console.WriteLine("Account1 deposits 100");
            Console.WriteLine("Account2 deposits 40");
            Console.WriteLine();

            Console.WriteLine("Account 1: " + account1.GetBalance());
            Console.WriteLine("Account 2: " + account2.GetBalance());

            account1.Withdraw(80);
            account2.Deposit(80);
            Console.WriteLine();

            Console.WriteLine("Account1 withdraws 80");
            Console.WriteLine("Account2 deposts 80");
            Console.WriteLine();

            Console.WriteLine("Account 1: " + account1.GetBalance());
            Console.WriteLine("Account 2: " + account2.GetBalance());

            account1.Withdraw(2500);
            account2.Withdraw(50);
            Console.WriteLine();

            Console.WriteLine("Account1 withdraws 2500");
            Console.WriteLine("Account2 withdraws 50");
            Console.WriteLine();

            Console.WriteLine("Account 1: " + account1.GetBalance());
            Console.WriteLine("Account 2: " + account2.GetBalance());
        }
    }
}
