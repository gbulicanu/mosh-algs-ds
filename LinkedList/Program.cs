// See https://aka.ms/new-console-template for more information
using static System.Console;

LinkedList list = new();
WriteLine($"Length: {list.Length}");
list.AddFirst(2); // [2]
WriteLine($"Length: {list.Length}");
//list.DeleteLast();
//WriteLine(list);

list.AddLast(3); // [2,3]
list.AddFirst(1); // [1, 2, 3]

WriteLine($"Length: {list.Length}");

WriteLine("Initial:");
WriteLine(list);

list.AddLast(4);
list.AddLast(5);

WriteLine("After AddLast:");
WriteLine(list);

list.RemoveFirst();
WriteLine("After RemoveFirst:");
WriteLine(list);

list.RemoveLast();
WriteLine("After RemoveLast:");
WriteLine(list);

WriteLine($"Contains(3): {list.Contains(3)}");
WriteLine($"Contains(5): {list.Contains(5)}");
WriteLine($"Contains(4): {list.Contains(4)}");
WriteLine($"Contains(2): {list.Contains(2)}");

WriteLine($"IndexOf(3): {list.IndexOf(3)}");
WriteLine($"IndexOf(5): {list.IndexOf(5)}");
WriteLine($"IndexOf(4): {list.IndexOf(4)}");
WriteLine($"IndexOf(2): {list.IndexOf(2)}");

WriteLine(list);

list.AddFirst(1);
WriteLine(list);

list.Reverse();
WriteLine($"Reversed: {list}");

WriteLine("List2");
LinkedList list2 = new();
list2.AddLast(10);
list2.AddLast(20);
list2.AddLast(30);
list2.AddLast(40);
list2.AddLast(50);
list2.AddLast(60);
WriteLine(list2);
Write("Middle: ");
list2.PrintMiddle();
WriteLine($"list2.GetKthFromTheEnd(3): {list2.GetKthFromTheEnd(3)}");
WriteLine($"list2.GetKthFromTheEnd(2): {list2.GetKthFromTheEnd(2)}");
WriteLine($"list2.GetKthFromTheEnd(1): {list2.GetKthFromTheEnd(1)}");
WriteLine($"list2.GetKthFromTheEnd(0): {list2.GetKthFromTheEnd(0)}");
WriteLine($"list2.GetKthFromTheEnd(-1): {list2.GetKthFromTheEnd(-1)}");

//WriteLine($"list2.GetKthFromTheEnd(100): {list2.GetKthFromTheEnd(100)}");

WriteLine("Loop?");
LinkedList list3 = new();
list3.AddLast(10);
list3.AddLast(20);
list3.AddLast(30);
list3.AddLast(40);
list3.AddLast(50);
list3.AddLast(60);
list3.AddLoop();
WriteLine(list3.HasLoop());