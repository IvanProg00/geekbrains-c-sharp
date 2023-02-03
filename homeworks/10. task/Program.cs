Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine());

int i = 1;
while (i <= num)
{
	Console.Write(Math.Pow(i, 3));

	if (i < num)
	{
		Console.Write(", ");
	}

	i++;
}

Console.WriteLine();
