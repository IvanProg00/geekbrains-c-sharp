void FillRandomNumbers(int[] arr, int from, int to)
{
	Random rand = new Random();

	for (int i = 0; i < arr.Length; i++)
	{
		arr[i] = rand.Next(from, to);
	}
}

int[] arr = new int[12];
FillRandomNumbers(arr, -9, 10);

int positiveSum = 0, negativeSum = 0;

foreach (int el in arr)
{
	if (el > 0)
	{
		positiveSum += el;
	}
	else if (el < 0)
	{
		negativeSum += el;
	}
}

Console.WriteLine($"Sum of positive numbers = {positiveSum}, sum of negative numbers = {negativeSum}");
