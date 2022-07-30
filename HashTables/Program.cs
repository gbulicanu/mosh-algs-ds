using static System.Console;

// Find first non repeated character
// ex, 'a green apple' => 'g'

string input = "a green apple";

int notRepeatedIndex = FindFirstNotRepeatingIn(input);
WriteLine($"First no repeating character in '{input}' is" +
    $" '{input[notRepeatedIndex]}' found at index {notRepeatedIndex}.");

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