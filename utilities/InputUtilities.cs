
namespace CommandSystem.utilities
{
    public static class InputUtilities
    {
        private const string TryAgainMessage = "Try again!";

        /// <summary>
        /// generic function to display a message and read user input
        /// </summary>
        /// <param name="message">message to log</param>
        /// <returns>user input</returns>
        public static string? ReadInput(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine();
            return input;
        }
        public static int ReadInteger(string message)
        {
            Console.Write(message);
            int i;

            while (!int.TryParse(Console.ReadLine(), out i))
            {
                OutputUtilities.WriteBadLine(TryAgainMessage);
            }

            return i;
        }
        public static decimal? ReadDecimal(string message)
        {
            Console.Write(message);
            decimal d;

            if (decimal.TryParse(Console.ReadLine(),out d))
            {
                return d;
            }
            return null;
        }

        public static DateTime? ReadDate(string message)
        {
            Console.Write(message);
            DateTime d;

            if(DateTime.TryParse(Console.ReadLine(),out d))
            {
                return d;
            }
            return null;
        }
    }
}
