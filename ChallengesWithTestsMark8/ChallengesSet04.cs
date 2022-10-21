using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var list = new List<int> { str1.Length, str2.Length, str3.Length, str4.Length };
            return list.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var list = new List<int> { number1, number2, number3, number4 };
            return list.Min();
        }
            

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }
            else return false;
        }

        public bool IsStringANumber(string input)
        {
            double x = 0;
            bool success = double.TryParse(input, out x);
            return success;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var isNull = objs.Where(x => x == null);
            var isntNull = objs.Where(x => x != null);
            if (isNull.Count() > isntNull.Count())
            {
                return true;
            }
            else return false;
        }

        public double AverageEvens(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            var n = numbers.Where(x => x % 2 == 0);
            if(n.Count() == 0)
            {
                return 0;
            }
            return n.Average(x => x);
        }

        public int Factorial(int number)
        {
            int fact = 1;

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = number; i > 0; i--)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
