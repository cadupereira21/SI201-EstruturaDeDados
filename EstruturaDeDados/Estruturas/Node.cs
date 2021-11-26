namespace Estruturas
{
    public class Node
    {
        public object Value { get; }
        public object Next { get; private set; }

        public Node(object value)
        {
            Value = value;
            Next = null;
        }
        
        public void Tie(object obj)
        {
            if (obj == null)
            {
                Next = null;
            }
            else if (obj.GetType() == typeof(Node))
            {
                Next = obj;
            }
            else
            {
                Node n = new Node(obj);
                Next = n;
            }
        }
    }
}