using Demo.DesignPattern.State.Computer.Computer;

namespace Demo.DesignPattern.State.Computer
{
    public class Off : IState
    {
        public void Handle(ComputerContext context)
        {
            Console.WriteLine("Current state is {0}", nameof(Off));
            context.State = new On();
        }
    }
}
