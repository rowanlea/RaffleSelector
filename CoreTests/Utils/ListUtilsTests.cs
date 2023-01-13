using Core.Utils;
using FluentAssertions;

namespace CoreTests.Utils
{
    internal class ListUtilsTests
    {
        [Test]
        public void ConvertListToSet_WhenGivenListOfUniqueNames_ReturnsHashSetOfSameLength()
        {
            // Arrange
            var listNames = new List<string> { "Rowan", "Nacho", "Kevin" };

            // Act
            var setNames = ListUtils.MakeListUnique(listNames);

            // Assert
            setNames.Should().Contain(listNames);
        }

        [Test]
        public void ConvertListToSet_WhenGivenListWithDuplicates_ReturnsHashSetWithLessNames()
        {
            // Arrange
            var listNames = new List<string> { "Rowan", "Rowan", "Kevin" };

            // Act
            var setNames = ListUtils.MakeListUnique(listNames);

            // Assert
            setNames.Count().Should().Be(2);
        }
    }
}
