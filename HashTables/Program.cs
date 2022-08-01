// Find first non repeated character
// ex, 'a green apple' => 'g'

string input = "a green apple";
string inputRepeated = "green apple";

int notRepeatedIndex = FindFirstNotRepeatingIn(input);
WriteLine("Find first repeating/non-repeating character");
WriteLine("============================================");
WriteLine($"First no repeating character in '{input}' is" +
    $" '{input[notRepeatedIndex]}' found at index {notRepeatedIndex}.");

int repeatedIndex = FindFirstRepeatingIn(inputRepeated);
WriteLine($"First repeating character in '{inputRepeated}' is" +
    $" '{inputRepeated[repeatedIndex]}' found at index {repeatedIndex}.");

int FindFirstNotRepeatingIn(string input)
{
    Dictionary<char, int> charsMap = new();

	for (int i = 0; i < input.Length; i++)
	{
		char c = input[i];
		int currentCount = charsMap.ContainsKey(c) ? charsMap[c] : 0;
		charsMap[c] = ++currentCount;
	}

	for (int i = 0; i < input.Length; i++)
		if (charsMap[input[i]] == 1)
			return i;

	return -1;
}

int FindFirstRepeatingIn(string input)
{
    HashSet<char> charsSet = new();

    for (int i = 0; i < input.Length; i++)
    {
        char c = input[i];
        if (charsSet.Contains(c))
            return i;
        
        charsSet.Add(c);
    }

    return -1;
}

WriteLine();
WriteLine("HashTable");
WriteLine("=========");
HashTable hashTable = new();
hashTable.Add(10, "Ten");
hashTable.Add(20, "Twenty");
hashTable.Add(30, "Thirty");
hashTable.Add(40, "Fourty");
hashTable.Add(110, "One hundred and ten");
hashTable.Add(111, "One hundred and eleven");
WriteLine(hashTable);
WriteLine(hashTable.Get(10));
WriteLine(hashTable.Get(30));
WriteLine(hashTable.Get(110));