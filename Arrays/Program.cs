// See https://aka.ms/new-console-template for more information
using static System.Console;

DynamicArray numbers = new(3);
numbers.Insert(10);
numbers.Insert(20);
numbers.Insert(30);
numbers.Insert(40);
numbers.RemoveAt(index: 3);
numbers.Print();
WriteLine(numbers.IndexOf(40));