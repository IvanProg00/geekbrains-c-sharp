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

void ReverseArray1(int[] arr)
{
	for (int i = 0; i < arr.Length / 2; i++)
	{
		int reversePos = arr.Length - i - 1;

		int temp = arr[i];
		arr[i] = arr[reversePos];
		arr[reversePos] = temp;
	}
}

int[] ReverseArray2(int[] arr)
{
	int[] res = new int[arr.Length];

	for (int i = 0; i < arr.Length; i++)
	{
		res[i] = arr[arr.Length - 1 - i];
	}

	return res;
}

int[] arr1 = new int[5];
FillRandomNumbers(arr1, 0, 11);
Console.WriteLine("Reverse array method 1");
PrintNumbers(arr1);
ReverseArray1(arr1);
PrintNumbers(arr1);

int[] arr2 = new int[5];
FillRandomNumbers(arr2, 0, 11);
Console.WriteLine("Reverse array method 2");
PrintNumbers(arr2);
int[] reverseArr = ReverseArray2(arr2);
PrintNumbers(reverseArr);

