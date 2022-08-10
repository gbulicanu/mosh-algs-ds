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

static string? ReverseWords(string? sentence)
{
    if (sentence == null)
        return string.Empty;

    string[] words = sentence.Trim().Split(" ");
    Array.Reverse(words);

    return string.Join(' ', words);
}

static bool AreRotation(string? input1, string? input2)
    => (!string.IsNullOrWhiteSpace(input1)
        && !string.IsNullOrWhiteSpace(input2)
        && input1.Length == input2.Length
        && (input1 + input1).Contains(input2));

static string RemoveDuplicates(string input)
{
    StringBuilder output = new();
    HashSet<char> seen = new();
    foreach (char c in input.ToLower())
        if (!seen.Contains(c))
        {
            seen.Add(c); output.Append(c);
        }

    return output.ToString();
}

string? input = "hello";
string? input1 = "Trees are beautiful";
string? inputRotation1 = "ABCD";
string? inputRotation2 = "DABC";

WriteLine($"CountVowels(\"{input}\"): {CountVowels(input)}");
WriteLine($"Reverse(\"{input}\"): {Reverse(input)}");
WriteLine($"ReverseWords(\"{input1}\"): {ReverseWords(input1)}");
WriteLine($"AreRotation(\"{inputRotation1}\", " +
    $"\"{inputRotation2}\"): {AreRotation(inputRotation1, inputRotation2)}");
WriteLine($"RemoveDuplicates(\"{input}\"): {RemoveDuplicates(input)}");