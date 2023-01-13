using Core.Generators;
using Core.Utils;

namespace Core
{
    public class RaffleSelector
    {
        private readonly IRandomNumberGenerator _randomNumberGenerator;

        public RaffleSelector() 
        {
            _randomNumberGenerator = new RandomNumberGenerator();
        }

        internal RaffleSelector(IRandomNumberGenerator randomNumberGenerator)
        {
            _randomNumberGenerator = randomNumberGenerator;
        }

        public HashSet<string> DrawEmails(IEnumerable<string> listOfEmails, int numberToDraw)
        {
            HashSet<string> uniqueEmails = ListUtils.MakeListUnique(listOfEmails);
            var selectedNumbers = _randomNumberGenerator.GenerateNumberOfUniquePositions(listOfEmails.Count(), numberToDraw);
            return uniqueEmails;
        }

    }
}