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
	foreach (int el in arr)
	{
		Console.Write(el + " ");
	}
	Console.WriteLine();
}

int CountFromTo(int[] arr, int from, int to)
{
	int count = 0;

	foreach (int val in arr)
	{
		if (val >= from && val < to)
		{
			count++;
		}
	}

	return count;
}

int[] arr = new int[1];

FillRandomNumbers(arr, 0, 200);
PrintNumbers(arr);

int from = 10,
	to = 100;
int countFromTo = CountFromTo(arr, from, to);

Console.WriteLine($"Чисел с {from}, до {to} = {countFromTo}");
