class MaxHeap
{
    readonly int capacity;
    readonly int[] items;

    int count;

    public MaxHeap(int capacity = 100)
    {
        this.capacity = capacity;
        this.items = new int[capacity];
    }

    public void Insert(int item)
    {
        if (count == capacity)
            throw new InvalidOperationException("Heap is at capacity");

        if (count == 0)
        {
            this.items[count++] = item;
            return;
        }

        int parentIndex = GetParentIndex(count);
        int leftIndex = GetLeftIndex(parentIndex);
        int rightIndex = GetRightIndex(parentIndex);

        if (count % 2 != 0)
        {
            this.items[leftIndex] = item;
            if (this.items[parentIndex] < item)
                BubbleUp(parentIndex, leftIndex, isLeft: true);
        }
        else
        {
            this.items[rightIndex] = item;
            if (this.items[parentIndex] < item)
                BubbleUp(parentIndex, rightIndex, isLeft: false);
        }

        this.count++;
    }

    private static int GetRightIndex(int parentIndex)
    {
        return (parentIndex * 2) + 2;
    }

    private static int GetLeftIndex(int parentIndex)
    {
        return (parentIndex * 2) + 1;
    }

    public void Remove()
    {
        if (count == 0)
            throw new InvalidOperationException("Heap is empty");

        if (count == 1)
        {
            this.count = 0;
            return;
        }

        this.items[0] = this.items[--this.count];
        BubbleDown(0, 1, 2);
    }

    private void Swap(int firstIndex, int secondIndex)
        => (this.items[firstIndex], this.items[secondIndex]) =
            (this.items[secondIndex], this.items[firstIndex]);

    private static int GetParentIndex(int currentIndex)
        => (currentIndex - 1) / 2;

    private void BubbleUp(int parentIndex, int index, bool isLeft)
    {
        Swap(index, parentIndex);
        int newParentIndex = GetParentIndex(isLeft
            ? index - 1
            : parentIndex - 1);

        if (newParentIndex >= 0
            && this.items[parentIndex] > this.items[newParentIndex])
            BubbleUp(newParentIndex, parentIndex, !isLeft);
    }

    private void BubbleDown(int parentIndex, int leftIndex, int rightIndex)
    {
        if (this.count == 1)
        {
            this.count = 0;
            return;
        }

        int newParent, newLeftIndex, newRightIndex;
        if (leftIndex > count)
        {
            newParent = GetParentIndex(this.count - 1);
            if (this.items[newParent] < this.items[this.count - 1])
            {
                newLeftIndex = GetLeftIndex(newParent);
                newRightIndex = GetRightIndex(newParent);
                BubbleDown(newParent, newLeftIndex, newRightIndex);
            }
            return;
        }

        newParent = leftIndex;
        if (this.items[leftIndex] > this.items[rightIndex])
        {
            Swap(parentIndex, leftIndex);
            newLeftIndex = GetLeftIndex(newParent);
            newRightIndex = GetRightIndex(newParent);
            BubbleDown(newParent, newLeftIndex, newRightIndex);
        }
        else
        {
            Swap(parentIndex, rightIndex);
            newParent = rightIndex;
            newLeftIndex = GetLeftIndex(newParent);
            newRightIndex = GetRightIndex(newParent);
            BubbleDown(newParent, newLeftIndex, newRightIndex);
        }
    }

    public override string ToString()
    {
        return "[" +
            $"{string.Join(", ", this.items.Take(this.count).ToArray())}" +
            "]";
    }
}