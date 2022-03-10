namespace Estruturas
{
    public class Node
    {
        public object Value { get; }
        public object Next { get; set; }

        public Node(object value)
        {
            Value = value;
            Next = null;
        }

        public static Node ToNode(object obj)
        {
            if (obj == null)
                return null;
            
            if(obj.GetType() == typeof(Node))
                return ((Node) obj);
            
            return new Node(obj);
        }

        public void Tie(object obj)
        {
            var n = ToNode(obj);

            Next = n;
        }

        public void CircularTie(object startNode, object obj)
        {
            if (obj == null)
            {
                Next = startNode;
            }
            else if (obj.GetType() == typeof(Node))
            {
                Next = obj;
                ((Node) obj).Tie(startNode);
            }
            else
            {
                Node n = new Node(obj);
                Next = n;
                n.Tie(startNode);
            }
        }
    }
}