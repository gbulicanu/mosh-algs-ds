// See https://aka.ms/new-console-template for more information
using static System.Console;

//string input = "abcd";
//Stack<char> stack = new(input);
//string revereseOutput = StringReverser.Reverse(input);

//WriteLine(stack.ToArray());
//WriteLine(revereseOutput);

//string input = "[1 + 1]";

//bool isBalanced = BalancedExpressions.IsBalanced(input);
//WriteLine($"isBalanced('{input}'): {isBalanced}");

DynamicStack stack = new();

WriteLine(stack.IsEmpty());
//stack.Peek();
//stack.Pop();
stack.Push(1);
stack.Push(2);
stack.Push(3);
WriteLine($"Peek: {stack.Peek()}");
stack.Push(4);
stack.Push(5);
WriteLine($"Pop: {stack.Pop()}");
WriteLine(stack);