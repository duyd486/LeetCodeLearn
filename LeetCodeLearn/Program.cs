using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = Console.ReadLine();
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(IsSumOfPowerThree(x));
        }


        #region LongestCommonPrefix

        public static string LongestCommon(string[] str)
        {
            string s = "";



            return s;
        }

        #endregion

        #region NumberSumPowerOfThree

        public static bool IsSumOfPowerThree(int n)
        {
            for (int i = 14; i >= 0; i--)
            {
                int j = i;
                int pow = 1;
                while(j > 0)
                {
                    pow *= 3;
                    j--;
                }
                if(n > pow){
                    n -= pow;
                }
                else if (n == pow)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region RomanToInt
        public static int RomanToInt(string s)
        {
            int x = 0;
            x = ValueOf(s[s.Length - 1]);

            for (int i = s.Length - 1; i >= 0; i--)
            {
                int j = i - 1;
                if(j >= 0)
                {
                    if (ValueOf(s[i]) > ValueOf(s[j]))
                    {
                        x -= ValueOf(s[j]);
                    }
                    else
                    {
                        x += ValueOf(s[j]);
                    }
                }
            }
            return x;
        }
        public static int ValueOf(char s)
        {
            int value = 0;
            switch (s.ToString().ToUpper())
            {
                case "I":
                    value = 1;
                    break;
                case "V":
                    value = 5;
                    break;
                case "X":
                    value = 10;
                    break;
                case "L":
                    value = 50;
                    break;
                case "C":
                    value = 100;
                    break;
                case "D":
                    value = 500;
                    break;
                case "M":
                    value = 1000;
                    break;
            }
            return value;
        }
        #endregion

        #region Palindrome
        public static bool IsPalindrome(int x)
        {
            if (x < 0 || (x != 0 && x % 10 == 0)){
                return false;
            }
            int y = 0;
            while(x > y)
            {
                y = (y * 10) + (x % 10);
                x = x / 10;
            }
            return x == y || x == y / 10;
        }
        #endregion
    }
}
