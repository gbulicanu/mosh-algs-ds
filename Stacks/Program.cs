//string input = "abcd";
//Stack<char> stack = new(input);
//DynamicStack dynStack = new();
//dynStack.Push(1);
//dynStack.Push(2);
//dynStack.Push(3);
//dynStack.Push(4);
//string revereseOutput = StringReverser.Reverse(input);

//WriteLine(stack.ToArray());
//Array.ForEach(dynStack.ToArray(), i => Write(i));
//WriteLine();
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