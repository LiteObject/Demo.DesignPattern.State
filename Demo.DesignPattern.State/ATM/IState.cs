namespace Demo.DesignPattern.State.ATM
{
    public interface IState
    {
        public void Withdraw(double amount);
        public void Deposit(double amount);
    }
}
