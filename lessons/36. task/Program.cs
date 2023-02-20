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

int[,] FlipArray(int[,] arr)
{
	if (arr.GetLength(0) == 0 || arr.GetLength(1) == 0)
	{
		return new int[0, 0];
	}

	int[,] res = new int[arr.GetLength(1), arr.GetLength(0)];

	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			res[j, i] = arr[i, j];
		}
	}

	return res;
}

int rows = AskNumber("Enter number of rows: ");
int cols = AskNumber("Enter number of columns: ");

int[,] arr = new int[rows, cols];
FillArray(arr, 0, 20);
PrintNumbers(arr);
Console.WriteLine("__________");
int[,] arrFlip = FlipArray(arr);
PrintNumbers(arrFlip);
