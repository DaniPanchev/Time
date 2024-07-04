namespace Time
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string output = ConvertTo24HourFormat(input);
            Console.WriteLine(output);
        }

        static string ConvertTo24HourFormat(string time12Hour)
        {
            string period = time12Hour.Substring(time12Hour.Length - 2);
            string time = time12Hour.Substring(0, time12Hour.Length - 2);
            string[] timeParts = time.Split(':');
            int hour = int.Parse(timeParts[0]);
            int minute = int.Parse(timeParts[1]);
            int second = int.Parse(timeParts[2]);
            if (period == "PM" && hour != 12)
            {
                hour += 12;
            }
            else if (period == "AM" && hour == 12)
            {
                hour = 0;
            }
            return $"{hour:D2}:{minute:D2}:{second:D2}";
        }
    }
}

