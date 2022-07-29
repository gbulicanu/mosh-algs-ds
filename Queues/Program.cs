using static System.Console;

static void Reverse(Queue<int> input)
{
    Stack<int> stack = new ();
    while (input.Count > 0)
        stack.Push(input.Dequeue());
    while (stack.Count > 0)
        input.Enqueue(stack.Pop());
}

static void PrintQueue(Queue<int> input)
{
    var array = input.ToArray()
        .Select(x => x.ToString())
        .ToArray();
    WriteLine($"[{string.Join(", ", array)}]");
}

Queue<int> input = new();
input.Enqueue(10);
input.Enqueue(20);
input.Enqueue(30);

Reverse(input);

PrintQueue(input);

