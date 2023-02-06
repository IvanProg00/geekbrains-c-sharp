Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine());

int numDigits = GetNumDigits(num);
Console.WriteLine($"Number of digits {numDigits}");

int GetNumDigits(int num)
{
	int res = 0;

	while (num > 0)
	{
		num /= 10;
		res++;
	}

	return res;
}