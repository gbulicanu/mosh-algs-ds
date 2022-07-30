class StringReverser
{
    internal static string Reverse(string input)
    {
        ArgumentNullException.ThrowIfNull(input);
        Stack<char> charStack = new Stack<char>();
        foreach (var character in input)
        {
            charStack.Push(character);
        }

        StringBuilder result = new();
        while(charStack.Count != 0)
        {
            result.Append(charStack.Pop());
        }

        return result.ToString();
    }
}