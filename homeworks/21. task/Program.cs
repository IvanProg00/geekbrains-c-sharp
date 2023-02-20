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

double[] GetColumnsAverage(int[,] arr)
{
	double[] res = new double[arr.GetLength(1)];

	for (int i = 0; i < arr.GetLength(1); i++)
	{
		double val = 0.0;
		for (int j = 0; j < arr.GetLength(0); j++)
		{
			val += arr[j, i];
		}
		res[i] = val / arr.GetLength(0);
	}

	return res;
}

int rows = AskNumber("Enter number of rows: ");
int cols = AskNumber("Enter number of columns: ");

int[,] arr = new int[rows, cols];
FillRandomNumbers(arr, 0, 10);
PrintNumbers(arr);
double[] colsAvg = GetColumnsAverage(arr);

Console.WriteLine("__________");
Console.WriteLine(String.Join(", ", colsAvg));
