﻿// See https://aka.ms/new-console-template for more information
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

