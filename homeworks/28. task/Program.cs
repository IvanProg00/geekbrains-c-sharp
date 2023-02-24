int AskNumber(string msg)
{
	Console.Write(msg);
	return int.Parse(Console.ReadLine());
}

int NumbersRangeSum(int from, int to)
{
	if (from > to)
	{
		return 0;
	}

	return from + NumbersRangeSum(from + 1, to);
}

int from = AskNumber("Enter first number: ");
int to = AskNumber("Enter second number: ");
int numsSum = NumbersRangeSum(from, to);
Console.WriteLine($"Sum of numbers from {from} to {to} = {numsSum}");
