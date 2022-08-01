class BinarySerachTree
{
    Node? rootNode;

    public void Insert(int value)
    {
        if (rootNode == null)
        {
            rootNode = new Node(value);
            return;
        }

        Node? currentNode = rootNode;
        while (currentNode != null)
        {
            Node currentParent = currentNode;
            if (value < currentNode.Value)
            {
                currentNode = currentNode.Left;
                if (currentNode == null)
                    currentParent.Left = new Node(value, parent: currentParent);
            }
            else
            {
                currentNode = currentNode.Right;
                if (currentNode == null)
                    currentParent.Right = new Node(value, parent: currentParent);
            }
        }
    }

    public bool Find(int value)
    {
        if (rootNode == null)
            return false;


        Node? currentNode = rootNode;
        while (currentNode != null)
        {
            if (currentNode.Value == value)
                return true;

            if (value < currentNode.Value)
                currentNode = currentNode.Left;
            else
                currentNode = currentNode.Right;
        }

        return false;
    }

    private class Node
    {
        public int Value;
        public Node? Left;
        public Node? Right;
        public Node? Parent;

        public Node(int value, Node? left = null, Node? right = null, Node? parent = null)
        {
            this.Value = value;
            this.Left = left;
            this.Right = right;
            this.Parent = parent;
        }
    }
}