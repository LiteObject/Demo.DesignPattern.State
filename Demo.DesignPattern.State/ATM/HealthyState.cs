namespace Demo.DesignPattern.State.ATM
{
    public class HealthyState : IState
    {
        private Account atm;

        public HealthyState(Account atm)
        {
            this.atm = atm;
        }

        public void Deposit(double amount)
        {
            atm.CurrentBalance += amount;
            Console.WriteLine("Successfully added ${0}. Current balance is ${1}.", amount, atm.CurrentBalance);
        }

        public void Withdraw(double amount)
        {
            var currentCashBalance = atm.CurrentBalance;

            if (amount > currentCashBalance)
            {
                Console.WriteLine("Amount ${0} cannot be withdrawn due to insufficient fund. Current balace is ${1}.", amount, currentCashBalance);
                return;
            }

            atm.CurrentBalance -= amount;
            Console.WriteLine("Successfully withdrawn ${0}. Current balacen is ${1}.", amount, atm.CurrentBalance);
        }
    }
}
