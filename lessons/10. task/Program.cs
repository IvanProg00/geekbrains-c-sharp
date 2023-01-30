Console.Write("Enter first number: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 * num1 == num2)
{
	Console.WriteLine("Square of the first number is equal to second number");
}
else if (num2 * num2 == num1)
{
	Console.WriteLine("Square of the second number is equal to first number");
}
else
{
	Console.WriteLine("There is no number being square of another");
}
