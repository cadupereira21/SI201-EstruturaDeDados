namespace Algoritmos
{
    public static class Ordenação
    {
        // BUBBLE SORT ===================================================== /
        
        public static int[] BubbleSort(int[] v)
        {
            for (var j = 0; j < v.Length; j++)
            {
                for (var i = 0; i < v.Length - 1; i++)
                {
                    if (v[i] <= v[i + 1]) continue;
                    
                    var aux = v[i + 1];
                    v[i + 1] = v[i];
                    v[i] = aux;
                }
            }
        
            return v;
        }
        public static double[] BubbleSort(double[] v)
        {
            for (var j = 0; j < v.Length; j++)
            {
                for (var i = 0; i < v.Length - 1; i++)
                {
                    if (v[i] <= v[i + 1]) continue;
                    
                    var aux = v[i + 1];
                    v[i + 1] = v[i];
                    v[i] = aux;
                }
            }
        
            return v;
        }

        // SELECTION SORT ================================================== /
        
        public static int[] SelectionSort(int[] vector, int length)
        {
            // Condição de parada
            if (length < 2)
            {
                return vector;
            }

            // Checa qual o maior valor
            var higher = vector[0];
            var higherIndex = 0;
            for (var i = 0; i < length; i++)
            {
                if (vector[i] <= higher) continue;
                
                higher = vector[i];
                higherIndex = i;
            }

            // Posiciona o maior valor na ultima posição do vetor
            var aux = vector[length - 1];
            vector[length - 1] = higher;
            vector[higherIndex] = aux;
            
            // Chamada recursiva
            return SelectionSort(vector, length - 1);
        }
        public static double[] SelectionSort(double[] vector, int length)
        {
            // Condição de parada
            if (length < 2)
            {
                return vector;
            }

            // Checa qual o maior valor
            var higher = vector[0];
            var higherIndex = 0;
            for (var i = 0; i < length; i++)
            {
                if (vector[i] <= higher) continue;
                
                higher = vector[i];
                higherIndex = i;
            }

            // Posiciona o maior valor na ultima posição do vetor
            var aux = vector[length - 1];
            vector[length - 1] = higher;
            vector[higherIndex] = aux;
            
            // Chamada recursiva
            return SelectionSort(vector, length - 1);
        }
        
        // INSERT SORT ===================================================== /

        public static int[] InsertSort(int[] vector , int startIndex)
        {
            // Guardamos o valor para utilizarmos na chamada recursiva, uma vez que realizamos operações com startIndex;
            var oldStartIndex = startIndex;

            // Condição de parada
            if (startIndex == vector.Length)
            {
                return vector;
            }
            
            for (var i = 0; i < startIndex; i++)
            {
                if (vector[i] <= vector[startIndex]) continue;
                
                var aux = vector[startIndex];
                
                while (startIndex != i)
                {
                    vector[startIndex] = vector[startIndex - 1];
                    startIndex -= 1;
                }

                vector[i] = aux;
            }

            return InsertSort(vector, oldStartIndex + 1);
        }
        public static double[] InsertSort(double[] vector , int startIndex)
        {
            // Guardamos o valor para utilizarmos na chamada recursiva, uma vez que realizamos operações com startIndex;
            var oldStartIndex = startIndex;

            // Condição de parada
            if (startIndex == vector.Length)
            {
                return vector;
            }
            
            for (var i = 0; i < startIndex; i++)
            {
                if (vector[i] <= vector[startIndex]) continue;
                
                var aux = vector[startIndex];
                
                while (startIndex != i)
                {
                    vector[startIndex] = vector[startIndex - 1];
                    startIndex -= 1;
                }

                vector[i] = aux;
            }

            return InsertSort(vector, oldStartIndex + 1);
        }
        
        // QUICK SORT ====================================================== /

            // Referencia: http://www.macoratti.net/20/11/c_algoritm6.htm
        public static int[] QuickSort(int[] vector)
        {
            var resultado = QuickSort(vector, 0, vector.Length - 1);
            return resultado;
        }
        private static int[] QuickSort(int[] vector, int l, int r)
        {
            int i, j;
            int x;
            i = l;
            j = r;
            x = vector[(l + r) / 2]; /* acha o item pivot */
            
            while (true)
            {
                while (vector[i] < x)
                    i++;
                while (x < vector[j])
                    j--;
                if (i <= j)
                {
                    SwapValues(vector, i, j);
                    i++;
                    j--;
                }
                if (i > j)
                    break;
            }
            
            if (l < j) QuickSort(vector, l, j);
            if (i < r) QuickSort(vector, i, r);
            
            return vector;
        }
        private static void SwapValues(int[] vector, int m, int n)
        {
            int aux;
            aux = vector[m];
            vector[m] = vector[n];
            vector[n] = aux;
        }
    }
}