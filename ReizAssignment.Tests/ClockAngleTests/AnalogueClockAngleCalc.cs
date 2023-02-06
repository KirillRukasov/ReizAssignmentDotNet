using System.Globalization;
using Xunit;

namespace ReizAssignment.Tests.ClockAngleTests
{
    public class AnalogueClockAngleCalc
    {
        [Fact]
        public void GivenValidTime_WhenParseTime_ThenReturnsTrue()
        {
            // Arrange
            string dateFormat = "HH:mm";
            string dateString = "12:30";

            // Act
            bool isValidInput = DateTime.TryParseExact(dateString, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateResult);

            // Assert
            Assert.True(isValidInput);
        }

        [Fact]
        public void GivenInvalidSymbol_WhenParseTime_ThenReturnsFalse()
        {
            // Arrange
            string dateFormat = "HH:mm";
            string dateString = "12:3A";

            // Act
            bool isValidInput = DateTime.TryParseExact(dateString, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateResult);

            // Assert
            Assert.False(isValidInput);
        }

        [Fact]
        public void GivenInvalidTime_WhenParseTime_ThenReturnsFalse()
        {
            // Arrange
            string dateFormat = "HH:mm";
            string dateString = "25:30";

            // Act
            bool isValidInput = DateTime.TryParseExact(dateString, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateResult);

            // Assert
            Assert.False(isValidInput);
        }
    }
}
