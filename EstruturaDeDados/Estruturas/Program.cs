using System;

namespace Estruturas
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var node = new Node(5);
            var heap = new Heap(node);



            Console.WriteLine(heap.Pop());

            heap.Print();
            Console.WriteLine();
            Console.Write(heap.Size);
        }
    }
}