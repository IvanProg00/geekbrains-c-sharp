Console.Write("Enter a three-digit number: ");

int num = int.Parse(Console.ReadLine());

if (num > 999 || num < 100)
{
	Console.WriteLine("The number must contain 3 digits");
}
else
{
	int res = num % 10;
	Console.WriteLine("Ответ: " + res);
}