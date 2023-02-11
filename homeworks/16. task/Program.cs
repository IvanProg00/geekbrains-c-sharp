void FillRandomNumbers(int[] arr, int from, int to)
{
	Random rand = new Random();

	for (int i = 0; i < arr.Length; i++)
	{
		arr[i] = rand.Next(from, to);
	}
}

void PrintNumbers(int[] arr)
{
	foreach (int val in arr)
	{
		Console.Write(val + " ");
	}
	Console.WriteLine();
}

int FindDifferenceMinAndMax(int[] arr)
{
	// If the array size is less than 2, it will return the value -1.
	// Because we can not find minimum and maximum.
	if (arr.Length < 2)
	{
		return -1;
	}

	int min = arr[0],
		max = arr[0];

	for (int i = 1; i < arr.Length; i++)
	{
		if (min > arr[i])
		{
			min = arr[i];
		}

		if (max < arr[i])
		{
			max = arr[i];
		}
	}

	return max - min;
}

int[] arr = new int[6];
FillRandomNumbers(arr, 0, 100);
PrintNumbers(arr);

int diff = FindDifferenceMinAndMax(arr);
Console.WriteLine($"Difference between minimum and maximum is {diff}");
