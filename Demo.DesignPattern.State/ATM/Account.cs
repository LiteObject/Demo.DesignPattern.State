namespace Demo.DesignPattern.State.ATM
{
    /// <summary>
    /// Context: Defines an interface to client to interact. It maintains references 
    /// to concrete state object which may be used to define current state of object.
    /// </summary>
    public class Account
    {
        public Account()
        {
            CurrentState = new NoCashState(this);
        }

        public IState CurrentState { get; set; }

        public double CurrentBalance { get; set; }

        public void Deposit(double amount)
        {
            CurrentState.Deposit(amount);
        }

        public void Withdraw(double amount)
        {
            CurrentState.Withdraw(amount);
        }
    }
}
