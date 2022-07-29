class StackQueue
{
    readonly int capacity;

    Stack<int> queueStack;
    Stack<int> headStack;

    int count;

    public StackQueue(int capacity = 10)
    {
        this.capacity = capacity;
        this.queueStack = new (capacity);
        this.headStack = new(capacity);
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

        if (this.headStack.TryPop(out var top))
            this.queueStack.Push(top);
        else if (this.headStack.TryPop(out var bottom))
            this.queueStack.Push(bottom);

        this.headStack.Push(item);

        count++;
    }

    public int Dequeue()
    {
        if (this.IsEmpty())
            throw new InvalidOperationException("Queue is empty");

        var item = this.headStack.Pop();

        if (this.queueStack.TryPop(out var top))
            this.headStack.Push(top);

        this.count--;
        return item;
    }

    public int Peek()
    {
        if (this.IsEmpty())
            throw new InvalidOperationException("Queue is empty");

        return this.headStack.Peek();
    }

    public override string ToString()
    {
        if (IsEmpty())
            return "[]";

        var queueArrayRep = this.queueStack.ToArray()
            .Reverse()
            .Union(this.headStack.ToArray().Reverse())
            .Select(x => x.ToString())
            .ToArray();

        return $"[{string.Join(", ", queueArrayRep)}]";
    }

}