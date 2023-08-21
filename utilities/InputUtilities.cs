using Airport_Ticket_Booking.DomainLayer.enums;

namespace Airport_Ticket_Booking.ConsoleApp.utilities
{
    public static class InputUtilities
    {
        private const string TryAgainMessage = "Try again!";
        /// <summary>
        /// List flight classes for user to select
        /// </summary>
        /// <returns>the selected class</returns>
        public static FlightType ReadClass()
        {
            Console.WriteLine($"{(int)FlightType.Economy}: Economy.");
            Console.WriteLine($"{(int)FlightType.Business}: Business.");
            Console.WriteLine($"{(int)FlightType.FirstClass}: FlightClass.");
            
            int choice = ReadInteger("Choose a class: ");
            return (FlightType)choice;
        }

        public static FlightType? ReadClassOptional()
        {
            Console.WriteLine($"{(int)FlightType.Economy}: Economy.");
            Console.WriteLine($"{(int)FlightType.Business}: Business.");
            Console.WriteLine($"{(int)FlightType.FirstClass}: FlightClass.");
            Console.WriteLine($"{0}: Ignore.");

            FlightType? flightType;
            int choice = ReadInteger("Choose a class: ");
            flightType = (choice == 0) ? null : (FlightType)choice;
            return flightType;
        }
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
