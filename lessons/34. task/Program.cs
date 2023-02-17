int AskNumber(string msg)
{
	Console.Write(msg);
	return int.Parse(Console.ReadLine());
}

void FillArray(int[,] arr, int minValue, int maxValue)
{
	Random rand = new Random();

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

void FindNumbers(int[,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i += 2)
	{
		for (int j = 0; j < arr.GetLength(1); j += 2)
		{
			if (arr[i, j] % 2 == 1)
			{
				Console.WriteLine($"[{i}, {j}]");
			}
		}
	}
}

int rows = AskNumber("Enter rows: ");
int cols = AskNumber("Enter columns: ");
int minValue = AskNumber("Enter minimum random value: ");
int maxValue = AskNumber("Enter maximum random value: ");

int[,] arr = new int[rows, cols];
FillArray(arr, minValue, maxValue);
PrintNumbers(arr);
Console.WriteLine("____________________");
FindNumbers(arr);
