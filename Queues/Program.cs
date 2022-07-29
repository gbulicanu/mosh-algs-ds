using static System.Console;

static void Reverse(Queue<int> input)
{
    Stack<int> stack = new (input);
    input.Clear();
    while (stack.TryPop(out var value))
    {
        input.Enqueue(value);
    }
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

