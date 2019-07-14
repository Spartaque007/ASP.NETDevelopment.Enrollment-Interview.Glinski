using System.Numerics;

namespace Gliski.Utils
{
    public class Math
    {
        public static long GetGCDEuclidean(long number1, long number2)
        {
            if (number1 < 0)
            {
                number1 *= -1;
            }
            if (number2 < 0)
            {
                number2 *= -1;
            }
            if (number1 == 0)
            {
                return number2;
            }

            if (number2 == 0)
            {
                return number1;
            }

            if (number1 == number2 && number1 != 0)
            {
                return number1;
            }

            while (number1 != 0 && number2 != 0)
            {
                if (number1 > number2)
                {
                    number1 %= number2;
                }
                else
                {
                    number2  %= number1;
                }
            }
            return number1 + number2;
        }
        public static BigInteger GetGCDEuclidean(BigInteger number1, BigInteger number2)
        {
            if (number1 < 0)
            {
                number1 *= -1;
            }
            if (number2 < 0)
            {
                number2 *= -1;
            }
            if (number1 == 0)
            {
                return number2;
            }

            if (number2 == 0)
            {
                return number1;
            }

            if (number1 == number2 && number1 != 0)
            {
                return number1;
            }

            while (number1 != 0 && number2 != 0)
            {
                if (number1 > number2)
                {
                    number1%= number2;
                }
                else
                {
                    number2 %= number1;
                }
            }
            return number1 + number2;
        }
        public static long GetGCDBinary(long number1, long number2)
        {
            if (number1 < 0)
            {
                number1 *= -1;
            }
            if (number2 < 0)
            {
                number2 *= -1;
            }
            if (number1==number2)
            {
                return number1;
            }
            if (number1 == 0)
            {
                return number2;
            }

            if (number2 == 0)
            {
                return number1;
            }
            int k = 1;
            while (number1 % 2 == 0 && number2 % 2 == 0)
            {
                number1 /= 2;
                number2 /= 2;
                k *= 2;
            }
            while (number1 % 2 == 0)
            {
                number1 /= 2;
            }
            while (number2 % 2 == 0)
            {
                number2 /= 2;
            }
            number1 = number1 > number2 ? number1 - number2 : number2 - number1;
            return k * number1 / 2;
        }

    }
}

