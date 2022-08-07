WriteLine("");
WriteLine("Bubble Sort");
WriteLine("===========");

static void BubbleSort(int[]? array)
{
	if (array == null)
		return;

	int passesRequired = array.Length / 2 + 1;

	int pass = 0;
	while (pass < passesRequired)
	{
		for (int i = 0; i < array.Length - 1; i++)
		{
			if (array[i] > array[i + 1])
				(array[i], array[i + 1]) = (array[i + 1], array[i]);
		}
		pass++;
	}
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

