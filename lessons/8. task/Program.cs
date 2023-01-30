Console.Write("Enter first number: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
int num2 = int.Parse(Console.ReadLine());

int balance = num1 % num2;
if (balance == 0)
{
	Console.WriteLine($"{num2} is a multiple of {num1}");
}
else
{
	Console.WriteLine($"{num2} is not a multiple of {num1}, reminder is {balance}");
}
