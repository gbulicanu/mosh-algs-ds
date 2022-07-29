class ArrayQueue
{
    readonly int capacity;

    int[] items;
    int frontIndex;
    int rearIndex;

    public ArrayQueue(int capacity = 10)
    {
        this.capacity = capacity;
        this.items = new int[capacity];
    }

    public bool IsFull()
    {
        return this.rearIndex == this.capacity;
    }

    public bool IsEmpty()
    {
        return this.rearIndex == 0 && this.frontIndex == 0;
    }

    public void Enqueue(int item)
    {
        if (this.IsFull())
            throw new InvalidOperationException("Queue is full");

        this.items[this.rearIndex++] = item;
    }

    public int Dequeue()
    {
        if (this.IsEmpty())
            throw new InvalidOperationException("Queue is empty");

        var result = this.items[this.frontIndex++];
        if(this.frontIndex == this.rearIndex)
            this.frontIndex = this.rearIndex = 0;

        return result;
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

        var queueArray = new int[this.Count];

        Array.Copy(this.items, this.frontIndex, queueArray, 0, this.Count);
        var queueArrayRep = queueArray
            .Select(x => x.ToString())
            .ToArray();

        return $"[{string.Join(", ", queueArrayRep)}]";
    }

    public int Count { get { return this.rearIndex - this.frontIndex; } }
}