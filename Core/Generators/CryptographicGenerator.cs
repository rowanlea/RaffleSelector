using System.Security.Cryptography;

namespace Core.Generators
{

    public class CryptographicGenerator
    {
        public static int GetNumberBetween(int first, int second)
        {
            if (first == second)
            {
                return first;
            }

            return RandomNumberGenerator.GetInt32(first, second + 1);
        }
    }
}
