using Core;

namespace TemporaryUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CSVReader reader = new CSVReader();
            var addresses = reader.GetEmailAddressesFromCSV(@"C:\Raffle\Jetbrains Raffle.csv");

            RandomSelector selector = new RandomSelector();
            var randomlySelected = selector.GetNumberOfRandomEmails(2, addresses);

            Console.WriteLine("Raffle Winners:");
            foreach (var address in randomlySelected)
            {
                Console.WriteLine(address);
            }
            Console.ReadKey();
        }
    }
}