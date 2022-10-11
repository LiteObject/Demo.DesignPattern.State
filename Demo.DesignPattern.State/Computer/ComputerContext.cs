using Demo.DesignPattern.State.Computer.Computer;
using Humanizer;

namespace Demo.DesignPattern.State.Computer
{
    /// <summary>
    /// This Computer class is the 'Context' that stores a reference to one of the concrete 
    /// state objects and delegates to it all state-specific work. The context communicates 
    /// with the state object via the state interface. The context exposes a setter for 
    /// passing it a new state object.
    /// </summary>
    public class ComputerContext
    {
        private IState state;

        // Instantiate the context with initial state
        public ComputerContext(IState state)
        {
            this.state = state;
        }

        // Gets or sets state
        public IState State
        {
            get
            {
                return state;
            }
            set
            {
                var prev = state.GetType().Name;
                state = value;
                Console.WriteLine("{0} \"{1}\" has been set to \"{2}\'", nameof(state).Humanize(LetterCasing.Sentence), prev, state.GetType().Name);
            }
        }

        public void PressPowerButton()
        {
            Console.WriteLine("{0} has been invoked", nameof(PressPowerButton));
            state.Handle(this);
        }
    }
}