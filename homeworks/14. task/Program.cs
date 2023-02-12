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

int CountEvenNumbers(int[] arr)
{
	int res = 0;

	foreach (int val in arr)
	{
		if (val % 2 == 0)
		{
			res++;
		}
	}

	return res;
}

int[] arr = new int[5];

FillRandomNumbers(arr, 100, 1000);
PrintNumbers(arr);
int evenNums = CountEvenNumbers(arr);

Console.WriteLine($"Array has {evenNums} even numbers");
