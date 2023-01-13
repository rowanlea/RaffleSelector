using Core.Generators;
using FluentAssertions;

namespace CoreTests.Generators
{
    internal class UniqueNumberGeneratorTests
    {
        [TestCase(3)]
        [TestCase(2)]
        [TestCase(4)]
        public void GenerateRandomNumbers_WhenGivenNumberToGet_GivesUsThatManyResults(int numberToGet)
        {
            // Arrange
            UniqueNumberGenerator randomNumberGenerator = new UniqueNumberGenerator();

            // Act
            int[] numbersGenerated = randomNumberGenerator.GenerateRandomNumbers(5, numberToGet);

            // Assert
            numbersGenerated.Count().Should().Be(numberToGet);
        }

        [Test]
        public void GenerateRandomNumbers_WhenMaxFiveAndNumberThree_GivesUsUniqueResults()
        {
            // Arrange
            UniqueNumberGenerator randomNumberGenerator = new UniqueNumberGenerator();

            // Act
            int[] numbersGenerated = randomNumberGenerator.GenerateRandomNumbers(5, 3);
            HashSet<int> uniquePositions = new HashSet<int>(numbersGenerated);

            // Assert
            uniquePositions.Count().Should().Be(3);
        }

        [Test]
        public void CatchErrors()
        {
            UniqueNumberGenerator randomNumberGenerator = new UniqueNumberGenerator();
            int[] numbersGenerated = randomNumberGenerator.GenerateRandomNumbers(5, 3);
            numbersGenerated.Count().Should().Be(3);

            Assert.Fail();
        }
    }
}
