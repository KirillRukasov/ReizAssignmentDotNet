using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ReizAssignment.Tests")]
namespace AnalogueClockAngleCalc
{
    internal class CalculateAngle
    {
        public static int GetAngle(int hour, int minute)
        {
            int hourAngle = (hour * 30) + (minute / 2);
            int minuteAngle = minute * 6;
            int angle = Math.Abs(hourAngle - minuteAngle);
            return Math.Min(Math.Abs(angle), Math.Abs(360 - angle));
        }
    }
}