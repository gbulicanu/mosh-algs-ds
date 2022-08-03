class AVLTree
{
    AVLNode? rootNode;

    // Recursive
    public void Insert(int value)
    {
        this.rootNode = Insert(this.rootNode, value);
    }

    private AVLNode Insert(AVLNode? node, int value)
    {
        if(node == null)
            return new AVLNode(value);

        if (value < node.Value)
            node.Left = Insert(node.Left, value);
        else
            node.Right = Insert(node.Right, value);

        node.Height = Math.Max(
            GetHeight(node.Left),
            GetHeight(node.Right)) + 1;

        // balanceFactor = hight(L) - heght(R)
        // > 1 => left heavy
        // < -1 => right heavy
        int balanceFactor = GetBalanceFactor(node);
        if (IsLeftHeavy(node))
            WriteLine($"{node.Value} is left heavy");
        else if (IsRightHeavy(node))
            WriteLine($"{node.Value} is right heavy");

        return node;
    }

    private bool IsLeftHeavy(AVLNode? node)
    {
        return GetBalanceFactor(node) > 1;
    }

    private bool IsRightHeavy(AVLNode? node)
    {
        return GetBalanceFactor(node) < -1;
    }

    private int GetBalanceFactor(AVLNode? node)
    {
        return (node == null) ? 0 : GetHeight(node.Left) - GetHeight(node.Right);
    }

    private int GetHeight(AVLNode? node)
    {
        return (node == null) ? -1 : node.Height;
    }

    private class AVLNode
    {
        public int Value;
        public AVLNode? Left;
        public AVLNode? Right;

        public bool IsLeaf => Left == null && Right == null;

        public int Height { get; internal set; }

        public AVLNode(int value) => (Value, Left, Right) = (value, null, null);

        public override string ToString()
        {
            return $"{Left?.Value}<-({Value})->{Right?.Value}";
        }
    }
}
