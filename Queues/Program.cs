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

// StackQueue implementation
StackQueue arrayQueue = new ();
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

var topNow = arrayQueue.Peek();
WriteLine($"Peek: {topNow}");
WriteLine(arrayQueue);

WriteLine($"Dequeue: {arrayQueue.Dequeue()}");
WriteLine(arrayQueue);
WriteLine($"Dequeue: {arrayQueue.Dequeue()}");
WriteLine(arrayQueue);
WriteLine($"Dequeue: {arrayQueue.Dequeue()}");
WriteLine(arrayQueue);
// WriteLine("Attempt dequeue empty:");
// _ = arrayQueue.Dequeue();
// WriteLine(arrayQueue);
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
// var deq1 = arrayQueue.Dequeue();
// var deq2 = arrayQueue.Dequeue();
WriteLine(arrayQueue);

// PriorityQueue
WriteLine("");
WriteLine("PriorityQueue");
WriteLine("=============");
PriorityQueue priorityQueue = new ();
priorityQueue.Enqueue(10);
priorityQueue.Enqueue(30);
priorityQueue.Enqueue(50);
priorityQueue.Enqueue(70);
priorityQueue.Enqueue(20);
// Attempt to Enqueue on full queue.
// priorityQueue.Enqueue(70);
// priorityQueue.Enqueue(70);
// priorityQueue.Enqueue(70);
// priorityQueue.Enqueue(70);
// priorityQueue.Enqueue(70);
// priorityQueue.Enqueue(70);
WriteLine(priorityQueue);
_ = priorityQueue.Dequeue();
priorityQueue.Enqueue(60);
WriteLine(priorityQueue);
_ = priorityQueue.Dequeue();
WriteLine(priorityQueue);
_ = priorityQueue.Dequeue();
WriteLine(priorityQueue);
_ = priorityQueue.Dequeue();
WriteLine(priorityQueue);
_ = priorityQueue.Dequeue();
WriteLine(priorityQueue);
_ = priorityQueue.Dequeue();
WriteLine(priorityQueue);
// Attempt to Peek on empty queue
// _ = priorityQueue.Peek();