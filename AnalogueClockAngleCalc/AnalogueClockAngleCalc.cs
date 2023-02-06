using System.Globalization;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ReizAssignment.Tests")]
namespace AnalogueClockAngleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isValidInput = false;
            string dateFormat = "HH:mm";


            while (!isValidInput)
            {
                Console.WriteLine("Enter the time in the format HH:MM");
                string dateString = Console.ReadLine();

                if (DateTime.TryParseExact(dateString, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateResult))
                {
                    int hour = dateResult.Hour;
                    int minute = dateResult.Minute;

                    Console.WriteLine("The angle between the hour and minute hands is {0} degrees", CalculateAngle.GetAngle(hour, minute));
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
            Console.ReadLine();
        }
    }
}