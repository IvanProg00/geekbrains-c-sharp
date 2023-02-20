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

void ReplaceRows(int[,] arr)
{
	if (arr.GetLength(0) <= 1)
	{
		return;
	}

	int lastRow = arr.GetLength(0) - 1;

	for (int i = 0; i < arr.GetLength(1); i++)
	{
		int temp = arr[0, i];
		arr[0, i] = arr[lastRow, i];
		arr[lastRow, i] = temp;
	}
}

int rows = AskNumber("Enter number of rows: ");
int cols = AskNumber("Enter number of columns: ");

int[,] arr = new int[rows, cols];
FillArray(arr, 0, 20);
PrintNumbers(arr);
Console.WriteLine("__________");
ReplaceRows(arr);
PrintNumbers(arr);
