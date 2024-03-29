﻿class DynamicStack
{
    private int[] items;

    private int count;

    public DynamicStack(int intialCapacity = 3)
    {
        this.items = new int[intialCapacity];
    }

    public void Push(int item)
    {
        if (items.Length == this.count)
        {
            int[] newItems = new int[items.Length * 2];

            for (int i = 0; i < this.count; i++)
                newItems[i] = this.items[i];

            this.items = newItems;
        }

        this.items[this.count++] = item;
    }
    
    public int Pop()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is empty");

        return this.items[--this.count];
    }
    
    public int Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is empty");

        return this.items[this.count - 1];
    }
    
    public bool IsEmpty()
    {
        return this.count == 0;
    }

    public int[] ToArray()
    {
        int[] result = new int[this.count];
        Array.Copy(this.items, 0, result, 0, this.count);
        Array.Reverse(result);

        return result;
    }

    public override string ToString()
    {
        string[] itemsRep = this.ToArray()
            .Reverse()
            .Select(i => i.ToString())
            .ToArray();

        return $"[{string.Join(", ", itemsRep)}>";
    }
}