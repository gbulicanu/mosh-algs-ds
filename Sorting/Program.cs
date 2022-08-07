

static void Swap(int[] array, int index1, int index2)
    => (array[index1], array[index2]) = (array[index2], array[index1]);

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
}

static void SelectionSort(int[]? array)
{
    if (array == null)
        return;

	for (int i = 0; i < array.Length - 1; i++)
	{
		int minIndex = i;
		for (int j = i; j < array.Length; j++)
		{
			if (array[j] >= array[minIndex])
				continue;

			minIndex = j;
		}
		Swap(array, minIndex, i);
    }
}

int[] array1 = { 8, 2, 4, 1, 3 };
int[] array2 = { 8, 2, 4, 1 };
int[] array3 = { 8, 4, 3, 1 };
int[] array4 = Array.Empty<int>();
int[]? array5 = null;

//WriteLine("");
//WriteLine("Bubble Sort");
//WriteLine("===========");

//BubbleSort(array1);
//BubbleSort(array2);
//BubbleSort(array3);
//BubbleSort(array4);
//BubbleSort(array5);
//WriteLine($"array1(after sorting):[{string.Join(", ", array1)}]");
//WriteLine($"array2(after sorting):[{string.Join(", ", array2)}]");
//WriteLine($"array3(after sorting):[{string.Join(", ", array3)}]");
//WriteLine($"array4(after sorting):[{string.Join(", ", array4)}]");

WriteLine("");
WriteLine("Selection Sort");
WriteLine("==============");

SelectionSort(array1);
SelectionSort(array2);
SelectionSort(array3);
SelectionSort(array4);
SelectionSort(array5);
WriteLine($"array1(after sorting):[{string.Join(", ", array1)}]");
WriteLine($"array2(after sorting):[{string.Join(", ", array2)}]");
WriteLine($"array3(after sorting):[{string.Join(", ", array3)}]");
WriteLine($"array4(after sorting):[{string.Join(", ", array4)}]");

