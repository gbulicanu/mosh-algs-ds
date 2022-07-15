using static System.Console;

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

    public void Print()
    {
        for (int i = 0; i < this.count; i++)
            WriteLine(this.items[i]);
    }
}