namespace Core
{
    public class RandomSelector
    {
        public List<string> GetNumberOfRandomEmails(int number, List<string> emails)
        {
            List<string> randomEmails = new List<string>();
            Random _rand = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < number; i++)
            {
                var selector = _rand.Next(1, emails.Count);
                var selectedEmail = emails.ElementAt(selector - 1);
                if (!randomEmails.Contains(selectedEmail))
                {
                    randomEmails.Add(selectedEmail);
                }
            }
            return randomEmails;
        }
    }
}