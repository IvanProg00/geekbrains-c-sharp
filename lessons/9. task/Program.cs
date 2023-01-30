Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine());

if (num % 7 == 0 && num % 23 == 0)
{
	Console.WriteLine($"Number {num} is multiple of 7 and 23");
}
else
{
	Console.WriteLine($"Number {num} is not multiple of 7 and 23");
}
