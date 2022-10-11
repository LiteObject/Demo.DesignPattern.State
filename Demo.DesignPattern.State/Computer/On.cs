using Demo.DesignPattern.State.Computer.Computer;

namespace Demo.DesignPattern.State.Computer
{
    public class On : IState
    {
        public void Handle(ComputerContext context)
        {
            Console.WriteLine("Current state is {0}", nameof(On));
            context.State = new Off();
        }
    }
}
