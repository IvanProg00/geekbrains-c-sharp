void FillRandomNums(int[] arr, int from, int to)
{
	Random rand = new Random();

	for (int i = 0; i < arr.Length; i++)
	{
		arr[i] = rand.Next(from, to);
	}
}

void PrintNums(int[] arr)
{
	for (int i = 0; i < arr.Length; i++)
	{
		Console.Write(arr[i]);

		if (i < arr.Length - 1)
		{
			Console.Write(", ");
		}
	}

	Console.WriteLine();
}

int[] arr = new int[8];
FillRandomNums(arr, 1, 100);
PrintNums(arr);