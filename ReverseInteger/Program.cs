using System;

namespace ReverseInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Integer to reverse: ");
            var intReverse = Console.ReadLine();
            Int32.TryParse(intReverse, out int newInt);

            int x = Reverse(newInt);
            Console.WriteLine(x);
        }

        public static int Reverse(int x)
        {
            char[] charArray = x.ToString().ToCharArray();
            Array.Reverse(charArray);
            string intReversed = "";

            foreach (var c in charArray)
            {
                if (c == '-')
                {
                    intReversed = c + intReversed;
                }
                else
                {
                    intReversed += c;
                }
            }

            Int32.TryParse(intReversed, out x);

            //(string number, string newNumber) = (x.ToString(), "");

            //for (int i = number.Length; i > 0; i--)
            //{
            //    newNumber += number.Substring(i - 1, i);
            //}

            //Int32.TryParse(newNumber, out x);

            return x;
        }
    }
}
