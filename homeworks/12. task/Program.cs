int SumDigits(int num)
{
	int res = 0;

	while (num > 0)
	{
		res += num % 10;
		num /= 10;
	}

	return res;
}

Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine());

int sumDigits = SumDigits(num);
Console.WriteLine($"Sum of digits {sumDigits}");
