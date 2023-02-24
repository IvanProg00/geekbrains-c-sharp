int AskNumber(string msg)
{
	Console.Write(msg);
	return int.Parse(Console.ReadLine());
}

void PrintNumbers(int num)
{
	if (num < 1)
	{
		return;
	}

	Console.Write(num);
	if (num > 1)
	{
		Console.Write(", ");
	}
	else
	{
		Console.WriteLine();
	}

	PrintNumbers(num - 1);
}

int num = AskNumber("Enter number: ");
PrintNumbers(num);
