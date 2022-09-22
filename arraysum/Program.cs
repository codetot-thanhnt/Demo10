using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] example = { 1, 2, 3, 4, 5 };
            Console.WriteLine(Some(example));
            Console.ReadLine();
        }
        static int Some(int[] arr)
        {
            var arrSum = 0;
           //return arr.Sum();
           for(int i = 0; i < arr.Length; i++)
            {
                arrSum += arr[i];
            }
           return arrSum;

        }
        
    }
}
