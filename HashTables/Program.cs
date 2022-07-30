using static System.Console;

// Find first non repeated character
// ex, 'a green apple' => 'g'

string input = "a green apple";
string inputRepeated = "green apple";

int notRepeatedIndex = FindFirstNotRepeatingIn(input);
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
        int currentCount = charsSet.Count;
        charsSet.Add(c);
        if (currentCount == charsSet.Count)
            return i;
    }

    return -1;
}