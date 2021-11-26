using System;

namespace Estruturas
{
    public class Heap
    {
        private Node root;

        public int Size { get; private set; }

        #region Constructors

        public Heap()
        {
            root = null;
        }
        public Heap(object obj)
        {
            if (obj.GetType() == typeof(Node))
            {
                root = (Node) obj;
            }
            else
            {
                var r = new Node(obj);
                root = r;
            }
            
            Size += 1;
        }

        #endregion

        private Node GetTop()
        {
            var aux = root;
            while (aux.Next != null)
            {
                aux = (Node) aux.Next;
            }

            return aux;
        }

        public void Print()
        {
            if (IsEmpty()) return;
            
            var aux = root;
            while (aux != null)
            {
                Console.Write($" | {aux.Value} |");
                aux = (Node) aux.Next;
            }
        }

        public int Add(object node)
        {
            root.Tie(node);
            return ++Size;
        }

        public object Pop()
        {
            if (IsEmpty()) return null;
            
            var aux = GetTop();
            var valor = aux.Value;

            if (aux == root)
            {
                root = null;
                Size -= 1;
                return valor;
            }
            
            var index = root;
            while (index.Next != aux)
            {
                index = (Node) index.Next;
            }
            
            index.Tie(null);

            Size -= 1;
            return aux;
        }

        private bool IsEmpty()
        {
            return root == null;
        }
    }
}