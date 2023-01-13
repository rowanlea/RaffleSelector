namespace Core.Utils
{
    internal class ListUtils
    {
        internal static HashSet<string> MakeListUnique(IEnumerable<string> listOfEmails)
        {
            HashSet<string> response = listOfEmails.ToHashSet();
            return response;
        }
    }
}
