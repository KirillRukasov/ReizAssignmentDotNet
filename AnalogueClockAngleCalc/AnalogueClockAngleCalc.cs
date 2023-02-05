namespace AnalogueClockAngleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isValidInput = false;

            while (!isValidInput)
            {
                Console.WriteLine("Enter the time in the format HH:MM");
                string time = Console.ReadLine();

                if (CheckerTime.IsInputValid(time))
                {
                    string[] timeArray = time.Split(':');
                    int hour = Convert.ToInt32(timeArray[0]);
                    int minute = Convert.ToInt32(timeArray[1]);

                    if (CheckerTime.IsTimeValid(hour, minute))
                    {
                        Console.WriteLine("The angle between the hour and minute hands is {0} degrees", CalculateAngle.GetAngle(hour, minute));
                        isValidInput = true;
                    }
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