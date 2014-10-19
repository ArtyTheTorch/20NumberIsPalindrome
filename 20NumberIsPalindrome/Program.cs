using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20NumberIsPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(reverse(num));
            Console.WriteLine(reverse(num)==num);
            Console.ReadLine();
        }

        private static int reverse(int num)
        {
            int results = 0;
            int temp = num;

            do {
                results = results*10 + temp % 10;
                temp = temp / 10;
            }
            while (temp > 0);
            return results;
        }
    }
}
