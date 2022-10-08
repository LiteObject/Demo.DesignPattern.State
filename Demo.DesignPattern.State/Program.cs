namespace Demo.DesignPattern.State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new(new Off());
            computer.PressPowerButton();
        }
    }
}