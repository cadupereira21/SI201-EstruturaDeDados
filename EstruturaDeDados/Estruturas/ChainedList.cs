using System;

namespace Estruturas
{
    public class ChainedList
    {
        private Node root;
        public int Size { get; private set; }

        #region Constructors

        public ChainedList()
        {
            root = null;
            Size = 0;
        }

        public ChainedList(object obj)
        {
            if (obj.GetType() == typeof(Node))
                root = (Node) obj;
            else
                root = new Node(obj);
        }

        #endregion

        #region Private Methods

        public int GetIndex(object obj)
        {
            var aux = root;
            var index = 0;
            while (aux.Next != null)
            {
                if (aux.Value.Equals(obj))
                {
                    return index;
                }

                index += 1;
                aux = (Node) aux.Next;
            }

            return -1;
        }

        private Node GetNodeAt(int index)
        {
            var aux = root;
            int i = 0;

            while (i++ < index)
            {
                aux = (Node) aux.Next;
            }

            return aux;
        }

        private Node GetLast()
        {
            var aux = root;
            while (aux.Next != null)
                aux = (Node) aux.Next;
            return aux;
        }

        #endregion

        public void Print()
        {
            if (IsEmpty()) return;
            
            var aux = root;

            Console.Write("\n|");
            while (aux != null)
            {
                Console.Write($" {aux.Value} |");
                aux = (Node) aux.Next;
            }
            Console.WriteLine();
        }

        public bool IsEmpty()
        {
            return root == null;
        }

        public void Add(object obj)
        {
            var n = Node.ToNode(obj);

            if (IsEmpty())
                root = n;
            else
                GetLast().Tie(n);

            ++Size;
        }

        public void Insert(int index, object obj)
        {
            var n = Node.ToNode(obj);
            var auxNode = GetNodeAt(--index);
            
            n.Tie(auxNode.Next);
            auxNode.Tie(n);

            ++Size;
        }

        public object Pop()
        {
            var aux = GetLast();

            var r = root;

            while (r.Next != aux)
                r = (Node) r.Next;
            r.Next = null;

            return aux;
        }

        public Node Search(object obj)
        {
            var objType = obj.GetType();

            var aux = root;
            while (aux.Next != null)
            {
                if (objType == aux.Value.GetType())
                    if (obj.Equals(aux.Value))
                        return aux;
                
                aux = (Node) aux.Next;
            }

            return null;
        }

        public Node Search(int index)
        {
            return GetNodeAt(index);
        }

        public void Delete(object obj)
        {
            var toBeDeleted = Search(obj);

            var aux = root;
            while (aux.Next != toBeDeleted)
                aux = (Node) aux.Next;
            
            aux.Tie(toBeDeleted.Next);
            toBeDeleted.Next = null;
        }

        public void DeleteFromIndex(int index)
        {
            Delete(GetNodeAt(index).Value);
        }
    }
}