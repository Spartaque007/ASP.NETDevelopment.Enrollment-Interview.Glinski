using System;

namespace Gliski.Utils
{
    public class Math
    {
        public static int GetGCD(int number1, int number2)
        {
            if (number1 == 0 || number2 == 0)
            {
                throw new ArgumentException("one or both numbers zero");
            }

            if (number1 == number2 && number1 != 0)
            {
                return number1;
            }

            while (number1 != 0 && number2 != 0)
            {
                if (number1 > number2)
                {
                    number1 = number1 % number2;
                }
                else
                {
                    number2 = number2 % number1;
                }
            }

            return number1 + number2;
        }
    }
}
