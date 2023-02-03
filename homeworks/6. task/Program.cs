int num = new Random().Next(1, 100_000);

if (num < 100)
{
	Console.WriteLine($"Number {num} has less than 3 digits");
}
else
{
	int res = num;

	while (res > 999)
	{
		res /= 10;
	}

	res %= 10;

	Console.WriteLine($"Third digit of number {num} is {res}");
}
