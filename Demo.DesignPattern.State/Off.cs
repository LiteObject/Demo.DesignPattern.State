namespace Demo.DesignPattern.State
{
    public class Off : IState
    {
        public void Handle(Computer context)
        {
            Console.WriteLine("Current state is {0}", nameof(Off));
            context.State = new On();
        }
    }
}
