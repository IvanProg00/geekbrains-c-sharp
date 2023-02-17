int AskNumber(string msg)
{
	Console.Write(msg);
	return int.Parse(Console.ReadLine());
}

void FillArray(int[,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			arr[i, j] = i + j;
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

void PowEvenNumbers(int[,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i += 2)
	{
		for (int j = 0; j < arr.GetLength(1); j += 2)
		{
			arr[i, j] = arr[i, j] * arr[i, j];
		}
	}
}

int rows = AskNumber("Enter rows: ");
int cols = AskNumber("Enter columns: ");

int[,] arr = new int[rows, cols];

FillArray(arr);
PrintNumbers(arr);
Console.WriteLine("----------");
PowEvenNumbers(arr);
PrintNumbers(arr);
