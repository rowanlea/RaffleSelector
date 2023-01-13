using Core;
using Core.Generators;
using FluentAssertions;
using NSubstitute;

namespace CoreTests
{
    public class RaffleSelectorTests
    {
        [Test]
        public void AcceptanceTest()
        {
            // Arrange
            INumberGenerator randomNumberGenerator = Substitute.For<INumberGenerator>();
            RaffleSelector raffleSelector = new(randomNumberGenerator);

            IEnumerable<string> listOfEmails = new List<string>() { "Nacho", "Rowan", "Bob", "Trish", "Roy" };
            int numberToDraw = 3;

            // Act
            HashSet<string> drawnEmails = raffleSelector.DrawEmails(listOfEmails, numberToDraw);

            // Assert
            drawnEmails.Count.Should().Be(numberToDraw);
            listOfEmails.Should().Contain(drawnEmails);
        }

        //[Test]
        //public void AcceptanceTest()
        //{
        //    // Arrange
        //    RaffleSelector raffleSelector = new();

        //    IEnumerable<string> listOfEmails = new List<string>() { "Nacho", "Nacho", "Bob", "Trish", "Roy" };
        //    int numberToDraw = 3;

        //    // Act
        //    List<string> drawnNames = raffleSelector.DrawEmails(listOfEmails, numberToDraw);

        //    // Assert
        //    Assert.That(drawnNames.Count, Is.EqualTo(3));
        //    Assert.That("", Is.EqualTo(""));
        //}
    }
}