// See https://aka.ms/new-console-template for more information
using static System.Console;

//string input = "abcd";
//Stack<char> stack = new(input);
//string revereseOutput = StringReverser.Reverse(input);

//WriteLine(stack.ToArray());
//WriteLine(revereseOutput);

string input = "[1 + 1]";

bool isBalanced = BalancedExpressions.IsBalanced(input);
WriteLine($"isBalanced('{input}'): {isBalanced}");
