int i = 1;

while (i < 100)
{
	bool isThree = i % 3 == 0;
	bool isFive = i % 5 == 0;

	if (isThree)
	{
		Console.Write("Fizz");
	}
	if (isFive)
	{
		Console.Write("Buzz");
	}

	if (!isThree && !isFive)
	{
		Console.Write(i);
	}

	Console.WriteLine();

	i++;
}
