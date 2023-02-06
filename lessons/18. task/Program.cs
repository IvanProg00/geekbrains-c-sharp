Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine());

int productNums = GetProductNums(num);
Console.WriteLine($"Product of numbers from 1 to N {productNums}");

int GetProductNums(int num)
{
	int res = 1;

	for (int i = 1; i <= num; i++)
	{
		res *= i;
	}

	return res;
}