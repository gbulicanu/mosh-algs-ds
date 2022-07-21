// See https://aka.ms/new-console-template for more information
using System.Text;
using static System.Console;

string input = "abcd";
Stack<char> stack = new(input);
StringReverser reverser = new();
var revereseOutput = reverser.Reverse(input);

WriteLine(new string(stack.ToArray()));
WriteLine(revereseOutput);

class StringReverser
{
    internal string Reverse(string input)
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