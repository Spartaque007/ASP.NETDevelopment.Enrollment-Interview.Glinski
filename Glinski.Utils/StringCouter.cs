using System;

namespace Gliski.Utils
{
    public class StringCouter
    {
        public static int CountOfVowels(string text)
        {
            Char[] letters = new char[] { 'a', 'e', 'i', 'o', 'u' };
            int counter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsLetter(text[i]))
                {
                    for (int j = 0; j < letters.Length; j++)
                    {

                        if (text[i].Equals(letters[j]))
                        {
                            counter++;
                        }
                    }
                }
            }
            return counter;
        }

        public static string[] OrderStringsByLengthBubble(string[] array)
        {
            if (array.Length < 2)
            {
                return array;
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i]==null)
                {
                    throw new NullReferenceException($"{i} element of the array is null");
                }
                if (array[i].Length < array[i - 1].Length)
                {
                    int k = i;
                    while (k > 0 && array[k].Length < array[k - 1].Length)
                    {
                        string tmp = array[k];
                        array[k] = array[k - 1];
                        array[k - 1] = tmp;
                        k--;
                    }
                }
            }
            return array;
        }
    }
}
