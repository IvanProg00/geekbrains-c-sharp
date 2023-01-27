Console.Write("Enter first number: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
int num2 = int.Parse(Console.ReadLine());

int num2Sqr = num2 * num2;

if (num2Sqr == num1)
{
	Console.WriteLine("The first number is the square of the second");
}
else
{
	Console.WriteLine("The first number is not the square of the second");
}