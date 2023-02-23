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

int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
	if (matrix1.GetLength(0) == 0)
	{
		return new int[0, 0];
	}

	int[,] res = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

	for (int i = 0; i < matrix1.GetLength(0); i++)
	{
		for (int j = 0; j < matrix1.GetLength(1); j++)
		{
			for (int k = 0; k < matrix1.GetLength(0); k++)
			{
				res[i, j] += matrix1[i, k] * matrix2[k, j];
			}
		}
	}

	return res;
}

int side = AskNumber("Enter number of number on each side in matrices: ");

int minValue = 0,
	maxValue = 10;
int[,] matrix1 = new int[side, side];
int[,] matrix2 = new int[side, side];

FillRandomNumbers(matrix1, minValue, maxValue);
FillRandomNumbers(matrix2, minValue, maxValue);

PrintNumbers(matrix1);
Console.WriteLine("____________________");
PrintNumbers(matrix2);
Console.WriteLine("____________________");
Console.WriteLine("Result:");
int[,] productMatrices = MultiplyMatrices(matrix1, matrix2);
PrintNumbers(productMatrices);
