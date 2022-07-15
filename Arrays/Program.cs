// See https://aka.ms/new-console-template for more information
using static System.Console;

DynamicArray numbers = new(3);
numbers.Insert(10);
numbers.Insert(20);
numbers.Insert(30);
numbers.Insert(40);
numbers.RemoveAt(index: 3);

numbers.Print();

WriteLine("numbers.InsertAt(15, 1):");
numbers.InsertAt(15, 1);
numbers.Print();

WriteLine("numbers.InsertAt(100, 3):");
numbers.InsertAt(100, 3);
numbers.Print();

WriteLine("numbers.InsertAt(1000, 0):");
numbers.InsertAt(1000, 0);
numbers.Print();

numbers.Reverse();

WriteLine("Reverse:");
numbers.Print();

WriteLine(numbers.IndexOf(40));

WriteLine($"Max: {numbers.Max()}");

DynamicArray intersected = numbers.Intersect(DynamicArray.FromArray(new int[] { 10, 25, 20 }));
WriteLine($"Intersect with [10, 15, 20]:");
intersected.Print();

