void FillSpiralArray(int[,] arr)
{
	int until = arr.GetLength(0) * arr.GetLength(1);
	int direction = 0;
	int i = 0,
		j = 0;
	int startRows = 1,
		sizeRows = arr.GetLength(0),
		startCols = 0,
		sizeCols = arr.GetLength(1);

	for (int count = 1; count <= until; count++)
	{
		arr[i, j] = count;

		if (direction == 0)
		{
			if (j >= sizeCols - 2)
			{
				direction++;
				sizeCols--;
			}

			j++;
		}
		else if (direction == 1)
		{
			if (i >= sizeRows - 2)
			{
				direction++;
				sizeRows--;
			}
			i++;
		}
		else if (direction == 2)
		{
			if (j <= startCols + 1)
			{
				direction++;
				startCols++;
			}
			j--;
		}
		else
		{
			if (i <= startRows + 1)
			{
				direction = 0;
				startRows++;
			}
			i--;
		}
	}
}

void PrintNumbers(int[,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			Console.Write(arr[i, j].ToString("00") + " ");
		}
		Console.WriteLine();
	}
}

int size = 5;
int[,] arr = new int[size, size];
FillSpiralArray(arr);
PrintNumbers(arr);
