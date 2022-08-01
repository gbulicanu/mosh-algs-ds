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

        Node? nodeToInsert = FindNodeWith(value, true);
        if (nodeToInsert != null)
        {
            if (value < nodeToInsert.Value)
                nodeToInsert.Left = new Node(value, parent: nodeToInsert);
            else
                nodeToInsert.Right = new Node(value, parent: nodeToInsert);

        }
    }

    public bool Find(int value)
    {
        return FindNodeWith(value) != null;
    }

    public void TraversePreOrder()
    {
        TraversePreOrder(rootNode);
    }

    public void TraverseInOrder()
    {
        TraverseInOrder(rootNode);
    }

    public void TraversePostOrder()
    {
        TraversePostOrder(rootNode);
    }

    private void TraversePreOrder(Node? rootNode)
    {
        if (rootNode == null)
            return;

        WriteLine(rootNode.Value);
        TraversePreOrder(rootNode.Left);
        TraversePreOrder(rootNode.Right);
    }

    private void TraverseInOrder(Node? rootNode)
    {
        if (rootNode == null)
            return;

        TraverseInOrder(rootNode.Left);
        WriteLine(rootNode.Value);
        TraverseInOrder(rootNode.Right);
    }

    private void TraversePostOrder(Node? rootNode)
    {
        if (rootNode == null)
            return;

        TraversePostOrder(rootNode.Left);
        TraversePostOrder(rootNode.Right);
        WriteLine(rootNode.Value);
    }

    private Node? FindNodeWith(int value, bool toInsert = false)
    {
        if (rootNode != null)
        {
            Node? currentNode = rootNode;
            while (currentNode != null)
            {
                Node currentParent = currentNode;

                if (currentNode.Value == value && !toInsert)
                    return currentNode;

                if (value < currentNode.Value)
                {
                    currentNode = currentNode.Left;
                    if (currentNode == null && toInsert)
                        return currentParent;
                }
                else
                {
                    currentNode = currentNode.Right;
                    if (currentNode == null && toInsert)
                        return currentParent;
                }
            }
        }

        return null;
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