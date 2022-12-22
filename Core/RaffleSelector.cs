using Core.Utils;

namespace Core
{
    public class RaffleSelector
    {
        public HashSet<string> DrawEmails(IEnumerable<string> listOfEmails, int numberToDraw)
        {
            HashSet<string> emailsSet = ListUtils.ConvertListToSet(listOfEmails);
            return emailsSet;
        }

    }
}