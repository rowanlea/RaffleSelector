using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Security.Cryptography;

namespace Core.Generators
{
   
    public class CryptographicGenerator
    {
        public static int GetNumberBetween(int first, int second)
        {
            if (second == 0)
            {
                return 0;
            }
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] randomBytes = new byte[4];
            rng.GetBytes(randomBytes);
            uint converted = BitConverter.ToUInt32(randomBytes, 0);
            int randomNumber = (int) ((converted % second) + first);
            return randomNumber;
        }
    }
}
