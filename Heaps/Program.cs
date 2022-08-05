WriteLine();
WriteLine("Heaps");
WriteLine("=====");

MaxHeap heapOneBubbleUp = new();
heapOneBubbleUp.Insert(20);
heapOneBubbleUp.Insert(10);
heapOneBubbleUp.Insert(15);
// here we bubble up one time
WriteLine($"heapOneBubbleUp: {heapOneBubbleUp}");

// Test more
heapOneBubbleUp.Insert(14);
heapOneBubbleUp.Insert(25);
heapOneBubbleUp.Insert(30);
WriteLine($"heapOneBubbleUp(more): {heapOneBubbleUp}");
heapOneBubbleUp.Remove();
WriteLine($"heapOneBubbleUp(removed): {heapOneBubbleUp}");

MaxHeap heapThoBubbleUp = new();
heapThoBubbleUp.Insert(20);
heapThoBubbleUp.Insert(10);
heapThoBubbleUp.Insert(15);
// here we bubble up two times
heapThoBubbleUp.Insert(22);
WriteLine($"heapTwoBubbleUp: {heapThoBubbleUp}");
