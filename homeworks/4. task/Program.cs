Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());

int count = 2;

while (count <= num)
{
	Console.Write(count);

	if (count < num - 1)
	{
		Console.Write(", ");
	}

	count += 2;
}

Console.WriteLine();
