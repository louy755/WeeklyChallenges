using System;

namespace ChallengesWithTestsMark8
{
    class Program
    {
        static void Main(string[] args)
        {
            //              { "AB1ZZ", "DE!XX", "GH;YY" }
            var arg = new[] { "ab1zz", "de!xx", "gh;yy" };
            ChangeAllElementsToUppercase(arg);
            //Console.WriteLine("Hello, world!");
        }

        public static void ChangeAllElementsToUppercase(string[] words)
        {
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
