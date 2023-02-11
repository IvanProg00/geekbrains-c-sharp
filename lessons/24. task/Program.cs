void FillRandomNumbers(int[] arr, int from, int to)
{
	Random rand = new Random();

	for (int i = 0; i < arr.Length; i++)
	{
		arr[i] = rand.Next(from, to);
	}
}

void PrintNums(int[] arr)
{
	foreach (int el in arr)
	{
		Console.Write(el + " ");
	}
	Console.WriteLine();
}

int[] ProductArray(int[] arr)
{
	int midSize = (arr.Length + 1) / 2;
	int[] res = new int[midSize];

	for (int i = 0; i < midSize; i++)
	{
		int reversePos = arr.Length - i - 1;
		if (i != reversePos)
		{
			res[i] = arr[i] * arr[reversePos];
		}
		else
		{
			res[i] = arr[i];
		}
	}

	return res;
}

int[] arr = new int[5];
FillRandomNumbers(arr, 0, 20);
PrintNums(arr);

int[] result = ProductArray(arr);
PrintNums(result);
