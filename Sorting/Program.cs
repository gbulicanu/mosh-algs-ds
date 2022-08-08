

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
    static void DevideIntoHalfs(int[] array, out int[] left, out int[] right)
    {
        int middle = array.Length / 2;
        int rightLength = middle + array.Length % 2;
        left = new int[middle];
        right = new int[rightLength];
        Array.Copy(array, left, middle);
        Array.ConstrainedCopy(array, middle, right, 0, rightLength);
    }

    static void MergeResults(int[] array, int[] left, int[] right)
    {
        int i = 0, j = 0;

        while ((i < left.Length && j < right.Length))
        {
            if (left[i] >= right[j])
            {
                array[i + j] = right[j++];
                array[i + j] = Math.Max(left[i], right[j - 1]);
                continue;
            }
            else
            {
                array[i + j] = left[i++];
                array[i + j] = Math.Max(left[i - 1], right[j]);
            }
        }

        if (right.Length > 0 && array[^1] < array[^2])
            array[^1] = Math.Max(left[^1], right[^1]);
    }

    if (array == null)
        return;

    if (array.Length == 1 || array.Length == 0)
        return;

    DevideIntoHalfs(array, out var left, out var right);
    MergeSort(left);
    MergeSort(right);
    MergeResults(array, left, right);
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

WriteLine("");
WriteLine("Merge Sort");
WriteLine("===========");

int[] array1ms = { 8, 2, 4, 1, 3 };
int[] array2ms = { 8, 2, 4, 1 };
int[] array3ms = { 10, 6, 5, 4, 30, 30, 2, 1 };
int[] array4ms = Array.Empty<int>();
int[]? array5ms = null;

MergeSort(array3ms);
MergeSort(array1ms);
MergeSort(array2ms);
MergeSort(array4ms);
MergeSort(array5ms);
WriteLine($"array1ms(after sorting):[{string.Join(", ", array1ms)}]");
WriteLine($"array2ms(after sorting):[{string.Join(", ", array2ms)}]");
WriteLine($"array3ms(after sorting):[{string.Join(", ", array3ms)}]");
WriteLine($"array4ms(after sorting):[{string.Join(", ", array4ms)}]");

