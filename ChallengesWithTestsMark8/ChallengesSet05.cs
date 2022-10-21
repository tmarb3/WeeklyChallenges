using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            for (int i = startNumber + 1; i < 1000; i++)
            {
                if (i % n == 0)
                {
                    return i;
                }
            }
            return 0;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length; i++)
            {
                if(businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }

            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            var ascList = numbers.OrderBy(x => x);
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }
            return true;

        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int sum = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if(words == null || words.Length == 0)
            {
                return "";
            }
            List<string> sentence = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == "" || words[i] == " " || words[i] == "  ")
                {
                    
                }else sentence.Add(words[i].Trim());

            }
            if (sentence.Count > 0)
            {
                return String.Join(" ", sentence) + ".";
            }
            else return "";
            
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            var someElements = new List<double>();
            if (elements == null || elements.Count == 0)
            {
                return someElements.ToArray();
            }
            
            for (int i = 3; i < elements.Count; i+=4)
            {
                someElements.Add(elements[i]);
            }
            return someElements.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int x = i + 1; x < nums.Length; x++)
                {
                    if (nums[i] + nums[x] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
