using Demo.DesignPattern.State.ATM;

namespace Demo.DesignPattern.State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ComputerContext computer = new(new Off());
            computer.PressPowerButton(); */

            var account = new Account();
            account.Deposit(100);
            account.Withdraw(50);
            account.Withdraw(30);
            account.Withdraw(30);
            account.Withdraw(20);
        }
    }
}