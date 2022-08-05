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
        if (node == null)
            return new AVLNode(value);

        if (value < node.Value)
            node.Left = Insert(node.Left, value);
        else
            node.Right = Insert(node.Right, value);

        UpdateHeight(node);

        return Balance(node!);
    }

    private AVLNode Balance(AVLNode node)
    {
        if (IsLeftHeavy(node))
        {
            if (GetBalanceFactor(node.Left) < 0)
                node.Left = LeftRotate(node.Left!);
            return RightRotate(node);
        }
        else if (IsRightHeavy(node))
        {
            if (GetBalanceFactor(node.Right) > 0)
                node.Right = RightRotate(node.Right!);
            return LeftRotate(node);
        }

        return node;
    }

    private AVLNode LeftRotate(AVLNode root)
    {
        AVLNode newRoot = root.Right!;
        root.Right = newRoot?.Left;
        newRoot!.Left = root;

        UpdateHeight(root);
        UpdateHeight(newRoot);
        
        return newRoot;
    }

    private AVLNode RightRotate(AVLNode root)
    {
        AVLNode newRoot = root.Left!;
        root.Left = newRoot?.Right;
        newRoot!.Right = root;

        UpdateHeight(root);
        UpdateHeight(newRoot);

        return newRoot;
    }

    private void UpdateHeight(AVLNode node) 
    {
        node.Height = Math.Max(
            GetHeight(node.Left),
            GetHeight(node.Right)) + 1;
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
        return (node == null)
            ? 0
            : GetHeight(node.Left) - GetHeight(node.Right);
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
