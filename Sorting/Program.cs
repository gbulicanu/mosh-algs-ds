

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
        int j = i - 1;

        while (j >= 0 && array[j] > current)
        {
            array[j + 1] = array[j];
            j--;
        }
        array[j + 1] = current;
    }
}

static void MergeSort(int[]? array)
{
    static (int[] left, int[] right)
        DevideIntoHalfs(int[] array)
    {
        int middle = array.Length / 2;

        int[] left = new int[middle];
        for (int i = 0; i < middle; i++)
            left[i] = array[i];

        int[] right = new int[middle + array.Length % 2];
        for (int i = middle; i < array.Length; i++)
            right[i - middle] = array[i];

        return (left, right);
    }

    static void MergeSorted(int[] array, int[] left, int[] right)
    {
        int i = 0, j = 0, k = 0;

        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
                array[k++] = left[i++];
            else
                array[k++] = right[j++];
        }

        while (i < left.Length)
            array[k++] = left[i++];

        while (j < right.Length)
            array[k++] = right[j++];
    }

    if (array == null)
        return;

    if (array.Length == 1 || array.Length == 0)
        return;

    var (left, right) = DevideIntoHalfs(array);
    MergeSort(left);
    MergeSort(right);
    MergeSorted(array, left, right);
}

static void QuickSort(int[]? array)
{
    static int Partition(int[] array, int start, int end)
    {
        var pivot = array[end];
        int boundary = start - 1;

        for (int i = start; i <= end; i++)
            if (array[i] <= pivot)
                Swap(array, i, ++boundary);

        return boundary;
    }

    static void Sort(int[] array, int start, int end)
    {
        if (start >= end)
            return;

        var boudary = Partition(array, start, end);
        Sort(array, start, boudary - 1);
        Sort(array, boudary + 1, end);
    }

    if (array == null)
        return;

    if (array.Length < 1)
        return;

    Sort(array, 0, array.Length - 1);
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

int[] array1ss = { 15, 6, 3, 1, 22, 10, 13 };
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

WriteLine("");
WriteLine("Merge Sort");
WriteLine("===========");

int[] array1ms = { 8, 2, 4, 1, 3 };
int[] array2ms = { 8, 2, 4 };
int[] array3ms = { 10, 6, 5, 4, 30, 30, 2, 1 };
int[] array4ms = Array.Empty<int>();
int[]? array5ms = null;

MergeSort(array1ms);
MergeSort(array2ms);
MergeSort(array3ms);
MergeSort(array4ms);
MergeSort(array5ms);
WriteLine($"array1ms(after sorting):[{string.Join(", ", array1ms)}]");
WriteLine($"array2ms(after sorting):[{string.Join(", ", array2ms)}]");
WriteLine($"array3ms(after sorting):[{string.Join(", ", array3ms)}]");
WriteLine($"array4ms(after sorting):[{string.Join(", ", array4ms)}]");

WriteLine("");
WriteLine("Quick Sort");
WriteLine("===========");

int[] array1qs = { 15, 6, 3, 1, 22, 10, 13 }; // 6 3 1 10 P13 15 22
int[] array2qs = { 8, 2, 4 };
int[] array3qs = { 10, 6, 5, 4, 30, 30, 2, 1 };
int[] array4qs = Array.Empty<int>();
int[]? array5qs = null;

QuickSort(array1qs);
QuickSort(array2qs);
QuickSort(array3qs);
QuickSort(array4qs);
QuickSort(array5qs);
WriteLine($"array1qs(after sorting):[{string.Join(", ", array1qs)}]");
WriteLine($"array2qs(after sorting):[{string.Join(", ", array2qs)}]");
WriteLine($"array3qs(after sorting):[{string.Join(", ", array3qs)}]");
WriteLine($"array4qs(after sorting):[{string.Join(", ", array4qs)}]");