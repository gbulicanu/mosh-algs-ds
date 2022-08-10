WriteLine();
WriteLine("Count Vowels");
WriteLine("============");

string? input = "hello";

static int CountVowels(string? input)
{
    if (input == null)
        return 0;

    const string vowels = "aeiou";
    int count = 0;
    foreach (char c in input.ToLower())
        if (vowels.IndexOf(c) != -1)
            count++;

    return count;
}

static string? Reverse(string? input)
{
    if (input == null)
        return null;

    StringBuilder reversed = new();
    for (int i = input.Length - 1; i >= 0; i--)
        reversed.Append(input[i]);

    return reversed.ToString();
}

WriteLine($"CountVowels(\"{input}\"): {CountVowels(input)}");
WriteLine($"Reverse(\"{input}\"): {Reverse(input)}");