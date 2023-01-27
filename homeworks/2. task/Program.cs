Console.Write("Enter first number: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
int num2 = int.Parse(Console.ReadLine());

Console.Write("Enter third number: ");
int num3 = int.Parse(Console.ReadLine());

int max = num1;

if (num2 > max)
{
	max = num2;
}

if (num3 > max)
{
	max = num3;
}

Console.WriteLine("The maximum number is " + max);
