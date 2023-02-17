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

int SumDiagonalNumbers(int[,] arr)
{
	int res = 0;
	int pos = 0;

	while (pos < arr.GetLength(0) && pos < arr.GetLength(1))
	{
		res += arr[pos, pos];
		pos++;
	}

	return res;
}

int rows = AskNumber("Enter rows: ");
int cols = AskNumber("Enter columns: ");
int minValue = AskNumber("Enter minimum random value: ");
int maxValue = AskNumber("Enter maximum random value: ");

int[,] arr = new int[rows, cols];

FillArray(arr, minValue, maxValue);
PrintNumbers(arr);
int sumNums = SumDiagonalNumbers(arr);
Console.WriteLine("Sum of the numbers on the main diagonal = " + sumNums);
