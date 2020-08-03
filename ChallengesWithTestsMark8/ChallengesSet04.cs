using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int odds = 0;
            int evens = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 2 == 0)
                {
                    evens += numbers[i];
                }
                else
                {
                    odds += numbers[i];
                }
            }
            return evens - odds;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int arg1 = str1.Length;
            int arg2 = str2.Length;
            int arg3 = str3.Length;
            int arg4 = str4.Length;
            var arr = new int[4] { arg1, arg2, arg3, arg4};
            int min = arg1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }

            return min;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var arr = new int[4] { number1, number2, number3, number4 };
            int min = number1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 + sideLength2 > sideLength3 && sideLength2 + sideLength3 > sideLength1 && sideLength1 + sideLength3 > sideLength2 ? true : false;
        }

        public bool IsStringANumber(string input)
        {
            if (input == null || input.Length == 0)
            {
                return false;
            }
            string letters = "qwertyuiopasdfghjklzxcvbnm*#";
            for (int i = 0; i < input.Length; i++)
            {
                if (letters.IndexOf(input[i]) != -1)
                {
                    return false; 
                }
            }
            return true;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int counter = 0;
            int not = 0;
            for (int i = 0; i < objs.Length; i++)
            {
                if(objs[i] != null)
                {
                    counter++;
                }
                else
                {
                    not++;
                }
            }
            if (counter >= not)
            {
                return false;
            }

            return true;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            var a = new List<double>();
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    a.Add(numbers[i]);
                }
            }
            for (int i = 0; i < a.Count; i++)
            {
                sum += a[i];
            }
            if (a.Count == 0)
            {
                return 0;
            }
            else
            {
                return sum / a.Count;
            }
        }

        public int Factorial(int number)
        {
            int fact = number;
            if (fact < 0)
            {
                throw new ArgumentOutOfRangeException("age", "All factorials must be positive.");
            }
            if (fact == 0)
            {
                fact = 1;
            }
            for (int i = number - 1; i >= 1; i--)
            {

                if (i > 0)
                {
                    i = Math.Abs(i);
                }
                fact *= i;

            }
            return fact;
        }
    }
}
