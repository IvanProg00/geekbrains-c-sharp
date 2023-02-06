Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"Sum of numbers = {GetSumNums(num)}");

int GetSumNums(int num)
{
	int res = 0;

	while (num > 0)
	{
		res += num;
		num--;
	}

	return res;
}
