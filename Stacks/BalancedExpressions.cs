class BalancedExpressions
{
    const string openingBrackets = "([<{";
    const string closingBrackets = ")]>}";

    internal static bool IsBalanced(string input)
    {
        ArgumentNullException.ThrowIfNull(input);

        if (input.Length == 0)
            return false;

        Stack<char> openingBraceStack = new();
        foreach (char c in input)
        {
            if (IsLeftBracket(c))
                openingBraceStack.Push(c);

            if (IsRightBracket(c))
            {
                if (openingBraceStack.Count == 0) return false;
                char top = openingBraceStack.Pop();
                if (!BracketsMatch(top, c)) return false;
            }
        }

        return true;
    }

    static bool IsLeftBracket(char c)
    {
        return openingBrackets.Contains(c);
    }

    static bool IsRightBracket(char c)
    {
        return closingBrackets.Contains(c);
    }

    static bool BracketsMatch(char left, char right)
    {
        return openingBrackets.IndexOf(left) ==
            closingBrackets.IndexOf(right);
    }
}