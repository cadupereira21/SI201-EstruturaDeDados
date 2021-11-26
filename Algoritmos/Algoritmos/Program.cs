using System;
using System.Collections;

namespace Algoritmos
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            int[] vector = new[] {9, 5, 3, 4, 2, 1, 8, 6, 7};

            var vectorOrdenador = Ordenação.QuickSort(vector);

            foreach (var element in vectorOrdenador)
            {
                Console.Write($"{element}  ");
            }
            
            Console.WriteLine();
            
            Console.WriteLine(Busca.Binaria(vector, 1));
        }
    }
}