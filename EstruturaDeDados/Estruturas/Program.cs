using System;

namespace Estruturas
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            ChainedList list = new ChainedList();
            list.Add(0);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Print();
            list.DeleteFromIndex(2);
            list.Print();
        }
    }
}