Console.Write("Enter first number: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
int num2 = int.Parse(Console.ReadLine());

int min = num1,
	max = num2;

if (min > max)
{
	int v = min;
	min = max;
	max = v;
}

Console.WriteLine("The number " + min + " is less than " + max);
