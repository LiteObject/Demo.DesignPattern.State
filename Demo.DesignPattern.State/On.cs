namespace Demo.DesignPattern.State
{
    public class On : IState
    {
        public void Handle(Computer context)
        {
            Console.WriteLine("Current state is {0}", nameof(On));
            context.State = new Off();
        }
    }
}
