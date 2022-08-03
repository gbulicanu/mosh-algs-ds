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
        int getHeight(AVLNode? node)
        {
            return (node == null) ? -1 : node.Height;
        };

        if(node == null)
            return new AVLNode(value);

        if (value < node.Value)
            node.Left = Insert(node.Left, value);
        else
            node.Right = Insert(node.Right, value);

        node.Height = Math.Max(
            getHeight(node.Left),
            getHeight(node.Right)) + 1;

        // balanceFactor = hight(L) - heght(R)
        // > 1 => left heavy
        // < -1 => right heavy
        int balanceFactor = getHeight(node.Left) - getHeight(node.Right);
        if (balanceFactor > 1)
            WriteLine($"{node.Value} - LH");
        else if (balanceFactor < -1)
            WriteLine($"{node.Value} - RH");

        return node;
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
