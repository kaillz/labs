using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace ZiiLab5
{
    internal class MillerRabinTest
    {
        public static bool MillerRabin(BigInteger numberToTest, int numberOfTests)
        {
            if (numberToTest < 2 || numberToTest % 2 == 0)
            {
                return false;
            }

            if (numberToTest == 2 || numberToTest == 3)
            {
                return true;
            }

            BigInteger t = numberToTest - 1;
            int s = 0;

            while (t % 2 == 0)
            {
                t /= 2;
                s++;
            }

            for (int i = 0; i < numberOfTests; i++)
            {
                BigInteger randomNumber = RandomBI.RandomBi(2, numberToTest - 2);

                BigInteger x = BigInteger.ModPow(randomNumber, t, numberToTest);

                if (x == 1 || x == numberToTest - 1)
                {
                    continue;
                }

                for (int r = 1; r < s; r++)
                {
                    x = BigInteger.ModPow(x, 2, numberToTest);

                    if (x == 1)
                    {
                        return false;
                    }

                    if (x == numberToTest - 1)
                    {
                        break;
                    }
                }

                if (x != numberToTest - 1)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
