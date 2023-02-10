void FillRandomNumber(int[] arr, int from, int to)
{
	Random rand = new Random();

	for (int i = 0; i < arr.Length; i++)
	{
		arr[i] = rand.Next(from, to);
	}
}

void ReverseNums(int[] arr)
{
	for (int i = 0; i < arr.Length; i++)
	{
		arr[i] *= -1;
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

int[] arr = new int[4];
FillRandomNumber(arr, -9, 10);

PrintNums(arr);
ReverseNums(arr);
PrintNums(arr);
