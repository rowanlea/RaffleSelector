using Core.Generators;
using FluentAssertions;

namespace CoreTests.Generators
{
    internal class RandomNumberGeneratorTests
    {
        [TestCase(3)]
        [TestCase(2)]
        [TestCase(4)]
        public void GenerateNumberOfUniquePositions_WhenGivenNumberToGet_GivesUsThatManyResults(int numberToGet)
        {
            RandomNumberGenerator randomNumberGenerator = new RandomNumberGenerator();
            int[] numbersGenerated = randomNumberGenerator.GenerateNumberOfUniquePositions(5, numberToGet);
            numbersGenerated.Count().Should().Be(numberToGet);
        }

        [Test]
        public void GenerateNumberOfUniquePositions_WhenMaxFiveAndNumberThree_GivesUsUniqueResults()
        {
            RandomNumberGenerator randomNumberGenerator = new RandomNumberGenerator();
            int[] numbersGenerated = randomNumberGenerator.GenerateNumberOfUniquePositions(5, 3);

            HashSet<int> uniquePositions = new HashSet<int>(numbersGenerated);
            uniquePositions.Count().Should().Be(3);
        }

        [Test]
        public void CatchErrors()
        {
            RandomNumberGenerator randomNumberGenerator = new RandomNumberGenerator();
            int[] numbersGenerated = randomNumberGenerator.GenerateNumberOfUniquePositions(5, 3);
            numbersGenerated.Count().Should().Be(3);
        }
    }
}
