using System;

namespace Estruturas
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var value = 1;
            
            Queue queue = new Queue();

            while (value != 10)
            {
                queue.Enqueue(new Node(value++));
            }

            Console.WriteLine($"Size = {queue.Size}");

            queue.Print();
            Console.WriteLine(((Node) queue.DeEnqueue()).Value);
            
            queue.Print();
            queue.DeEnqueue();
            
        }
    }
}