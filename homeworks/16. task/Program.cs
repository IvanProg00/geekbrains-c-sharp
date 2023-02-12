void FillRandomNumbers(double[] arr)
{
	Random rand = new Random();

	for (int i = 0; i < arr.Length; i++)
	{
		arr[i] = rand.NextDouble() * 10;
	}
}

void PrintNumbers(double[] arr)
{
	foreach (double val in arr)
	{
		Console.Write(val + " ");
	}
	Console.WriteLine();
}

double FindDifferenceMinAndMax(double[] arr)
{
	// If the array size is less than 2, it will return the value -1.
	// Because we can not find minimum and maximum.
	if (arr.Length < 2)
	{
		return -1;
	}

	double min = arr[0],
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

double[] arr = new double[6];
FillRandomNumbers(arr);
PrintNumbers(arr);

double diff = FindDifferenceMinAndMax(arr);
Console.WriteLine($"Difference between minimum and maximum is {diff}");
