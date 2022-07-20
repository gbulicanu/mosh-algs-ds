// See https://aka.ms/new-console-template for more information
using static System.Console;

Stack<char> stack = new("abcd");

Write(new string(stack.ToArray()));