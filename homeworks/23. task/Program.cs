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
		Console.Write($"{i + 1}: ");
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			Console.Write(arr[i, j] + " ");
		}
		Console.WriteLine();
	}
}

int FindMinRowSum(int[,] arr)
{
	int res = -1;
	int minSum = 0;

	for (int i = 0; i < arr.GetLength(0); i++)
	{
		int sum = 0;
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			sum += arr[i, j];
		}

		if (res == -1)
		{
			res = i;
			minSum = sum;
		}
		else if (sum < minSum)
		{
			res = i;
			minSum = sum;
		}
	}

	return res;
}

int rows = AskNumber("Enter number of rows: "),
	cols = AskNumber("Enter number of columns: ");

int[,] arr = new int[rows, cols];
FillRandomNumbers(arr, 0, 10);
PrintNumbers(arr);
int minRow = FindMinRowSum(arr);
Console.WriteLine($"Minimum row is {minRow + 1}");
