using System;
using System.Collections;

/*
 * Author: Manko
 */

namespace Algoritmos
{
    public class Busca
    {
        public static int Sequencial(ICollection vector, object key)
        {
            var index = 0;
            foreach (var element in vector)
            {
                if (key.Equals(element))
                {
                    return index;
                }
                index += 1;
            }

            throw new ArithmeticException($"Não foi encontrado o valor da chave {key}");
        }

        public static int Binaria(int[] vector, int key)
        {
            vector = Ordenação.QuickSort(vector);
            return Search(vector, key, 0, vector.Length-1);
        }
        
        public static int Binaria(double[] vector, double key)
        {
            vector = Ordenação.QuickSort(vector);
            return Search(vector, key, 0, vector.Length-1);
        }
        
        private static int Search(int[] vector, int key, int startIndex, int endIndex)
        {
            var middle = (endIndex + startIndex) / 2;
            if (((endIndex + startIndex) % 2) != 0) middle += 1;

            if (middle == endIndex)
            {
                return vector[middle] == key ? middle : startIndex;
            }
            
            if (vector[middle] > key) return Search(vector, key, startIndex, middle);
            if (vector[middle] < key) return Search(vector, key, middle, endIndex);

            return middle;
        }
        
        private static int Search(double[] vector, double key, int startIndex, int endIndex)
        {
            var middle = (endIndex + startIndex) / 2;
            if (((endIndex + startIndex) % 2) != 0) middle += 1;

            if (middle == endIndex)
            {
                return vector[middle] == key ? middle : startIndex;
            }
            
            if (vector[middle] > key) return Search(vector, key, startIndex, middle);
            if (vector[middle] < key) return Search(vector, key, middle, endIndex);

            return middle;
        }
    }
}