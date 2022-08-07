WriteLine("");
WriteLine("Bubble Sort");
WriteLine("===========");

static void BubbleSort(int[] array)
{
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

int[] array = { 8, 2, 4, 1, 3 };
BubbleSort(array);
WriteLine($"array(after sorting):[{string.Join(", ", array)}]");

