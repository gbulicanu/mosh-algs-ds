// See https://aka.ms/new-console-template for more information
using static System.Console;

var p = (string value) => WriteLine(value);
var pb = (char[]? buffer) => WriteLine(buffer);

string input = "abcd";
Stack<char> stack = new(input);
string revereseOutput = StringReverser.Reverse(input);

pb(stack.ToArray());
p(revereseOutput);
