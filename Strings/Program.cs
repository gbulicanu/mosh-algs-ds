WriteLine();
WriteLine("Count Vowels");
WriteLine("============");

string input = "hello";

static int CountVowels(string input)
{
    if (input == null)
        return 0;

    string vowels = "aeiou";
    int count = 0;
    foreach (char c in input.ToLower())
        if (vowels.IndexOf(c) != -1)
            count++;

    return count;

}

WriteLine($"CountVowels(\"{input}\"): {CountVowels(input)}");