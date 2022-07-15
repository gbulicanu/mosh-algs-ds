using static System.Console;

public class LinkedList
{
    private Node? first;
    private Node? last;

    public void AddFirst(int value)
    {
        // O(n)
        var node = new Node { Value = value, Next = this.first };
        this.first = node;
        
        if (this.last == null)
            this.last = node;
    }
    
    public void AddLast(int value)
    {
        // O(n)
        var node = new Node { Value = value };
        this.last = node;

        if (this.first == null)
        {
            this.first = node;
            return;
        }

        Node? prevLast = this.first;
        while (prevLast != null && prevLast.Next != null)
            prevLast = prevLast.Next;

        if (prevLast == null)
            return;
            
        prevLast.Next = node;
    }

    public void DeleteFirst()
    {
        // O(1)
        var next = this.first?.Next;
        if(this.first != null && next != null)
        {
            this.first.Next = null;
            this.first = next;
        }
    }

    public void DeleteLast()
    {
        // O(n)
        if (this.last != null)
            this.last.Next = null;

        Node? prevToLast = this.first;
        while (prevToLast != null && prevToLast.Next != null)
        {
            if (prevToLast.Next == last)
                break;

            prevToLast = prevToLast.Next;
        }

        if (prevToLast == null)
            return;

        prevToLast.Next = null;
    }

    public bool Contains(int value)
    {
        // O(N)
        Node? current = first;
        while(current != null && current.Next != null)
        {
            if(current.Value == value)
                return true;

            current = current.Next;
        }

        return current?.Value == value;
    }

    public int IndexOf(int value)
    {
        // O(N)
        int fountAt = 0;
        Node? current = first;
        while(current != null && current.Next != null)
        {
            if(current.Value == value)
                return fountAt;

            current = current.Next;
            fountAt++;
        }

        return current?.Value == value ? fountAt : -1;
    }

    public void Print()
    {
        Node? current = first;
        while(current != null && current.Next != null)
        {
            WriteLine(current.Value);
            current = current.Next;
        }
        
        if(current == null)
            return;

        WriteLine(current.Value);
    }
}