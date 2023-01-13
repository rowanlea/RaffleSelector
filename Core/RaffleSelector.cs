using Core.Generators;
using Core.Utils;

namespace Core
{
    public class RaffleSelector
    {
        private readonly INumberGenerator _randomNumberGenerator;

        public RaffleSelector() 
        {
            _randomNumberGenerator = new UniqueNumberGenerator();
        }

        internal RaffleSelector(INumberGenerator randomNumberGenerator)
        {
            _randomNumberGenerator = randomNumberGenerator;
        }

        public HashSet<string> DrawEmails(IEnumerable<string> listOfEmails, int numberToDraw)
        {
            HashSet<string> uniqueEmails = ListUtils.MakeListUnique(listOfEmails);
            var selectedNumbers = _randomNumberGenerator.GenerateRandomNumbers(listOfEmails.Count(), numberToDraw);
            return uniqueEmails;
        }

    }
}