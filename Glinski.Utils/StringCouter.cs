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
    }
}
