int AskNumber(string msg)
{
	Console.Write(msg);
	return int.Parse(Console.ReadLine());
}

void PrintNaturalNumber(int from, int to)
{
	if (from <= to)
	{
		Console.Write(from);

		if (from < to)
		{
			Console.Write(", ");
		}
		PrintNaturalNumber(from + 1, to);
	}
	else
	{
		Console.WriteLine();
	}
}

int m = AskNumber("Enter fist number: ");
int n = AskNumber("Enter second number: ");

PrintNaturalNumber(m, n);
