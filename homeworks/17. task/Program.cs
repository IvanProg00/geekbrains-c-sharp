int[] AskNumbers(string msg, string sep)
{
	Console.Write(msg);
	string input = Console.ReadLine();

	string[] strs = input.Split(sep);
	int[] nums = new int[strs.Length];

	for (int i = 0; i < strs.Length; i++)
	{
		nums[i] = int.Parse(strs[i]);
	}

	return nums;
}

int CountPositiveNumbers(int[] arr)
{
	int res = 0;

	for (int i = 0; i < arr.Length; i++)
	{
		if (arr[i] > 0)
		{
			res++;
		}
	}

	return res;
}

string separator = ",";
int[] nums = AskNumbers($"Enter numbers using delimiter \"{separator}\": ", separator);
int res = CountPositiveNumbers(nums);
Console.WriteLine("Positive numbers " + res);
