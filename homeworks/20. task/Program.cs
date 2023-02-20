int AskNumber(string msg)
{
	Console.Write(msg);
	return int.Parse(Console.ReadLine());
}

void FillRandomNumbers(int[,] arr, int minValue, int maxValue)
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

void PrintElementFromArray(int[,] arr, int posRow, int posCol)
{
	if (posRow < 0 || posRow >= arr.GetLength(0) || posCol < 0 || posCol >= arr.GetLength(1))
	{
		Console.WriteLine("No element on this index");
	}
	else
	{
		Console.WriteLine($"[{posRow}, {posCol}] = {arr[posRow, posCol]}");
	}
}

int rows = AskNumber("Enter number of rows: ");
int cols = AskNumber("Enter number of columns: ");
int posRow = AskNumber("Enter index of element from rows: ");
int posCol = AskNumber("Enter index of element from columns: ");

int[,] arr = new int[rows, cols];
FillRandomNumbers(arr, 0, 10);
PrintNumbers(arr);
PrintElementFromArray(arr, posRow, posCol);
