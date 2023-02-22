int AskNumber(string msg)
{
	Console.Write(msg);
	return int.Parse(Console.ReadLine());
}

void FillUniqueRandomNumbers(int[,,] arr, int minValue, int maxValue)
{
	int[] nums = Enumerable.Range(minValue, maxValue - minValue).ToArray();
	Random rand = new();

	for (int i = 0; i < nums.Length; i++)
	{
		int rndPos = rand.Next(nums.Length);
		int temp = nums[rndPos];
		nums[rndPos] = nums[i];
		nums[i] = temp;
	}

	int rndNumsIndex = 0;
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			for (int k = 0; k < arr.GetLength(2); k++)
			{
				arr[i, j, k] = nums[rndNumsIndex++];
			}
		}
	}
}

void PrintNumbers(int[,,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			for (int k = 0; k < arr.GetLength(2); k++)
			{
				Console.Write($"{arr[i, j, k]} ({i}, {j}, {k}) ");
			}
			Console.WriteLine();
		}
	}
}

int x = AskNumber("Enter number of numbers by x: ");
int y = AskNumber("Enter number of numbers by y: ");
int z = AskNumber("Enter number of numbers by z: ");

int[,,] arr = new int[x, y, z];
FillUniqueRandomNumbers(arr, 10, 100);
PrintNumbers(arr);
