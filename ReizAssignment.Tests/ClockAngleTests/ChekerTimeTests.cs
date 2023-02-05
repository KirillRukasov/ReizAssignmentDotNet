using AnalogueClockAngleCalc;
using Xunit;

namespace ReizAssignment.Tests.ClockAngleTests
{
    public class ChekerTimeTests
    {
        [Theory]
        [InlineData(0, 0, true)]
        [InlineData(23, 59, true)]
        [InlineData(24, 0, false)]
        [InlineData(0, 60, false)]
        [InlineData(-1, 0, false)]
        [InlineData(0, -1, false)]
        public void ChekerTime_TestIsTimeValid(int hour, int minute, bool expected)
        {
            // Act
            bool actual = CheckerTime.IsTimeValid(hour, minute);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("12:30", true)]
        [InlineData("00:00", true)]
        [InlineData("23:59", true)]
        [InlineData("12:00:00", false)]
        [InlineData("12:", false)]
        [InlineData("12", false)]
        [InlineData("12:3", false)]
        [InlineData("HH:MM", false)]
        [InlineData("some_letters", false)]
        public void IsInputValid_WithValidData_ReturnsExpectedResult(string time, bool expectedResult)
        {
            // Act
            var result = CheckerTime.IsInputValid(time);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
