using CommandSystem.handlers;

namespace CommandSystem
{
    public abstract class UserView
    {
        protected List<CommandHandler> handlers = new List<CommandHandler>();

        protected void PrintMenu(CommandHandler handler)
        {
            foreach (var item in handler)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
        public abstract void Run();
    }
}
