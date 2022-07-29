class ArrayQueue
{
    readonly int capacity;

    int[] items;
    int frontIndex;
    int rearIndex;
    int count;

    public ArrayQueue(int capacity = 10)
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

        this.items[this.rearIndex] = item;
        this.rearIndex = (this.rearIndex + 1) % this.capacity;
        count++;
    }

    public int Dequeue()
    {
        if (this.IsEmpty())
            throw new InvalidOperationException("Queue is empty");

        var item = this.items[this.frontIndex];
        this.items[this.frontIndex] = 0;
        this.frontIndex = (this.frontIndex + 1) % this.capacity;
        this.count--;
        return item;
    }

    public int Peek()
    {
        if (this.IsEmpty())
            throw new InvalidOperationException("Queue is empty");

        return this.items[this.frontIndex];
    }

    public override string ToString()
    {
        if (IsEmpty())
            return "[]";

        var queueArrayRep = this.items.Select(x => x.ToString())
            .ToArray();

        return $"[{string.Join(", ", queueArrayRep)}][F:{this.frontIndex}, R:{this.rearIndex}]";
    }

}