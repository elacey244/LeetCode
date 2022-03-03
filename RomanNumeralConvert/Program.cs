using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleUIs
{
    public class Program
    {
        public static Dictionary<string, int> RomanDict = new Dictionary<string, int>()
        {
            { "I", 1 },
            { "V", 5 },
            { "X", 10 },
            { "L", 50 },
            { "C", 100 },
            { "D", 500 },
            { "M", 1000 }
        };

        static void Main(string[] args)
        {
            string romanNumeral = GetInput();

            int num = ConvertToNum(romanNumeral);

            Console.WriteLine(num);

        }

        public static string GetInput()
        {
            Console.WriteLine("What Roman Numeral you would like to convert to a number: ");
            string romanNumeral = Console.ReadLine();
            return romanNumeral;
        }

        private static int ConvertToNum(string romanNumeral)
        {
            int num = 0;
            foreach (char c in romanNumeral.ToUpper())
            {
                RomanDict.TryGetValue(c.ToString(), out int nextNum);
                num += nextNum;
            }

            if (romanNumeral.Contains("IV") || romanNumeral.Contains("IX"))
            {
                num -= 2;
            }
            if (romanNumeral.Contains("XL") || romanNumeral.Contains("XC"))
            {
                num -= 20;
            }
            if (romanNumeral.Contains("CD") || romanNumeral.Contains("CM"))
            {
                num -= 200;
            }
            return num;
        }
    }
}
