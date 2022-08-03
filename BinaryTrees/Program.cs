WriteLine("");
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

// bst.Disorder();
WriteLine($"IsValid(bst): {bst.IsValid()}");

BinarySerachTree bst2 = new();

bst2.Insert(10);
bst2.Insert(5);
bst2.Insert(15);
bst2.Insert(6);
bst2.Insert(1);
bst2.Insert(8);
bst2.Insert(12);
bst2.Insert(18);
bst2.Insert(17);

BinarySerachTree bst3 = new();

bst3.Insert(9);
bst3.Insert(4);
bst3.Insert(14);

bool equal = bst.Equals(bst2);
WriteLine($"Equals(bst2): {equal}");
equal = bst.Equals(bst3);
WriteLine($"Equals(bst3): {equal}");

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

WriteLine($"Height: {bst.Height()}");
WriteLine($"Min: {bst.Min()}");
WriteLine($"MinFast: {bst.MinFast()}");

WriteLine();
WriteLine("Nodes at K distance");
WriteLine("===================");

var getNodesAtAndPrint = (BinarySerachTree tree, int distance) =>
{
    var list = tree.GetNodesAt(distance);
    foreach (var item in list)
        WriteLine(item ?? -1);
};

WriteLine("getNodesAtAndPrint(bst, 0)");
getNodesAtAndPrint(bst, 0);

WriteLine("getNodesAtAndPrint(bst, 1)");
getNodesAtAndPrint(bst, 1);

WriteLine("getNodesAtAndPrint(BinarySerachTree.Empty, 0)");
getNodesAtAndPrint(BinarySerachTree.Empty, 0);

WriteLine("getNodesAtAndPrint(bst, 3)");
getNodesAtAndPrint(bst, 3);

WriteLine("getNodesAtAndPrint(bst, 3)");
getNodesAtAndPrint(bst, 30);

WriteLine();
WriteLine("Traverse Level Order");
WriteLine("=====================");
bst.TraverseLevelOrder();


WriteLine();
WriteLine("AVL Tree");
WriteLine("========");

WriteLine("avl:");
AVLTree avl = new();

avl.Insert(10);
avl.Insert(5);
avl.Insert(15);
avl.Insert(6);
avl.Insert(1);
avl.Insert(8);
avl.Insert(12);
avl.Insert(18);
avl.Insert(17);

WriteLine("avl2:");
AVLTree avl2 = new();
avl2.Insert(10);
avl2.Insert(20);
avl2.Insert(30);

WriteLine("avl3:");
AVLTree avl3 = new();
avl3.Insert(30);
avl3.Insert(20);
avl3.Insert(10);
