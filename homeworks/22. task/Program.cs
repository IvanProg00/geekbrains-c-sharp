int AskNumber(string msg)
{
	Console.Write(msg);
	return int.Parse(Console.ReadLine());
}

void FillRandomNumbers(int[,] arr, int minValue, int maxValue)
{
	Random rand = new();
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			arr[i, j] = rand.Next(minValue, maxValue);
		}
	}
}

void PrintNumbers(int[,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			Console.Write(arr[i, j] + " ");
		}
		Console.WriteLine();
	}
}

void SortDescending(int[,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		// Insertion sort
		for (int j = 1; j < arr.GetLength(1); j++)
		{
			var val = arr[i, j];
			int k = j - 1;

			while (k >= 0 && val > arr[i, k])
			{
				arr[i, k + 1] = arr[i, k];
				k--;
			}

			arr[i, k + 1] = val;
		}
	}
}

int rows = AskNumber("Enter number of rows: "),
	cols = AskNumber("Enter number of columns: ");

int[,] arr = new int[rows, cols];
FillRandomNumbers(arr, 0, 10);
PrintNumbers(arr);
Console.WriteLine("____________________");
SortDescending(arr);
PrintNumbers(arr);
