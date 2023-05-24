using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ZiiLab5
{
    internal class RandomBI
    {
        public static BigInteger RandomBi(BigInteger min, BigInteger max)
        {
            var rng = new RNGCryptoServiceProvider();
            var data = new byte[max.ToByteArray().Length];
            BigInteger result;

            do
            {
                rng.GetBytes(data);
                result = new BigInteger(data);
            } while (result <= min || result >= max);

            return result;
        }
    }
}
