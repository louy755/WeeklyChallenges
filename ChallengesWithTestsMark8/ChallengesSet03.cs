using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var item in vals)
            {
                if(item == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            List<int> list = numbers.ToList();
            int sum = 0;
            foreach (var item in list)
            {
                sum += item;
            }
            if(sum % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            string lettersBg = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string lettersSm = "qwertyuiopasdfghjklzxcvbnm";
            string nums = "1234567890";
            int big = 0;
            int sml = 0;
            int n = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (lettersBg.IndexOf(password[i]) > -1)
                {
                    big++;
                }
                else if (lettersSm.IndexOf(password[i]) > -1)
                {
                    sml++;
                }
                else if (nums.IndexOf(password[i]) > -1)
                {
                    n++;
                }

            }
            if (big > 0 && sml > 0 && n > 0)
            {
                return true;
            }
            return false;

        }


        public char GetFirstLetterOfString(string val)
        {
           return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length -1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if(divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            var last = nums[nums.Length - 1];
            var first = nums[0];
            return last - first;
        }

        public int[] GetOddsBelow100()
        {
            int counter = 0;
            int[] odds = new int[50];
            for (int i = 1; i < 100; i = i + 2)
            {
                odds[counter] = i;
                counter++;
            }
            return odds;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            if(words.Length == 0)
            {
                Console.WriteLine(new string[0]);
            }
            string letters = "qwertyuiopasdfghjklzxcvbnm";
            string[] final = new string[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                char[] array = words[i].ToCharArray();
                for (int j = 0; j < array.Length; j++)
                {
                    char let = array[j];
                    if (letters.IndexOf(let) > -1)
                    {
                        array[j] = char.ToUpper(let);
                    }
                    else
                    {
                        array[j] = let;
                    }
                }
                string result = new string(array);
                words[i] = result;

            }
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
