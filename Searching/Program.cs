WriteLine();
WriteLine("Linear Search");
WriteLine("=============");

static int LinearSearch(int[] input, int item)
{
	for (int i = 0; i < input.Length; i++)
		if (input[i] == item)
			return i;
	
	return -1;
}

static int BinarySearch(int[] array, int target)
{
	static int BinarySearch(int[] array, int target, int left, int right)
	{
		if (right < left)
			return -1;

		int middle = (left + right) / 2;

        if (array[middle] == target)
            return middle;

        if (target < array[middle])
            return BinarySearch(array, target, left, middle - 1);
        
		return BinarySearch(array, target, middle + 1, right);
    }

	return BinarySearch(array, target, 0, array.Length -1);
}

static int BinarySearchIterative(int[] array, int target)
{
    int left = 0;
    int right = array.Length - 1;

    while (left <= right)
    {
        int middle = (left + right) / 2;

        if (array[middle] == target)
            return middle;

        if (target < array[middle])
            right = middle - 1;
        else
            left = middle + 1;
    }

    return -1;
}

int[] input1 = { 1, 2, 3, 4, 8, 22 };
string input1Rep = string.Join(", ", input1);

WriteLine($"LinearSearch([{input1Rep}], 1), {LinearSearch(input1, 1)}");
WriteLine($"LinearSearch([{input1Rep}], 4), {LinearSearch(input1, 4)}");
WriteLine($"LinearSearch([{input1Rep}], 22), {LinearSearch(input1, 22)}");
WriteLine($"LinearSearch([{input1Rep}], 17), {LinearSearch(input1, 17)}");

WriteLine();
WriteLine("Binary Search");
WriteLine("=============");

WriteLine($"BinarySearch([{input1Rep}], 1), {BinarySearch(input1, 1)}");
WriteLine($"BinarySearch([{input1Rep}], 4), {BinarySearch(input1, 4)}");
WriteLine($"BinarySearch([{input1Rep}], 22), {BinarySearch(input1, 22)}");
WriteLine($"BinarySearch([{input1Rep}], 17), {BinarySearch(input1, 17)}");

WriteLine();
WriteLine("Binary Search Iterative");
WriteLine("=======================");

WriteLine($"BinarySearchIterative([{input1Rep}]),  {BinarySearchIterative(input1, 1)}");
WriteLine($"BinarySearchIterative([{input1Rep}], 4), {BinarySearchIterative(input1, 4)}");
WriteLine($"BinarySearchIterative([{input1Rep}], 22), {BinarySearchIterative(input1, 22)}");
WriteLine($"BinarySearchIterative([{input1Rep}], 17), {BinarySearchIterative(input1, 17)}");