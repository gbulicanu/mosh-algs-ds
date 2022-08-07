

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
		int minIndex = FindMinIndexInUnsortedPart(array, i);
		Swap(array, minIndex, i);
	}

    static int FindMinIndexInUnsortedPart(int[] array, int i)
    {
        int minIndex = i;
        for (int j = i; j < array.Length; j++)
        {
            if (array[j] >= array[minIndex])
                continue;

            minIndex = j;
        }

        return minIndex;
    }
}

static void InsertionSort(int[]? array)
{
    if (array == null)
        return;

    for (int i = 1; i < array.Length; i++)
    {
        int current = array[i];
        int insertIndex = 0;

        for (int j = i - 1; j >= 0; j--)
            if (current < array[j])
            {
                array[j + 1] = array[j];
                insertIndex = j;
            }
        
        array[insertIndex] = current;
    }
}

int[] array1bs = { 8, 2, 4, 1, 3 };
int[] array2bs = { 8, 2, 4, 1 };
int[] array3bs = { 8, 4, 3, 1 };
int[] array4bs = Array.Empty<int>();
int[]? array5bs = null;

WriteLine("");
WriteLine("Bubble Sort");
WriteLine("===========");

BubbleSort(array1bs);
BubbleSort(array2bs);
BubbleSort(array3bs);
BubbleSort(array4bs);
BubbleSort(array5bs);
WriteLine($"array1bs(after sorting):[{string.Join(", ", array1bs)}]");
WriteLine($"array2bs(after sorting):[{string.Join(", ", array2bs)}]");
WriteLine($"array3bs(after sorting):[{string.Join(", ", array3bs)}]");
WriteLine($"array4bs(after sorting):[{string.Join(", ", array4bs)}]");

int[] array1ss = { 8, 2, 4, 1, 3 };
int[] array2ss = { 8, 2, 4, 1 };
int[] array3ss = { 8, 4, 3, 1 };
int[] array4ss = Array.Empty<int>();
int[]? array5ss = null;

WriteLine("");
WriteLine("Selection Sort");
WriteLine("==============");

SelectionSort(array1ss);
SelectionSort(array2ss);
SelectionSort(array3ss);
SelectionSort(array4ss);
SelectionSort(array5ss);
WriteLine($"array1ss(after sorting):[{string.Join(", ", array1ss)}]");
WriteLine($"array2ss(after sorting):[{string.Join(", ", array2ss)}]");
WriteLine($"array3ss(after sorting):[{string.Join(", ", array3ss)}]");
WriteLine($"array4ss(after sorting):[{string.Join(", ", array4ss)}]");

int[] array1is = { 8, 2, 4, 1, 3 };
int[] array2is = { 8, 2, 4, 1 };
int[] array3is = { 8, 4, 3, 1 };
int[] array4is = Array.Empty<int>();
int[]? array5is = null;

WriteLine("");
WriteLine("Insertion Sort");
WriteLine("==============");

InsertionSort(array1is);
InsertionSort(array2is);
InsertionSort(array3is);
InsertionSort(array4is);
InsertionSort(array5is);
WriteLine($"array1is(after sorting):[{string.Join(", ", array1is)}]");
WriteLine($"array2is(after sorting):[{string.Join(", ", array2is)}]");
WriteLine($"array3is(after sorting):[{string.Join(", ", array3is)}]");
WriteLine($"array4is(after sorting):[{string.Join(", ", array4is)}]");

