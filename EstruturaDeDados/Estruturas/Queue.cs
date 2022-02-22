using System;

namespace Estruturas
{
    public class Queue
    {
        public Node NextInQueue { get; protected set; }
        public int Size { get; protected set; }

        #region Constructors

        public Queue()
        {
            NextInQueue = null;
            Size = 0;
        }
        
        public Queue(object obj)
        {
            SetNextInQueue(obj);

            Size+=1;
        }

        #endregion

        private void SetNextInQueue(object obj)
        {
            if(obj.GetType() == typeof(Node))
                NextInQueue = (Node) obj;
            else
                NextInQueue = new Node(obj);
        }

        public bool IsEmpty()
        {
            return NextInQueue == null;
        }

        // Return the last node in queue
        public object GetLastInQueue()
        {
            if (IsEmpty()) return null;

            var aux = NextInQueue;
            while (aux.Next != null)
            {
                aux = (Node) aux.Next;
            }

            return aux;
        }

        public void Print()
        {
            
            Console.Write($"\nNext - {NextInQueue.Value}");

            var aux = (Node) NextInQueue.Next;
            while (aux != null)
            {
                Console.Write($" | {aux.Value}");
                aux = (Node) aux.Next;
            }
            
            Console.Write(" - Last\n");
        }

        public int Enqueue(object value)
        {
            if (IsEmpty())
                SetNextInQueue(value);
            else
                ((Node) GetLastInQueue()).Tie(value);
            
            return ++Size;
        }

        // Return the next node in queue!
        public object DeEnqueue()
        {
            if (IsEmpty()) return null;

            var aux = NextInQueue;
            NextInQueue = (Node) NextInQueue.Next;
            --Size;
            
            return aux;
        }
    }
}