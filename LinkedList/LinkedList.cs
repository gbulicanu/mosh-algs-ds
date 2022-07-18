using static System.Console;

public class LinkedList
{
    private class Node
    {
        internal int value;
        internal Node? next;

        internal Node(int value)
        {
            this.value = value;
        }
    }

    private Node? first;
    private Node? last;

    private int length;

    // O(1)
    public int Length { get { return this.length; } }

    public void AddFirst(int item)
    {
        // O(n)
        Node node = new(item);

        if (IsEmpty())
            this.first = this.last = node;
        else
        {
            node.next = this.first;
            this.first = node;
        }

        this.length++;
    }
    
    public void AddLast(int item)
    {
        // O(n)
        Node node = new(item);

        if (IsEmpty())
            this.first = this.last = node;
        else if(this.last != null)
        {
            this.last.next = node;
            this.last = node;
        }

        this.length++;
    }

    public void RemoveFirst()
    {
        // O(1)
        var second = this.first?.next;

        if (IsEmpty())
            throw new InvalidOperationException("Sequence contains no elements");

        if (IsSingleNode())
            this.first = this.last = null;
        else if(this.first != null)
        {
            this.first.next = null;
            this.first = second;
        }
        
        this.length--;
    }

    public void RemoveLast()
    {
        // O(n)
        if (IsEmpty())
            throw new InvalidOperationException("Sequence contains no elements");

        if (IsSingleNode())
            this.first = this.last = null;
        else
        {
            var previous = this.GetPreviousNode(this.last);
            this.last = previous;
            if(this.last != null) this.last.next = null;
        }

        this.length--;
    }

    public bool Contains(int item)
    {
        // O(N)
        return IndexOf(item) != -1;
    }

    public int IndexOf(int item)
    {
        // O(N)
        int index = 0;
        var current = this.first;
        while(current != null)
        {
            if(current.value == item)
                return index;

            current = current.next;
            index++;
        }

        return -1;
    }

    public void Print()
    {
        Node? current = this.first;
        while(current != null)
        {
            WriteLine(current.value);
            current = current.next;
        }
    }

    public int[] ToArray()
    {
        int[] result = new int[this.length];
        
        Node? current = this.first;
        int index = 0;
        while(current != null)
        {
            result[index++] = current.value;
            current = current.next;
        }

        return result;
    }

    public override string ToString()
    {
        return $"[{string.Join(" -> ",  this.ToArray().Select(i => i.ToString()).ToArray())}]";
    }

    private bool IsSingleNode()
    {
        return this.first == this.last;
    }

    private bool IsEmpty()
    {
        return this.first == null;
    }

    private Node? GetPreviousNode(Node? node)
    {
        Node? current = this.first;
        while (current != null)
        {
            if (current.next == node) return current;
            current = current.next;
        }

        return null;
    }
}