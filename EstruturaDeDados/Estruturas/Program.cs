using System;

namespace Estruturas
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var value = 1;
            
            CircularQueue queue = new CircularQueue();
            
            while (value != 10)
            {
                queue.Enqueue(new Node(value++));
            }

            queue.Print();
            
            Console.WriteLine($"\nLast in Queue = {((Node)queue.GetLastInQueue()).Value}");
            Console.WriteLine($"Dequeued value = {((Node) queue.DeEnqueue()).Value}");
            queue.Print();
            
            Console.WriteLine($"\nLast in Queue = {((Node)queue.GetLastInQueue()).Value}");
            Console.WriteLine($"Dequeued value = {((Node) queue.DeEnqueue()).Value}");
        }
    }
}