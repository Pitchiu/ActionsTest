using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TDD
{
    public class StringCalculator
    {

        public int Calculate(string arg)
        {
            if (arg == "")
            {
                return 0;
            }
            int result;
            bool success = int.TryParse(arg, out result);
            if (success)
            {
                return result;
            }

            char[] delimiters = { ',', '\n' };
            var eitherSplit = arg.Split(delimiters);
            int sum = 0;
            foreach (var item in eitherSplit)
            {
                int value = Int32.Parse(item);
                sum += value;
            }

            return sum;
        }
    }


    public class Hello
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
        }
    }
}