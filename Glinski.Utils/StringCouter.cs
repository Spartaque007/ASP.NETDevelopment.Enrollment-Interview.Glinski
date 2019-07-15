using System;
using System.Collections;
using System.Collections.Generic;

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
            return BubbleSort(array, new StringLengthComparator());

        }
        public static string[] BubbleSort(string[] array, IComparer<string> comparer)
        {
            if (array.Length < 2)
            {
                return array;
            }

            for (int i = 1; i < array.Length; i++)
            {
                int a = comparer.Compare(array[i], array[i - 1]);
                if (a < 0)
                {
                    int k = i;
                    while (k > 0 && comparer.Compare(array[k], array[k - 1]) < 0)
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

        public static string[] OrderStringsByLengthMerge(string[] array)
        {
            return MergeSort(array, new StringLengthComparator());

        }

        public static string[] MergeSort(string[] array, IComparer<string> comparer)
        {
            if (array.Length < 2)
            {
                return array;
            }
            else
            {
                int arrayLeftLength = array.Length / 2;
                int arrayRightLength = array.Length - arrayLeftLength;
                string[] arrayLeft = new string[arrayLeftLength];
                string[] arrayRight = new string[arrayRightLength];
                Array.Copy(array, 0, arrayLeft, 0, arrayLeftLength);
                Array.Copy(array, arrayLeftLength, arrayRight, 0, arrayRightLength);
                arrayLeft = OrderStringsByLengthMerge(arrayLeft);
                arrayRight = OrderStringsByLengthMerge(arrayRight);
                return MergeArrays(arrayLeft, arrayRight, comparer);
            }
        }
        private static string[] MergeArrays(string[] leftArray, string[] rightArray, IComparer<string> comparer)
        {
            int arraySize = leftArray.Length + rightArray.Length;
            string[] mergingArray = new string[arraySize];
            int indexLeft = 0;
            int indexRight = 0;

            for (int i = 0; i < arraySize; i++)
            {
                if (leftArray.Length == indexLeft)
                {
                    mergingArray[i] = rightArray[indexRight];
                    indexRight++;
                    continue;
                }

                if (rightArray.Length == indexRight)
                {
                    mergingArray[i] = leftArray[indexLeft];
                    indexLeft++;
                    continue;
                }

                if (comparer.Compare(leftArray[indexLeft], rightArray[indexRight])<0)
                {
                    mergingArray[i] = leftArray[indexLeft];
                    indexLeft++;
                }
                else if (comparer.Compare(leftArray[indexLeft], rightArray[indexRight]) > 0)
                {
                    mergingArray[i] = rightArray[indexRight];
                    indexRight++;
                }
                else if (comparer.Compare(leftArray[indexLeft], rightArray[indexRight]) == 0)
                {
                    mergingArray[i] = leftArray[indexLeft];
                    mergingArray[i + 1] = rightArray[indexRight];
                    indexLeft++;
                    indexRight++;
                    i++;
                }

            }

            return mergingArray;
        }
    }
}

