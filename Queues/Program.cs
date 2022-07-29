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

// Reverse queue
Queue<int> input = new();
input.Enqueue(10);
input.Enqueue(20);
input.Enqueue(30);

Reverse(input);

PrintQueue(input);

// ArrayQueue implementation
ArrayQueue arrayQueue = new ();
WriteLine(arrayQueue);
WriteLine($"IsFull: {arrayQueue.IsFull()}");
WriteLine($"IsEmpty: {arrayQueue.IsEmpty()}");
WriteLine("Enqueue(10)");
arrayQueue.Enqueue(10);
WriteLine(arrayQueue);
WriteLine($"IsFull: {arrayQueue.IsFull()}");
WriteLine($"IsEmpty: {arrayQueue.IsEmpty()}");
arrayQueue.Enqueue(20);
arrayQueue.Enqueue(30);
WriteLine(arrayQueue);

WriteLine($"Peek: {arrayQueue.Peek()}");
WriteLine(arrayQueue);

WriteLine($"Dequeue: {arrayQueue.Dequeue()}");
WriteLine(arrayQueue);
WriteLine($"Dequeue: {arrayQueue.Dequeue()}");
WriteLine(arrayQueue);
WriteLine($"Dequeue: {arrayQueue.Dequeue()}");
WriteLine(arrayQueue);
//WriteLine("Attempt dequeue empty:")
//WriteLine(arrayQueue);
arrayQueue.Enqueue(10);
arrayQueue.Enqueue(20);
arrayQueue.Enqueue(30);
arrayQueue.Enqueue(40);
arrayQueue.Enqueue(50);
arrayQueue.Enqueue(60);
arrayQueue.Enqueue(70);
arrayQueue.Enqueue(80);
arrayQueue.Enqueue(90);
arrayQueue.Enqueue(100);
// WriteLine("Attempt enqueue on full:");
// arrayQueue.Enqueue(110);
WriteLine(arrayQueue);
