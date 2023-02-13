int AskNumber(string msg)
{
	Console.Write(msg);
	return int.Parse(Console.ReadLine());
}

int[] Fibonacci(int n)
{
	int prev = 0,
		curr = 1;

	int[] res = new int[n];

	if (n >= 1)
	{
		res[0] = prev;
	}
	if (n >= 2)
	{
		res[1] = curr;
	}

	for (int i = 2; i < n; i++)
	{
		int temp = curr;
		curr += prev;
		prev = temp;

		res[i] = curr;
	}
	return res;
}

int num = AskNumber("Enter number: ");
int[] fib = Fibonacci(num);
Console.WriteLine(String.Join(" ", fib));
