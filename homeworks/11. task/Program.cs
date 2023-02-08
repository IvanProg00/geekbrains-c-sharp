int Pow(int num, int degree)
{
	int res = 1;

	for (int i = 1; i <= degree; i++)
	{
		res *= num;
	}

	return res;
}

Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine());

Console.Write("Enter degree: ");
int degree = int.Parse(Console.ReadLine());

int res = Pow(num, degree);
Console.WriteLine("Result is " + res);
