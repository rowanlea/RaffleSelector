namespace Core.Utils
{
    internal class ListUtils
    {
        internal static HashSet<string> ConvertListToSet(IEnumerable<string> listOfEmails)
        {
            HashSet<string> response = listOfEmails.ToHashSet();
            return response;
        }
    }
}
