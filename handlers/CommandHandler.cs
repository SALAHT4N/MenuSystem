
namespace CommandSystem.handlers
{
    public class CommandHandler
    {
        private int _id = 1;
        private Dictionary<int, Command> mappings;
        public CommandHandler()
        {
            mappings = new();
        }
        public void AddCommand(Command action)
        {
            mappings.Add(_id++, action);
        }
        public IEnumerator<KeyValuePair<int, Command>> GetEnumerator()
        {
            foreach(var item in mappings)
            {
                yield return item;
            }
        }
        public bool ProcessCommand(int command)
        {
            if (!mappings.ContainsKey(command))
            {
                return false;
            }
            mappings[command].Execute();
            return true;
        }
    }
}
