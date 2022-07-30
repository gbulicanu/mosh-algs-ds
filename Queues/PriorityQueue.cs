class PriorityQueue
{
    readonly int capacity;

    int[] items;
    int count;

    public PriorityQueue(int capacity = 10)
    {
        this.capacity = capacity;
        this.items = new int[capacity];
    }

    public bool IsFull()
    {
        return this.count == this.capacity;
    }

    public bool IsEmpty()
    {
        return count == 0;
    }

    public void Enqueue(int item)
    {
        if (IsFull())
            throw new InvalidOperationException("Queue is full");

        if (IsEmpty())
            this.items[0] = item;

        for (int i = count - 1; i >= 0; i--)
            if (this.items[i] > item)
                this.items[i + 1] = items[i];
            else
            {
                this.items[i + 1] = item;
                break;
            }

        count++;
    }

    public int Dequeue()
    {
        if (this.IsEmpty())
            throw new InvalidOperationException("Queue is empty");

        var item = this.items[0];
        
        for (int i = 1; i < count; i++)
            this.items[i - 1] = this.items[i];

        this.items[--this.count] = 0;
        return item;
    }

    public int Peek()
    {
        if (this.IsEmpty())
            throw new InvalidOperationException("Queue is empty");

        return this.items[0];
    }

    public override string ToString()
    {
        if (IsEmpty())
            return "[]";

        var queueArrayRep = this.items.Select(x => x.ToString())
            .Take(this.count)
            .ToArray();

        return $"[{string.Join(", ", queueArrayRep)}]";
    }
}
