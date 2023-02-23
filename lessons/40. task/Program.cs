int AskNumber(string msg)
{
	Console.Write(msg);
	return int.Parse(Console.ReadLine());
}

int SumNumbers(int num)
{
	if (num <= 0)
	{
		return num;
	}

	return num % 10 + SumNumbers(num / 10);
}

int num = AskNumber("Enter number: ");

int res = SumNumbers(num);
Console.WriteLine(res);
