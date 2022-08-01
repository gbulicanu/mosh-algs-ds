﻿WriteLine("");
WriteLine("Binary Trees");
WriteLine("============");

BinarySerachTree bst = new();

WriteLine("Insert(10)");
bst.Insert(10);
WriteLine("Insert(5)");
bst.Insert(5);
WriteLine("Insert(15)");
bst.Insert(15);
WriteLine("Insert(6)");
bst.Insert(6);
WriteLine("Insert(1)");
bst.Insert(1);
WriteLine("Insert(8)");
bst.Insert(8);
WriteLine("Insert(12)");
bst.Insert(12);
WriteLine("Insert(18)");
bst.Insert(18);
WriteLine("Insert(17)");
bst.Insert(17);

WriteLine($"Find(1): {bst.Find(1)}");
WriteLine($"Find(2): {bst.Find(2)}");
WriteLine($"Find(3): {bst.Find(3)}");
WriteLine($"Find(17): {bst.Find(17)}");

WriteLine("Depth First - TraversePreOrder:");
bst.TraversePreOrder();
WriteLine("Depth First - TraverseInOrder:");
bst.TraverseInOrder();
WriteLine("Depth First - PostOrder:");
bst.TraversePostOrder();

