using Core;
using FluentAssertions;

namespace CoreTests
{
    public class RaffleSelectorTests
    {
        [Test]
        public void AcceptanceTest()
        {
            // Arrange
            RaffleSelector raffleSelector = new();

            IEnumerable<string> listOfEmails = new List<string>() { "Nacho", "Rowan", "Bob", "Trish", "Roy" };
            int numberToDraw = 3;

            // Act
            HashSet<string> drawnEmails = raffleSelector.DrawEmails(listOfEmails, numberToDraw);

            // Assert
            drawnEmails.Count.Should().Be(3);
            drawnEmails.Should().Contain("Nacho");

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