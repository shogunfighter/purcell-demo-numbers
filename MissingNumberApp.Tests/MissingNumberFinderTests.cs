using MissingNumberApp.Services;
using Xunit;

namespace MissingNumberApp.Tests
{
    public class MissingNumberFinderTests
    {
        private readonly MissingNumberFinder _finder;

        public MissingNumberFinderTests()
        {
            _finder = new MissingNumberFinder();
        }

        [Fact]
        public void FindMissingNumber_WhenSingleNumberIsMissing_ReturnsMissingNumber()
        {
            // Arrange
            int[] numbers = { 0, 1, 3 };

            // Act
            int result = _finder.FindMissingNumber(numbers);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void FindMissingNumber_WhenMultipleNumbersAreMissing_ThrowsException()
        {
            // Arrange
            int[] numbers = { 0, 2, 4, 6 };

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => _finder.FindMissingNumber(numbers));
        }

        [Fact]
        public void FindMissingNumber_WhenNoNumbersAreMissing_ThrowsException()
        {
            // Arrange
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => _finder.FindMissingNumber(numbers));
        }

        [Fact]
        public void FindMissingNumber_WithDifferentRange_ReturnsCorrectMissingNumber()
        {
            // Arrange
            int[] numbers = { 0, 1, 2, 3, 4, 5, 7, 8, 9 };

            // Act
            int result = _finder.FindMissingNumber(numbers);

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void FindMissingNumber_WithEmptyArray_ThrowsException()
        {
            // Arrange
            int[] numbers = Array.Empty<int>();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => _finder.FindMissingNumber(numbers));
        }
    }
}