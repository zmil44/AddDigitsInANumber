using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDigitsInANumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine(AddDigits(input));
        }
        public static int AddDigits(int number)
        {
            int sum = 0;
            if (number < 10 && number > 0)
            {
                return number;
            }
            else
            {
                while (number != 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                return AddDigits(sum);
            }
        }
    }
}
