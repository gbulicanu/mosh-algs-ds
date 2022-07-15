internal class DynamicArray
{
    private int[] arrayStore;

    private int initialSize;
    private int currentSize = 0;

    public DynamicArray(int initialSize)
    {
        this.initialSize = initialSize;
        this.arrayStore = new int[initialSize];
    }

    internal void Insert(int value)
    {
        if(currentSize < initialSize)
        {
            this.arrayStore[this.currentSize] = value;
            this.currentSize++;
        }
        else
        {
            int[] arrayToGrow = new int[this.currentSize + this.initialSize];
            for (int i = 0; i < this.arrayStore.Length; i++)
            {
                arrayToGrow[i] = this.arrayStore[i];
            }
            this.arrayStore = arrayToGrow;
            this.arrayStore[this.currentSize] = value;
        }
    }

    internal void RemoveAt(int index)
    {
        if(index == this.currentSize)
        {
            this.arrayStore[this.currentSize] = 0;
            this.currentSize--;
        }
        else if(index >= 0 && index < this.currentSize)
        {
            this.arrayStore[index] = 0;
            for (int i = index; i < this.currentSize; i++)
            {
                this.arrayStore[i] = this.arrayStore[i + 1]; 
            }
            this.currentSize--;
        }
    }

    internal int IndexOf(int value)
    {
        for (int i = 0; i < this.arrayStore.Length; i++)
        {
            if(this.arrayStore[i] == value)
            {
                return i;
            }
        }

        return -1;
    }

    internal void Print()
    {
        Console.Write("[");
        for (int i = 0; i <= this.currentSize; i++)
        {
            Console.Write(this.arrayStore[i]);
            if (i != this.currentSize) 
            {
                Console.Write(",");
            }
        }
        Console.WriteLine("]");
    }
}