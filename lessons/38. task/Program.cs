int AskNumber(string msg)
{
	Console.Write(msg);
	return int.Parse(Console.ReadLine());
}

void PrintNaturalNumber(int toNum, int num = 1)
{
	if (num <= toNum)
	{
		Console.Write(num);
		if (num < toNum)
		{
			Console.Write(", ");
		}

		PrintNaturalNumber(toNum, ++num);
	}
	else
	{
		Console.WriteLine();
	}
}

int num = AskNumber("Enter number: ");
PrintNaturalNumber(num);
