using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

[assembly: InternalsVisibleTo("ReizAssignment.Tests")]
namespace AnalogueClockAngleCalc
{
    internal class CheckerTime
    {
        public static bool IsTimeValid(int hour, int minute)
        {
            if (hour < 0 || hour > 23)
            {
                Console.WriteLine("The hour must be between 0 and 23");
                return false;
            }
            if (minute < 0 || minute > 59)
            {
                Console.WriteLine("The minute must be between 0 and 59");
                return false;
            }
            return true;
        }
        public static bool IsInputValid(string time)
        {
            if (!Regex.IsMatch(time, @"^\d{2}:\d{2}$"))
            {
                return false;
            }
            return true;
        }
    }
}
