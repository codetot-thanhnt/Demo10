using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazingProject
{
    internal class Program
    {
        public static void Main()
        {
            Console.Write("How much data did I reserve: ");
            int repeticiones = Convert.ToInt32(Console.ReadLine());
            float numero;
            float[] listaNumeros = new float[repeticiones];

            for (int i = 0; i < repeticiones; i++)
            {
                Console.Write("Tell me number {0} to save in the list: ", i);
                listaNumeros[i] = Convert.ToSingle(Console.ReadLine());
            }

            Console.Write("What number does it check on the list?");
            

            while (Console.ReadLine() != "end")
            {
                numero = Convert.ToSingle(Console.ReadLine());
                for (int i = 0; i < repeticiones; i++)
                {
                    if (listaNumeros[i] == numero)
                        Console.WriteLine("The number {0} exists in the list", numero);
                }
            }
        }
    }
}
