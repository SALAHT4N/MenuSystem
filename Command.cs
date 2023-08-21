namespace Airport_Ticket_Booking.ConsoleApp.commands
{
    public abstract class Command
    {
        protected string commandName; 
        public Command(string name) 
        {
            commandName = name;
        }
        public override string ToString() => commandName;
        public abstract void Execute();
    }
}
