Console.Write("Write day of the week: ");
int weekDay = int.Parse(Console.ReadLine());

if (weekDay < 1 || weekDay > 7)
{
	Console.WriteLine("Day of the week can be from 1 to 7");
}
else if (weekDay > 5)
{
	Console.WriteLine("Weekend");
}
else
{
	Console.WriteLine("No weekend");
}
