Console.Write("Enter quarter number: ");
int quarter = int.Parse(Console.ReadLine());

if (quarter == 1)
{
	Console.WriteLine("X > 0 && Y > 0");
}
else if (quarter == 2)
{
	Console.WriteLine("X < 0 && Y > 0");
}
else if (quarter == 3)
{
	Console.WriteLine("X < 0 && Y < 0");
}
else if (quarter == 3)
{
	Console.WriteLine("X > 0 && Y < 0");
}
else
{
	Console.WriteLine("Число должно быть от 1 до 4");
}
