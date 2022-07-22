class BalancedExpressions
{
    const string openingBraces = "([<{";
    const string closingBraces = ")]>}";

    internal static bool IsBalanced(string input)
    {
        ArgumentNullException.ThrowIfNull(input);

        if (input.Length == 0)
            return false;

        Stack<char> openingBraceStack = new();
        foreach (char c in input)
        {
            if(closingBraces.Contains(c) && openingBraceStack.Count == 0)
                return false;

            if (openingBraces.Contains(c))
            {
                openingBraceStack.Push(c);                
            }

            if (closingBraces.Contains(c)
                && openingBraceStack.TryPop(out var lastOpenedBrace)
                && openingBraces.IndexOf(lastOpenedBrace) != closingBraces.IndexOf(c))
                return false;
        }

        return true;
    }
}