class HashTable
{
    private readonly int capacity;
    private readonly Func<int, int> hashFunction;

    // Add(k, v)
    // Get(k): v
    // Remove(k)
    // Entry:
    // k: int
    // v: string
    // collisions: chaining
    // LinkedList<Entry>[]
    // [LL, LL, LL, LL, LL]

    LinkedList<Entry>?[] hashEntries;

    public HashTable(int capacity = 100)
    {
        this.capacity = capacity;
        this.hashFunction = (int key) => Math.Abs(key.GetHashCode() % capacity);
        this.hashEntries = new LinkedList<Entry>[capacity];
    }

    public void Add(int key, string? value)
    {
        int entryIndex = this.hashFunction(key);
        if (hashEntries[entryIndex] == null)
            hashEntries[entryIndex] = new LinkedList<Entry>(
                new Entry[] { new Entry { Key = key, Value = value } });
        else
            hashEntries[entryIndex]?.AddLast(new Entry { Key = key, Value = value });

    }

    public string? Get(int key)
    {
        int entryIndex = this.hashFunction(key);
        if (hashEntries[entryIndex] == null)
            throw new IndexOutOfRangeException();

        return hashEntries[entryIndex]?.FirstOrDefault(x => x.Key == key)?.Value;
    }

    public override string ToString()
    {
        string[] keyValuesReps = hashEntries.Where(x => x != null)
            .SelectMany(x => x!)
            .OrderBy(x => x.Key)
            .Select(x => $"{x.Key}={x.Value}")
            .ToArray();

        return string.Join(", ", keyValuesReps);
    }

    public void Remove(int key)
    {
        int entryIndex = this.hashFunction(key);
        hashEntries[entryIndex] = null;
    }

    class Entry
    {
        public int Key { get; set; }
        public string? Value { get; set; }
    }
}