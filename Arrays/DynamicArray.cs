public class DynamicArray
{
    private int[] items;

    private int count = 0;

    public DynamicArray(int length)
    {
        this.items = new int[length];
    }

    public void Insert(int item)
    {
        if (items.Length == this.count)
        {
            int[] newItems = new int[this.count * 2];
            
            for (int i = 0; i < this.count; i++)
                newItems[i] = this.items[i];

            this.items = newItems;
            this.items[this.count] = item;
        }

        this.items[this.count++] = item;
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= count)
            throw new IndexOutOfRangeException();

        for (int i = index; i < this.count; i++)
            this.items[i] = items[i + 1];

        this.count--;
    }

    public int IndexOf(int value)
    {
        for (int i = 0; i < this.count; i++)
            if(this.items[i] == value)
                return i;

        return -1;
    }

    public int[] ToArray()
    {
        int[] result = new int[this.count];

        for (int i = 0; i < this.count; i++)
            result[i] = this.items[i];

        return result;
    }

    public static DynamicArray FromArray(int[] array)
    {
        DynamicArray result = new (array.Length);
        for (int i = 0; i < array.Length; i++)
            result.Insert(array[i]);

        return result;
    }

    public int Max() {
        // O(n)
        int max = 0;

        for (int i = 0; i < this.count; i++)
            if(this.items[i] > max)
                max = this.items[i];

        return max;
    }

    public DynamicArray Intersect(DynamicArray other)
    {
        // O(n ^ 2)
        int[] otherArray = other.ToArray();
        DynamicArray result = new (otherArray.Length);
        for (int i = 0; i < this.count; i++)
            for (int j = 0; j < otherArray.Length; j++)
                if(this.items[i] == otherArray[j])
                    result.Insert(this.items[i]);

        return result;
    }

    public void Reverse() 
    {
        // O(n)
        DynamicArray reversed = new(this.count);

        for (int i = this.count - 1; i >= 0; i--)
            reversed.Insert(this.items[i]);

        this.items = reversed.ToArray();
    }

    public void InsertAt(int item, int index)
    {
        // O(n)
        if(index < 0 || index > this.count - 1)
            throw new IndexOutOfRangeException();

        int itemNext = this.items[index];

        for (int i = index; i < this.count - 1; i++)
        {
            this.items[i] = item;
            item = this.items[i + 1];
            this.items[i + 1] = itemNext;
        }

        this.Insert(item);
    }

    public void Print()
    {
        for (int i = 0; i < this.count; i++)
            WriteLine(this.items[i]);
    }
}