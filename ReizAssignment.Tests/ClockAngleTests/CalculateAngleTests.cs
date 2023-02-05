using AnalogueClockAngleCalc;
using Xunit;

namespace ReizAssignment.Tests.ClockAngleTests
{
    public class CalculateAngleTests
    {
        [Theory]
        [InlineData(12, 0, 0)]
        [InlineData(6, 0, 180)]
        [InlineData(3, 0, 90)]
        [InlineData(15, 0, 90)]
        [InlineData(12, 30, 165)]
        public void TestGetAngle(int hour, int minute, int expectedAngle)
        {
            // Act
            int actualAngle = CalculateAngle.GetAngle(hour, minute);

            // Assert
            Assert.Equal(expectedAngle, actualAngle);
        }
    }
}