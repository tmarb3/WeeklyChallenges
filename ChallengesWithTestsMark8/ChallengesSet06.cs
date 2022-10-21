using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containsWord = false;

            if (string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }
            if (ignoreCase)
            {
                word = word.ToLower();
                List<string> list = words.Select(x => x.ToLower()).ToList();
                containsWord = list.Contains(word);
            }
            if( ignoreCase == false)
            {
                containsWord = words.Contains(word);
            }
            return containsWord;
        }

        public bool IsPrimeNumber(int num)
        {
            var isPrime = false;
            if(num >= 0)
            {
                if (num % 2 != 0 && num % 3 != 0)
                {
                    isPrime = true;
                }
            }
            if(num == 1)
            {
                return false;
            }
            if(num == 2 || num == 3) { return true; }
            return isPrime;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool uindex;
            for (int i = 0; i < str.Length; i++)
            {
                uindex = true;
                
                for (int x = 0; x < str.Length; x++)
                {
                    if (str[i] == str[x] && i != x)
                    {
                        uindex = false;
                    }
                }
                if(uindex) { index = i; }
            }
            return index;
            
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;

                for (int x = i + 1; x < numbers.Length; x++)
                {
                    if (numbers[i] != numbers[x])
                    {
                        break;
                    }
                    currentCount++;
                }
                if (currentCount > count)
                {
                    count = currentCount;
                }
            }
            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> nthElement = new List<double>();
            double[] nullCheck = new double[0];

            if(elements == null)
            {
                return nullCheck;
            }
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] % n == 0)
                {
                    nthElement.Add(elements[i]);
                }
                if(n < 0 || n > elements.Count)
                {
                    nthElement.Clear();
                }
            }
            return nthElement.ToArray();
        }
    }
}
