void FillRandomNumbers(int[] arr, int minValue, int maxValue)
{
	Random rand = new Random();
	for (int i = 0; i < arr.Length; i++)
	{
		arr[i] = rand.Next(minValue, maxValue);
	}
}

void PrintNumbers(int[] arr)
{
	Console.WriteLine(String.Join(", ", arr));
}

int[] CopyArray(int[] arr)
{
	int[] res = new int[arr.Length];

	for (int i = 0; i < arr.Length; i++)
	{
		res[i] = arr[i];
	}

	return res;
}

int[] arr1 = new int[5];
FillRandomNumbers(arr1, 0, 11);
PrintNumbers(arr1);
int[] arr2 = CopyArray(arr1);
PrintNumbers(arr2);
