WriteLine();
WriteLine("Count Vowels");
WriteLine("============");

string? input = "hello";
string? input1 = "Trees are beautiful";

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
        return string.Empty;

    StringBuilder reversed = new();
    for (int i = input.Length - 1; i >= 0; i--)
        reversed.Append(input[i]);

    return reversed.ToString();
}

static string? ReverseWords(string? input)
{
    if (input == null)
        return string.Empty;

    StringBuilder reversed = new();
    string[] words = input.Split(" ");
    for (int i = words.Length - 1; i >= 0; i--)
        reversed.Append(words[i])
            .Append(' ');
    reversed.Remove(reversed.Length - 1, 1);

    return reversed.ToString();
}

WriteLine($"CountVowels(\"{input}\"): {CountVowels(input)}");
WriteLine($"Reverse(\"{input}\"): {Reverse(input)}");
WriteLine($"ReverseWords(\"{input1}\"): {ReverseWords(input1)}");