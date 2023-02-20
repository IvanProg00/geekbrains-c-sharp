// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза


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

int[,] GetRepetitiveNumbers(int[,] arr)
{
	int[,] res = new int[arr.GetLength(0) * arr.GetLength(1), 2];
	int count = 0;

	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			int val = arr[i, j];
			int index = Find(res, count, val);

			if (index == -1)
			{
				res[count, 0] = val;
				res[count, 1] = 1;
				count++;
			}
			else
			{
				res[index, 1]++;
			}
		}
	}

	return res;
}

int Find(int[,] arr, int size, int val)
{
	for (int i = 0; i < size; i++)
	{
		if (arr[i, 0] == val)
		{
			return i;
		}
	}

	return -1;
}

void PrintData(int[,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		if (arr[i,1] == 0)
		{
			break;
		}
		Console.WriteLine($"{arr[i,0]} occurs {arr[i, 1]} times");
	}
}


int rows = AskNumber("Enter number of rows: ");
int cols = AskNumber("Enter number of columns: ");

int[,] arr = new int[rows, cols];
FillArray(arr, 0, 20);
PrintNumbers(arr);
Console.WriteLine("____________________");
int[,] res = GetRepetitiveNumbers(arr);
PrintData(res);
