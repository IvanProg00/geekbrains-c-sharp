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

int SumByOddIndexes(int[] arr)
{
	int res = 0;

	for (int i = 1; i < arr.Length; i += 2)
	{
		res += arr[i];
	}

	return res;
}

int[] arr = new int[6];
FillRandomNumbers(arr, -20, 21);
PrintNumbers(arr);
int sumOdd = SumByOddIndexes(arr);

Console.WriteLine($"Sum of odd indexes = {sumOdd}");
