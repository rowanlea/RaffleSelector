namespace Core
{
    public class CSVReader
    {
        public List<string> GetEmailAddressesFromCSV(string filepath)
        {
            List<string> entries = new List<string>();

            using (var reader = new StreamReader(filepath))
            {

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var email = line.Split(',').Last();
                    entries.Add(email.Replace("\"", String.Empty));
                }
            }
            entries.RemoveAt(0);
            return entries;
        }
    }
}
