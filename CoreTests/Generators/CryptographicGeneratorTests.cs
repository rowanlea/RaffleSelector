using Core.Generators;
using FluentAssertions;

namespace CoreTests.Generators
{
    internal class CryptographicGeneratorTests
    {
        [TestCase(1, 10)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void GetNumberBetween_WhenFirstAndSecondGiven_ResultBetweenTheTwoNumbers(int firstNumber, int secondNumber)
        {
            // Check 1000 times to make reasonably sure all numbers given are in the range we have specified
            for (int i = 0; i < 1000; i++)
            {
                // Arrange + Act
                int result = CryptographicGenerator.GetNumberBetween(firstNumber, secondNumber);

                // Assert
                result.Should().BeInRange(firstNumber, secondNumber);
            }
        }

        [Test]
        public void GetNumberBetween_WhenRun1000Times_ResultsDistributedEvenly()
        {
            // Arrange
            Dictionary<int, int> frequencies = new Dictionary<int, int>();

            // Act
            // Generate numbers 1000 times to get a reasonable data set to test with
            for (int i = 0; i < 1000; i++)
            {
                int result = CryptographicGenerator.GetNumberBetween(1, 10);
                AddOrIncrementResult(frequencies, result);
            }

            // Assert
            // Check each number has been found at least 50 times out of 1000.
            // On average it should be generated 100 times, but because it's random we will use 50 as a reasonable count.
            for (int i = 1; i <= 10; i++)
            {
                frequencies[i].Should().BeGreaterThan(50);
            }
        }

        private static void AddOrIncrementResult(Dictionary<int, int> frequencies, int result)
        {
            if (frequencies.TryGetValue(result, out _))
            {
                frequencies[result]++;
            }
            else
            {
                frequencies.Add(result, 1);
            }
        }
    }
}
