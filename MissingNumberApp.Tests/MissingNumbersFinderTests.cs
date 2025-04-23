using MissingNumberApp.Services;
using Xunit;

namespace MissingNumberApp.Tests
{
    public class MissingNumbersFinderTests
    {
        private readonly MissingNumbersFinder _finder;
        
        public MissingNumbersFinderTests()
        {
            _finder = new MissingNumbersFinder();
        }

        [Fact]
        public void FindMissingNumbers_WithEmptyArray_ThrowsException()
        {
            // Arrange
            var emptyArray = Array.Empty<int>();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => _finder.FindMissingNumbers(emptyArray));
        }

        [Fact]
        public void FindMissingNumbers_WithNullArray_ThrowsException()
        {
            // Arrange
            int[] nullArray = null;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => _finder.FindMissingNumbers(nullArray));
        }

        [Fact]
        public void FindMissingNumbers_WithNoMissingNumbers_ReturnsEmptyList()
        {
            // Arrange
            var numbers = new int[] { 0, 1, 2, 3 };

            // Act
            var result = _finder.FindMissingNumbers(numbers);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void FindMissingNumbers_WithMissingNumbers_ReturnsCorrectList()
        {
            // Arrange
            var numbers = new int[] { 0, 2, 3, 5 };
            var expected = new List<int> { 1, 4 };

            // Act
            var result = _finder.FindMissingNumbers(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void FindMissingNumbers_WithGap_ReturnsAllMissingNumbers()
        {
            // Arrange
            var numbers = new int[] { 0, 5 };
            var expected = new List<int> { 1, 2, 3, 4 };

            // Act
            var result = _finder.FindMissingNumbers(numbers);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}