using System;

namespace Estruturas
{
    public class CircularQueue : Queue
    {
        #region Constructor
        public CircularQueue()
        {
            this.NextInQueue = null;
        }

        public CircularQueue(object obj)
        {
            SetNextInQueue(obj);
            ++Size;
        }
        #endregion

        private void ResetLastNodeNext()
        {
            ((Node) GetLastInQueue()).Next = NextInQueue;
        }
        
        private void SetNextInQueue(object obj)
        {
            if(obj.GetType() == typeof(Node))
                NextInQueue = (Node) obj;
            else
                NextInQueue = new Node(obj); 
            
            NextInQueue.Next = NextInQueue;
        }

        public new void Print()
        {
            Console.Write($"\nNext - {NextInQueue.Value}");

            var aux = (Node) NextInQueue.Next;
            while (aux != NextInQueue)
            {
                Console.Write($" | {aux.Value}");
                aux = (Node) aux.Next;
            }
            
            Console.Write(" - Last\n");
        }

        public new object GetLastInQueue()
        {
            var aux = NextInQueue;

            while (aux.Next != NextInQueue)
            {
                aux = (Node) aux.Next;
            }
            
            return aux;
        }

        public new int Enqueue(object obj)
        {
            if (IsEmpty())
                SetNextInQueue(obj);
            else if(Size == 1)
                NextInQueue.CircularTie(NextInQueue,obj);
            else
                ((Node) GetLastInQueue()).CircularTie(NextInQueue,obj);

            ResetLastNodeNext();
            
            return ++Size;
        }

        public new object DeEnqueue()
        {
            if (IsEmpty()) return null;

            var aux = NextInQueue;
            
            ((Node) GetLastInQueue()).Tie(NextInQueue.Next);
            NextInQueue = (Node) NextInQueue.Next;

            --Size;
            return aux;
        }
    }
}