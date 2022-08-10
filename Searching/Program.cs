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

static int BinarySearch(int[] input, int item)
{
	static int BinarySearch(int[] input, int item, int start, int end)
	{
		if (start > end)
			return -1;

		if (input[start] == item)
			return start;

		int middle = (start + end) / 2;
		if (input[middle] < item)
			return BinarySearch(input, item, middle + 1, end);
		else
			return BinarySearch(input, item, start, middle - 1);
    }

	Array.Sort(input);

	return BinarySearch(input, item, 0, input.Length -1);
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

WriteLine($"LinearSearch([{input1Rep}], 1), {BinarySearch(input1, 1)}");
WriteLine($"LinearSearch([{input1Rep}], 4), {BinarySearch(input1, 4)}");
WriteLine($"LinearSearch([{input1Rep}], 22), {BinarySearch(input1, 22)}");
WriteLine($"LinearSearch([{input1Rep}], 17), {BinarySearch(input1, 17)}");