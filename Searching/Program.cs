WriteLine();
WriteLine("Linear Search");
WriteLine("=============");

int LinearSearch(int[] input, int item)
{
	for (int i = 0; i < input.Length; i++)
		if (input[i] == item)
			return i;
	
	return -1;
}

int[] input1 = { 1, 2, 3, 4, 8, 22 };
string input1Rep = string.Join(", ", input1);

WriteLine($"LinearSearch([{input1Rep}], 1), {LinearSearch(input1, 1)}");
WriteLine($"LinearSearch([{input1Rep}], 4), {LinearSearch(input1, 4)}");
WriteLine($"LinearSearch([{input1Rep}], 22), {LinearSearch(input1, 22)}");
WriteLine($"LinearSearch([{input1Rep}], 17), {LinearSearch(input1, 17)}");