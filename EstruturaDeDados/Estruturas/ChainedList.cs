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

        public void Add()
        {
            
        }
    }
}