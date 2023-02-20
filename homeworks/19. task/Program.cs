int AskNumber(string msg)
{
	Console.Write(msg);
	return int.Parse(Console.ReadLine());
}

void FillRandomNumbers(double[,] arr, int minValue, int maxValue)
{
	Random rand = new Random();

	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			arr[i, j] = Math.Round(rand.NextDouble() * (maxValue - minValue) + minValue, 2);
		}
	}
}

void PrintNumbers(double[,] arr)
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

int rows = AskNumber("Enter number of rows: ");
int cols = AskNumber("Enter number of columns: ");

double[,] arr = new double[rows, cols];

FillRandomNumbers(arr, -10, 10);
PrintNumbers(arr);
