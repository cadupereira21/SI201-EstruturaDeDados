using System;
using System.Collections;

namespace Algoritmos
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] vector = new[] {9, 5, 3, 4, 2, 1, 8, 6, 7};

            var vetorOrdenado = Ordenação.QuickSort(vector);
            
            foreach (var VARIABLE in vetorOrdenado)
            {
                Console.Write(VARIABLE + "  ");
            }
        }
    }
}