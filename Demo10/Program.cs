using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            Console.WriteLine("Console write line.");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Number { i + 1 }");       
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            // Vòng lặp for

            //for (int i = 4; i >= 0; i--)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            // Vòng lặp foreach
           
            //foreach (int number in numbers.Reverse())
            //{
            //    Console.WriteLine(number);
            //}

            // Linq

            numbers.Reverse().ToList().ForEach(x => Console.WriteLine(x));
            Console.ReadLine();

        }
    }
}
