﻿class BinarySerachTree
{
    Node? rootNode;

    public static BinarySerachTree Empty => new();

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

    public void TraverseLevelOrder()
    {
        for (int i = 0; i <= Height(); i++)
        {
            List<int?> list = GetNodesAt(i);
            foreach (var item in list)
            {
                if(item.HasValue)
                    WriteLine(item.Value);
            }
        }
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
    public int Height()
    {
        return Height(rootNode);
    }

    public int Min()
    {
        return Min(rootNode);
    }

    public int MinFast()
    {
        if (this.rootNode == null)
            throw new InvalidOperationException("Tree is empty");

        Node? current = this.rootNode;
        Node? last = current;
        while (current != null)
        {
            last = current;
            current = current.Left;
        }

        return last.Value;
    }

    public bool IsValid()
    {
        return IsValid(this.rootNode, int.MinValue, int.MaxValue);
    }

    public bool Equals(BinarySerachTree other) 
    {
        if (other == null)
            return false;

        return Equals(this.rootNode, other.rootNode);
    }

    public void Disorder()
    {
        Node? temp = this.rootNode?.Left;
        this.rootNode!.Left = this.rootNode?.Right;
        this.rootNode!.Right = temp;
    }

    public List<int?> GetNodesAt(int distance)
    {
        List<int?> list = new();
        GetNodesAt(this.rootNode, distance, list);
        return list;
    }

    private bool Equals(Node? self, Node? other)
    {
        if (self == null && IsLeaf(other))
            return true;

        if (self != null && other != null)
            return self.Value == other.Value
                && Equals(self.Left, other.Left)
                && Equals(self.Right, other.Right);

        return false;
    }

    private bool IsValid(Node? node, int min, int max)
    {
        if (node == null)
            return true;

        if (node.Value < min || node.Value > max)
            return false;

        return IsValid(node.Left, min, node.Value - 1)
            && IsValid(node.Right, node.Value + 1, max);
    }

    private void GetNodesAt(Node? node, int distance, List<int?> list)
    {
        if (node == null)
            return;

        if (distance == 0)
            list.Add(node?.Value);

        GetNodesAt(node?.Left, distance - 1, list);
        GetNodesAt(node?.Right, distance - 1, list);

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

    // O(log n)
    private int Height(Node? rootNode)
    {
        if (rootNode == null)
            return -1;

        if (IsLeaf(rootNode))
            return 0;

        return 1 + Math.Max(
            Height(rootNode.Left),
            Height(rootNode.Right));
    }

    // O(n)
    private int Min(Node? node)
    {
        if (node == null)
            return this.rootNode?.Value ?? -1;

        if (IsLeaf(node))
            return node.Value;

        int left = Min(node.Left);
        int right = Min(node.Right);

        return Math.Min(Math.Min(left, right), node.Value);
    }

    private static bool IsLeaf(Node? node) =>
        node == null || (node.Left == null && node.Right == null);

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

        public Node(
            int value,
            Node? left = null,
            Node? right = null,
            Node? parent = null)
        {
            this.Value = value;
            this.Left = left;
            this.Right = right;
            this.Parent = parent;
        }

        public override string ToString()
        {
            return $"{Left?.Value}<-({Value})->{Right?.Value}";
        }
    }
}