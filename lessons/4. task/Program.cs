Console.Write("Enter a number: ");
int n = int.Parse(Console.ReadLine());

if (n < 0)
{
	Console.WriteLine("Number must be equal or greater than 0");
}
else
{
	int count = -n;

	while (count <= n)
	{
		Console.Write(count);
		if (count < n)
		{
			Console.Write(", ");
		}

		count++;
	}
	Console.WriteLine();
}
