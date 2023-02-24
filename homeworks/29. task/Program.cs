int AskNumber(string msg)
{
	Console.Write(msg);
	return int.Parse(Console.ReadLine());
}

uint AckermannFunction(uint m, uint n)
{
	if (m == 0)
	{
		return n + 1;
	}

	if (n == 0)
	{
		return AckermannFunction(m - 1, 1);
	}

	return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

uint m = (uint)AskNumber("Enter number m: ");
uint n = (uint)AskNumber("Enter number n: ");
uint res = AckermannFunction(m, n);
Console.WriteLine($"A({m}, {n}) = {res}");
