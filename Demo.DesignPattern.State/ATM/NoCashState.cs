namespace Demo.DesignPattern.State.ATM
{
    public class NoCashState : IState
    {
        private Account atm;

        public NoCashState(Account atm)
        {
            this.atm = atm;
        }

        public void Deposit(double amount)
        {
            atm.CurrentBalance += amount;
            atm.CurrentState = new HealthyState(atm);
            Console.WriteLine("Successfully added ${0}. Current balance is ${1}.", amount, atm.CurrentBalance);
        }

        public void Withdraw(double amount)
        {
            Console.WriteLine("Unable to withdraw ${0}. No cash available.", amount);
        }
    }
}
