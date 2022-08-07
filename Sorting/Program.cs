WriteLine("");
WriteLine("Bubble Sort");
WriteLine("===========");

static void BubbleSort(int[]? array)
{
	if (array == null)
		return;
    
	bool isSorted = true;

	for (int i = 0; i < array.Length; i++)
	{
		for (int j = 1; j < array.Length - i; j++)
			if (array[j] < array[j - 1])
			{
				Swap(array, j, j - 1);
				isSorted = false;
			}

		if (isSorted)
			return;
	}

	static void Swap(int[] array, int index1, int index2)
		=> (array[index1], array[index2]) = (array[index2], array[index1]);
}

int[] array1 = { 8, 2, 4, 1, 3 };
int[] array2 = { 8, 2, 4, 1 };
int[] array3 = { 8, 4, 3, 1 };
int[] array4 = Array.Empty<int>();
int[]? array5 = null;

BubbleSort(array1);
BubbleSort(array2);
BubbleSort(array3);
BubbleSort(array4);
BubbleSort(array5);
WriteLine($"array1(after sorting):[{string.Join(", ", array1)}]");
WriteLine($"array2(after sorting):[{string.Join(", ", array2)}]");
WriteLine($"array3(after sorting):[{string.Join(", ", array3)}]");
WriteLine($"array4(after sorting):[{string.Join(", ", array4)}]");

