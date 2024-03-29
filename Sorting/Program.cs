﻿

static void Swap(int[] array, int index1, int index2)
    => (array[index1], array[index2]) = (array[index2], array[index1]);

static int MinMax(int[] array, bool min = true)
{
    int minMax = min ? int.MaxValue : int.MinValue;
    for (int i = 0; i < array.Length; i++)
    {
        if (!min && array[i] > minMax)
            minMax = array[i];
        
        if (min && array[i] < minMax)
            minMax = array[i];
    }

    return minMax;
}

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

static void CountingSort(int[]? array)
{
    static int[] BuildCounts(int[] array, int max)
    {
        int[] result = new int[max + 1];
        foreach (int item in array)
            result[item]++;

        return result;
    }

    static void Sort(int[] array, int max) {
        int k = 0;
        int[] counts = BuildCounts(array, max);
        for (int i = 0; i < counts.Length; i++)
            for (int j = 0; j < counts[i]; j++)
                array[k++] = i;
    }

    if (array == null || array.Length < 2)
        return;

    Sort(array, MinMax(array, min: false));
}

static void BucketSort(int[]? array)
{
    static List<int>[] CreateBuckets(int[] array, int numberOfBuckets)
    {
        List<int>[] buckets = new List<int>[numberOfBuckets];
        for (int i = 0; i < numberOfBuckets; i++)
        {
            buckets[i] = new List<int>();
        }

        for (int i = 0; i < array.Length; i++)
        {
            var selectedBucket = (array[i] / numberOfBuckets);
            buckets[selectedBucket].Add(array[i]);
        }

        return buckets;
    }

    if (array == null || array.Length < 2)
        return;

    int min = MinMax(array, min: true);
    int k = 0;
    List<int>[] buckets = CreateBuckets(array, array.Length / 2 + min + 1);
    foreach (List<int> bucket in buckets)
    {
        if (bucket.Count > 1)
        {
            int[] bucketArray = bucket.ToArray();
            QuickSort(bucketArray);
            foreach (var item in bucketArray)
                array[k++] = item;
        }
        else if(bucket.Count == 1)
            array[k++] =  bucket[0];
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

WriteLine("");
WriteLine("Counting Sort");
WriteLine("=============");

int[] array1cs = { 15, 6, 3, 1, 22, 10, 13 };
int[] array2cs = { 8, 2, 4 };
int[] array3cs = { 10, 6, 5, 4, 30, 30, 2, 1 };
int[] array4cs = Array.Empty<int>();
int[]? array5cs = null;

CountingSort(array1cs);
CountingSort(array2cs);
CountingSort(array3cs);
CountingSort(array4cs);
CountingSort(array5cs);
WriteLine($"array1cs(after sorting):[{string.Join(", ", array1cs)}]");
WriteLine($"array2cs(after sorting):[{string.Join(", ", array2cs)}]");
WriteLine($"array3cs(after sorting):[{string.Join(", ", array3cs)}]");
WriteLine($"array4cs(after sorting):[{string.Join(", ", array4cs)}]");

WriteLine("");
WriteLine("Bucket Sort - /w QuickSort");
WriteLine("===========================");

int[] array1bq = { 15, 6, 3, 1, 22, 10, 13 };
int[] array2bq = { 8, 2, 4 };
int[] array3bq = { 10, 6, 5, 4, 30, 30, 2, 1 };
int[] array4bq = Array.Empty<int>();
int[]? array5bq = null;

BucketSort(array1bq);
BucketSort(array2bq);
BucketSort(array3bq);
BucketSort(array4bq);
BucketSort(array5bq);
WriteLine($"array1bq(after sorting):[{string.Join(", ", array1bq)}]");
WriteLine($"array2bq(after sorting):[{string.Join(", ", array2bq)}]");
WriteLine($"array3bq(after sorting):[{string.Join(", ", array3bq)}]");
WriteLine($"array4bq(after sorting):[{string.Join(", ", array4bq)}]");