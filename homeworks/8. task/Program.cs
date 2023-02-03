Console.Write("Enter 5 digit number: ");
int num = int.Parse(Console.ReadLine());

if (num >= 100_000 || num < 10_000)
{
	Console.WriteLine("Number must contain 5 digits");
	return;
}

if (num % 10 != num / 10_000 || num / 10 % 10 != num / 1000 % 10)
{
	Console.WriteLine("Not palindrome");
}
else
{
	Console.WriteLine("Palindrome");
}
