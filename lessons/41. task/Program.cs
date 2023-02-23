int AskNumber(string msg)
{
	Console.Write(msg);
	return int.Parse(Console.ReadLine());
}

int Pow(int num, int degree)
{
	if (degree <= 0)
	{
		return 1;
	}

	if (degree == 1)
	{
		return num;
	}

	return num * Pow(num, --degree);
}

int num = AskNumber("Enter number: ");
int degree = AskNumber("Enter degree: ");

int res = Pow(num, degree);
Console.WriteLine(res);
